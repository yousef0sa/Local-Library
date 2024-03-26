using ImageMagick;
using System;
using System.Drawing;
using System.IO;
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
        private async Task LoadImage()
        {
            if (!string.IsNullOrEmpty(this.image))
            {
                string localDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalLibrary");
                string localImagePath = Path.Combine(localDirectoryPath, this.image.GetHashCode().ToString());

                // Create the directory if it doesn't exist
                if (!Directory.Exists(localDirectoryPath))
                {
                    Directory.CreateDirectory(localDirectoryPath);
                }

                if (!File.Exists(localImagePath))
                {
                    using (System.Net.WebClient wc = new System.Net.WebClient())
                    {
                        try
                        {
                            // Ensure the URL is correctly formatted
                            Uri imageUri = new Uri(this.image);
                            byte[] bytes = await wc.DownloadDataTaskAsync(imageUri);
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
                                            imageBytes = output.ToArray(); // Save the bytes to a variable
                                        }

                                        try
                                        {
                                            // Save the image locally
                                            File.WriteAllBytes(localImagePath, imageBytes);
                                        }
                                        catch
                                        {
                                            // Log the exception and show a user-friendly message
                                            Console.WriteLine("An error occurred while saving the image to the local storage.");
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                //MessageBox.Show("An error occurred while saving the image to the local storage. Please check your disk space and try again.");
                                            });
                                        }

                                        // Update the PictureBox on the UI thread
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            if (pictureBox1.Image != null)
                                            {
                                                pictureBox1.Image.Dispose(); // Dispose the old image if it exists
                                            }
                                            pictureBox1.Image = Image.FromStream(new MemoryStream(imageBytes));
                                        });
                                    }
                                }
                            });

                        }
                        catch (System.Net.WebException ex)
                        {
                            // Log the exception and show a user-friendly message
                            Console.WriteLine(ex.ToString());
                            this.Invoke((MethodInvoker)delegate
                            {
                                //MessageBox.Show("An error occurred while downloading the image. Please check your network connection and try again.");

                            });
                        }
                    }
                }
                else
                {
                    // Load the image from the local file
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose(); // Dispose the old image if it exists
                        }
                        pictureBox1.Image = Image.FromFile(localImagePath);
                    });
                }

            }
            else
            {
                //change image to Local_library.Properties.Resources.no_image_available
                this.Invoke((MethodInvoker)delegate
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose(); // Dispose the old image if it exists
                    }
                    pictureBox1.Image = Local_library.Properties.Resources.no_image_available;

                });
            }
        }

        /// <summary>
        /// Event handler for the click event of the ItemsForm control.
        /// Opens the associated link in the default web browser.
        /// </summary>
        private void ItemsForm_Click(object sender, EventArgs e)
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
        private void load_title(string title)
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
        private void load_info(string info)
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
    }
}

