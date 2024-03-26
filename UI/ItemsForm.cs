using ImageMagick;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_library.UI
{
    public partial class ItemsForm : UserControl
    {
        public string image { get; set; }
        public string title { get; set; }
        public string info { get; set; }
        public string link { get; set; }

        public ItemsForm()
        {
            InitializeComponent();

            // Attach the click event handler to all controls
            this.Click += ItemsForm_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += ItemsForm_Click;
            }
        }

        /// <summary>
        /// Handles the Load event of the ItemsForm control.
        /// </summary>
        private async void ItemsForm_Load(object sender, EventArgs e)
        {
            // load json data into the form
            load_title(title);
            load_info(info);

            // Start loading the image in the background
            await Task.Run(() => LoadImage());
        }


        /// <summary>
        /// Asynchronously loads an image from a URL or local storage.
        /// If the image is not already stored locally, it is downloaded from the URL and saved.
        /// The image is then displayed in the PictureBox control.
        /// </summary>
        internal async Task LoadImage()
        {
            if (!string.IsNullOrEmpty(this.image) && await IsValidImageUrl(this.image))
            {
                string localDirectoryPath = GetLocalDirectoryPath();
                string localImagePath = GetLocalImagePath(localDirectoryPath);

                CreateDirectoryIfNotExists(localDirectoryPath);

                if (!File.Exists(localImagePath))
                {
                    await DownloadAndSaveImage(localDirectoryPath, localImagePath);
                }
                else
                {
                    LoadImageFromLocalFile(localImagePath);
                }
            }
            else
            {
                LoadDefaultImage();
            }
        }

        /// <summary>
        /// Event handler for the click event of the ItemsForm control.
        /// Opens the associated link in the default web browser.
        /// </summary>
        internal void ItemsForm_Click(object sender, EventArgs e)
        {
            // use the link to open the item in the browser
            if (string.IsNullOrEmpty(link))
            {
                MessageBox.Show("No link available for this item.");
            }
            else
            {
                System.Diagnostics.Process.Start(link);
            }
        }

        /// <summary>
        /// Loads the title into the title label.
        /// </summary>
        /// <param name="title">The title to be loaded.</param>
        internal void load_title(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                Title_label.Text = "No title available";
            }
            else
            {
                Title_label.Text = title.Replace("\r\n", string.Empty).Replace("\n", string.Empty);
            }
        }

        /// <summary>
        /// Loads the information into the info label.
        /// </summary>
        /// <param name="info">The information to be loaded.</param>
        internal void load_info(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                Info_label.Text = "No information available";
            }
            else
            {
                Info_label.Text = info.Replace("\r\n", string.Empty).Replace("\n", string.Empty);
            }
        }

        #region private Methods

        #region {LoadImage} Methods
        /// <summary>
        /// Gets the local directory path.
        /// </summary>
        /// <returns>The local directory path.</returns>
        private string GetLocalDirectoryPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalLibrary");
        }

        /// <summary>
        /// Gets the local image path based on the local directory path.
        /// </summary>
        /// <param name="localDirectoryPath">The local directory path.</param>
        /// <returns>The local image path.</returns>
        private string GetLocalImagePath(string localDirectoryPath)
        {
            return Path.Combine(localDirectoryPath, this.image.GetHashCode().ToString());
        }

        /// <summary>
        /// Creates a directory if it doesn't already exist.
        /// </summary>
        /// <param name="localDirectoryPath">The local directory path.</param>
        private void CreateDirectoryIfNotExists(string localDirectoryPath)
        {
            if (!Directory.Exists(localDirectoryPath))
            {
                Directory.CreateDirectory(localDirectoryPath);
            }
        }

        /// <summary>
        /// Asynchronously downloads and saves an image from a URL or local storage.
        /// </summary>
        /// <param name="localDirectoryPath">The local directory path to save the image.</param>
        /// <param name="localImagePath">The local file path to save the image.</param>
        internal async Task DownloadAndSaveImage(string localDirectoryPath, string localImagePath)
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                try
                {
                    Uri imageUri = new Uri(this.image);
                    byte[] bytes = await wc.DownloadDataTaskAsync(imageUri);
                    await SaveImageToLocal(bytes, localImagePath);
                }
                catch (System.Net.WebException ex)
                {
                    LogAndShowErrorMessage(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Asynchronously saves an image to the local storage.
        /// </summary>
        /// <param name="bytes">The byte array representing the image.</param>
        /// <param name="localImagePath">The local file path to save the image.</param>
        private async Task SaveImageToLocal(byte[] bytes, string localImagePath)
        {
            await Task.Run(() =>
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    using (MagickImage magickImage = new MagickImage(ms))
                    {
                        magickImage.Format = MagickFormat.Png;
                        byte[] imageBytes;
                        using (MemoryStream output = new MemoryStream())
                        {
                            magickImage.Write(output);
                            output.Position = 0;

                            imageBytes = output.ToArray();
                        }

                        try
                        {
                            File.WriteAllBytes(localImagePath, imageBytes);
                        }
                        catch
                        {
                            LogAndShowErrorMessage("An error occurred while saving the image to the local storage.");
                        }

                        UpdatePictureBox(imageBytes);
                    }
                }
            });
        }


        /// <summary>
        /// Logs the error message and shows it in the console.
        /// </summary>
        /// <param name="message">The error message to be logged and shown.</param>
        private void LogAndShowErrorMessage(string message)
        {
            Console.WriteLine(message);
            this.Invoke((MethodInvoker)delegate
            {
                //MessageBox.Show(message);
            });
        }

        /// <summary>
        /// Updates the PictureBox control with the specified image bytes.
        /// </summary>
        /// <param name="imageBytes">The byte array representing the image.</param>
        private void UpdatePictureBox(byte[] imageBytes)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                using (var ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            });
        }

        /// <summary>
        /// Loads the image from a local file path and displays it in the PictureBox control.
        /// </summary>
        /// <param name="localImagePath">The local file path of the image.</param>
        private void LoadImageFromLocalFile(string localImagePath)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = Image.FromFile(localImagePath);
            });
        }

        /// <summary>
        /// Loads the default image into the PictureBox control.
        /// </summary>
        private void LoadDefaultImage()
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = Local_library.Properties.Resources.no_image_available;
            });
        }

        /// <summary>
        /// Checks if the given image URL is valid.
        /// </summary>
        /// <param name="imageUrl">The URL of the image.</param>
        /// <returns>True if the image URL is valid; otherwise, false.</returns>
        internal async Task<bool> IsValidImageUrl(string imageUrl)
        {
            try
            {
                var request = WebRequest.Create(imageUrl);
                request.Method = "HEAD";
                request.Timeout = 5000; // Set timeout to 5 seconds
                using (var response = await request.GetResponseAsync())
                {
                    return response.ContentType.ToLower(CultureInfo.InvariantCulture).StartsWith("image/");
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #endregion
    }
}

