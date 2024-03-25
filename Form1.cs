using ComponentFactory.Krypton.Toolkit;
using Local_library.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_library
{
    public partial class Form1 : Form
    {
        private ReadJSON readJSON = new ReadJSON();
        private Settings settings = new Settings();
        private GetNumbers getNumbers = new GetNumbers();
        private GitHubReleaseChecker checker;

        private string keySelected = "";
        private int currentPage = 1;
        private int totalPages = 0;
        private int itemsLoaded = 0;
        private Task searchTask = null;

        #region Get && Set

        // getting the project version
        private string ProjectVersion
        {
            get { return Application.ProductVersion; }
        }

        // setting the number of items to load per page
        public int ItemsPerLoad
        {
            get { return Properties.Settings.Default.ItemsPerLoad; }
            set
            {
                Properties.Settings.Default.ItemsPerLoad = value;
                Properties.Settings.Default.Save();
            }
        }

        // setting the file path
        public string FilePath
        {
            get { return Properties.Settings.Default.FilePath; }
            set
            {
                Properties.Settings.Default.FilePath = value;
                Properties.Settings.Default.Save();
            }
        }

        public string Search_Text
        {
            get { return Search_kryptonTextBox.Text; }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();

            checker = new GitHubReleaseChecker("yousef0sa", "Test");

        }


        /// <summary>
        /// Asynchronously loads items from a JSON file based on the provided key and search text.
        /// If a search text is provided, it loads items that contain the search text.
        /// Otherwise, it loads items for the provided key.
        /// </summary>
        /// <param name="key">The key to search for in the JSON file.</param>
        /// <param name="searchText">The text to search for in the item titles.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task LoadItems(string key, string searchText)
        {
            // Load the items from the JSON file
            IEnumerable<items> items;

            if (!string.IsNullOrEmpty(searchText))
            {
                items = await Task.Run(() => readJSON.GetJsonItems()
                    .Where(x => x.title.ToLower().Contains(searchText.ToLower()))
                    .Skip(itemsLoaded)
                    .Take(ItemsPerLoad));
            }
            else
            {
                items = await Task.Run(() => readJSON.GetJsonItems(key)
                    .Skip(itemsLoaded)
                    .Take(ItemsPerLoad));
            }

            foreach (var item in items)
            {
                var itemControl = new ItemsForm
                {
                    image = item.image,
                    title = item.title,
                    info = item.info,
                    link = item.link
                };
                item_Panel.Controls.Add(itemControl);
            }
            itemsLoaded += items.Count();


            // Disable the "Next" button if there are no more items to load
            Next_kryptonButton.Enabled = items.Count() == ItemsPerLoad;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            // Update the version label
            Project_Version_label.Text = $"v{ProjectVersion}";

            // Load the file path from the program settings

            if (!string.IsNullOrEmpty(FilePath))
            {
                readJSON.filePath = FilePath;
                getNumbers.filePath = FilePath;
                Json_path_label.Text = FilePath;
            }
            else
            {
                if (settings.changeFilePath() == true)

                {   // Save the file path in the program settings
                    FilePath = settings.FilePath;

                    readJSON.filePath = FilePath;
                    getNumbers.filePath = FilePath;
                    Json_path_label.Text = FilePath;

                }
                else
                {
                    MessageBox.Show("Please select a JSON file to continue.", "No JSON file selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // load the content buttons
            loadContentButtons();

            // Set up auto-complete
            Search_kryptonTextBox.AutoCompleteCustomSource = readJSON.GetTitles();

            Change_items_per_page_kryptonTextBox.Text = ItemsPerLoad.ToString();

            // Check for new releases
            if (await checker.IsNewReleaseAvailable("v1"))
            {
                // if the new version is available show a message box and if the user press ok open the browser to the release page
                if (MessageBox.Show("A new version is available, do you want to download it?", "New version available", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(checker.URL_lastest_release);
                }

            }
        }

        #region window border panel

        #region move window
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Window_Border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Window_Border_panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Window_Border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        #endregion

        #region button events (minimize, maximize, close)
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void maximize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        #endregion

        #endregion

        #region Window Form1 events
        // resize the window by dragging the border edges
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTBOTTOMRIGHT = 17;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int BORDER_WIDTH = 10; // you can rename this variable if you like

            if (m.Msg == WM_NCHITTEST)
            {
                // get the mouse position (in screen coordinates)
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos); // convert to client coordinates

                // check if the mouse is within the resizable border (defined by BORDER_WIDTH)
                if (pos.X <= BORDER_WIDTH && pos.Y <= BORDER_WIDTH)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (pos.X >= this.ClientSize.Width - BORDER_WIDTH && pos.Y <= BORDER_WIDTH)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (pos.X >= this.ClientSize.Width - BORDER_WIDTH && pos.Y >= this.ClientSize.Height - BORDER_WIDTH)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (pos.X <= BORDER_WIDTH && pos.Y >= this.ClientSize.Height - BORDER_WIDTH)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (pos.Y <= BORDER_WIDTH)
                    m.Result = (IntPtr)HTTOP;
                else if (pos.X >= this.ClientSize.Width - BORDER_WIDTH)
                    m.Result = (IntPtr)HTRIGHT;
                else if (pos.Y >= this.ClientSize.Height - BORDER_WIDTH)
                    m.Result = (IntPtr)HTBOTTOM;
                else if (pos.X <= BORDER_WIDTH)
                    m.Result = (IntPtr)HTLEFT;
                else
                    base.WndProc(ref m); // let the base class handle it
            }
            else
            {
                base.WndProc(ref m);
            }
        }
        #endregion

        #region {Search} TextBox

        /// <summary>
        /// Handles the TextChanged event of the Search_kryptonTextBox control.
        /// Starts a new search after a delay of 800ms. If a previous search is still running, it is cancelled.
        /// The search is performed on the items in the JSON file.
        /// </summary>
        private void Search_kryptonTextBox_TextChanged(object sender, EventArgs e)
        {
            // Cancel the previous search if it's still running
            if (searchTask != null && !searchTask.IsCompleted)
            {
                return;
            }

            // Start a new search after a delay
            searchTask = Task.Run(async () =>
            {
                await Task.Delay(800); // Wait for 500ms

                // Invoke the search on the UI thread
                this.Invoke((Action)(async () =>
                {
                    // search the items in the json file
                    item_Panel.Controls.Clear();
                    itemsLoaded = 0;
                    GC.Collect();
                    var search = Search_kryptonTextBox.Text;
                    UpdateItemsLabel(search);
                    UpdatePagesLabel(search);

                    await LoadItems("", search);

                }));

            });

        }

        /// <summary>
        /// Handles the TextChanged event of the Search_Page_kryptonTextBox control.
        /// If the entered page number is valid, it clears the item_Panel control and loads the items for the specified page.
        /// </summary>
        private async void Search_Page_kryptonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Search_Page_kryptonTextBox.Text, out int page))
            {
                if (page > 0 && page <= totalPages)
                {
                    currentPage = page;
                    itemsLoaded = (currentPage - 1) * ItemsPerLoad; // Update itemsLoaded based on the new page number
                    item_Panel.Controls.Clear();
                    GC.Collect();
                    UpdatePagesLabel(Search_Text);

                    await LoadItems(keySelected, Search_kryptonTextBox.Text);
                }
            }
        }

        /// <summary>
        /// If the entered value is a valid integer, it updates the ItemsPerLoad property,
        /// clears the item_Panel control, and triggers garbage collection.
        /// </summary>
        private void Change_items_per_page_kryptonTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Change_items_per_page_kryptonTextBox.Text, out int itemsPerPage))
            {
                ItemsPerLoad = itemsPerPage;
                item_Panel.Controls.Clear();
                GC.Collect();
            }
        }
        #endregion

        #region Buttons

        #region {Settings} Button

        /// <summary>
        /// Toggles the size and location of the Settings_panel.
        /// </summary>
        private void Settings_kryptonButton_Click(object sender, EventArgs e)
        {
            if (Settings_panel.Height == 29)
            {
                Settings_panel.Size = new Size(201, 149);
                Settings_panel.Location = new Point(Settings_panel.Location.X, Settings_panel.Location.Y - (149 - 29));
            }
            else
            {
                Settings_panel.Location = new Point(Settings_panel.Location.X, Settings_panel.Location.Y + (149 - 29));
                Settings_panel.Size = new Size(201, 29);
            }
        }

        /// <summary>
        /// If the file path is successfully changed, it updates the FilePath, readJSON.filePath, and getNumbers.filePath properties,
        /// clears the content_Panel and item_Panel controls, updates the Json_path_label text, resets the keySelected, itemsLoaded, and currentPage variables,
        /// and loads the content buttons.
        /// </summary>
        private void Change_json_path_kryptonButton_Click(object sender, EventArgs e)
        {
            if (settings.changeFilePath() == true)
            {
                // Load the new file path
                FilePath = settings.FilePath;
                readJSON.filePath = FilePath;
                getNumbers.filePath = FilePath;

                //clear the content and item panel
                content_Panel.Controls.Clear();
                item_Panel.Controls.Clear();
                Json_path_label.Text = FilePath;

                // set to default values
                Pages_label.Text = "Page:";
                Items_label.Text = "Total Items:";
                Search_Page_kryptonTextBox.Text = "";
                Search_kryptonTextBox.Text = "";
                totalPages = 0;
                itemsLoaded = 0;
                keySelected = "";
                itemsLoaded = 0;
                currentPage = 1;

                // Load the content buttons
                loadContentButtons();
                GC.Collect();

            }
        }
        #endregion

        #region {Next and Previous} Buttons
        /// <summary>
        /// Handles the Click event of the Next_kryptonButton control.
        /// If the current page is less than the total pages, it increments the currentPage by 1, clears the item_Panel control, 
        /// and loads the items for the next page.
        /// </summary>
        private void Next_kryptonButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                item_Panel.Controls.Clear();
                GC.Collect();
                UpdatePagesLabel(Search_Text);
            }
        }

        /// <summary>
        /// Handles the Click event of the Previous_kryptonButton control.
        /// If the current page is greater than 1, it decreases the currentPage by 1, clears the item_Panel control, 
        /// and loads the items for the previous page.
        /// </summary>
        private void Previous_kryptonButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                itemsLoaded -= ItemsPerLoad * 2; // Subtract twice the ItemsPerLoad to go back to the previous page
                if (itemsLoaded < 0) itemsLoaded = 0; // Ensure itemsLoaded doesn't go below 0
                item_Panel.Controls.Clear();
                GC.Collect();
                UpdatePagesLabel(Search_Text);
            }
        }
        #endregion

        #region {load Content} Buttons

        /// <summary>
        /// Loads content buttons for each key in the JSON file.
        /// If the file path exists, it creates a button for each key in the JSON file and adds the button to the content_Panel.
        /// </summary>
        private KryptonButton selectedButton = null;
        private void loadContentButtons()
        {
            //if the file path exists make button for each key in the json file and add the button in the content_Panel
            if (System.IO.File.Exists(FilePath))
            {
                var keys = readJSON.GetJsonKeys();
                foreach (var key in keys)
                {
                    var button = new KryptonButton
                    {
                        Text = key,
                        ButtonStyle = ButtonStyle.NavigatorStack,
                        Location = new System.Drawing.Point(3, 3),
                        OverrideDefault =
                        {
                            Back =
                            {
                                Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117))))),
                            }
                        },
                        Size = new System.Drawing.Size(192, 25),
                        StateCommon =
                        {
                            Back =
                            {
                                Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44))))),
                                Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44))))),
                            },
                            Content =
                            {
                                LongText =
                                {
                                    Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250))))),
                                    Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250))))),
                                    Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold),
                                },
                                ShortText =
                                {
                                    Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250))))),
                                    Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250))))),
                                    Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold),
                                }
                            }
                        },
                        StateTracking =
                        {
                            Back =
                            {
                                Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117))))),
                                Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117))))),
                            }
                        }
                    };
                    button.Click += async (s, ev) =>
                    {
                        // If another button was previously selected, reset its appearance
                        if (selectedButton != null)
                        {
                            selectedButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
                            selectedButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
                        }

                        // Update the appearance of the newly selected button
                        button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
                        button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));

                        // Store the newly selected button
                        selectedButton = button;

                        item_Panel.Controls.Clear();
                        keySelected = key;
                        itemsLoaded = 0;
                        currentPage = 1;
                        Search_kryptonTextBox.Text = "";
                        GC.Collect();
                        await LoadItems(key, Search_Text);
                        UpdatePagesLabel(Search_Text);
                        UpdateItemsLabel(Search_Text);
                    };
                    content_Panel.Controls.Add(button);
                }
            }
        }
        #endregion

        #endregion

        #region {Update Pages and Items} Labels
        /// <summary>
        /// Updates the Items_label text to display the total number of items.
        /// If a search text is provided, it calculates the total items based on the number of items that contain the search text.
        /// Otherwise, it calculates the total items based on the number of items for the selected key.
        /// </summary>
        /// <param name="searchText">The text to search for in the item titles.</param>
        private void UpdateItemsLabel(string searchText)
        {
            int totalItems;
            if (!string.IsNullOrEmpty(searchText))
            {
                totalItems = getNumbers.GetTotalItemsFormTitle(searchText);
            }
            else
            {
                totalItems = getNumbers.GetTotalItemsWithJsonKey(keySelected);
            }
            Items_label.Text = $"Total Items: {totalItems}";
        }
        /// <summary>
        /// Updates the Pages_label text to display the current page and total pages.
        /// If a search text is provided, it calculates the total pages based on the number of items that contain the search text.
        /// Otherwise, it calculates the total pages based on the number of items for the selected key.
        /// </summary>
        /// <param name="searchText">The text to search for in the item titles.</param>
        private void UpdatePagesLabel(string searchText)
        {
            // Calculate total pages
            int totalItems;
            if (!string.IsNullOrEmpty(searchText))
            {
                totalItems = getNumbers.GetTotalItemsFormTitle(searchText);
            }
            else
            {
                totalItems = getNumbers.GetTotalItemsWithJsonKey(keySelected);
            }
            totalPages = (int)Math.Ceiling((double)totalItems / ItemsPerLoad);

            Pages_label.Text = $"Page: {currentPage} - {totalPages}";

            Search_Page_kryptonTextBox.Text = currentPage.ToString();
        }
        #endregion
    }
}
