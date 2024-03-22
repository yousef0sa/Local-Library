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
        private string filepath = "My files\\Games.json"; // setting the file path
        private string keySelected = "";
        private int currentPage = 1;
        private int totalPages = 0;
        private int itemsLoaded = 0;
        private Task searchTask = null;
        private const int ItemsPerLoad = 100; // setting the number of items to load per page

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Asynchronously loads items from a JSON file into the item_Panel control.
        /// </summary>
        /// <param name="key">The key in the JSON file to load items from.</param>
        /// <param name="searchText">Optional parameter. If provided, only items that contain the search text in their title will be loaded.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task LoadItems(string key, string searchText = null)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the content buttons
            loadContentButtons();

            // Set up auto-complete
            Search_kryptonTextBox.AutoCompleteCustomSource = readJSON.GetTitles();
        }

        #region {load Content} Buttons

        /// <summary>
        /// Loads content buttons for each key in the JSON file.
        /// If the file path exists, it creates a button for each key in the JSON file and adds the button to the content_Panel.
        /// </summary>
        private KryptonButton selectedButton = null;
        private void loadContentButtons()
        {
            //if the file path exists make button for each key in the json file and add the button in the content_Panel
            if (System.IO.File.Exists(filepath))
            {
                readJSON.filePath = filepath;
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
                        GC.Collect();
                        await LoadItems(key);
                        UpdatePagesLabel();
                        UpdateItemsLabel();
                    };
                    content_Panel.Controls.Add(button);
                }
            }
        }
        #endregion

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

        private async void Search_kryptonTextBox_TextChanged(object sender, EventArgs e)
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

                    await LoadItems(keySelected, search);

                    // Update the items and pages labels
                    UpdateItemsLabel(search);
                    UpdatePagesLabel(search);
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
                    UpdatePagesLabel();

                    await LoadItems(keySelected, Search_kryptonTextBox.Text);
                }
            }
        }
        #endregion

        #region {Next and Previous} Buttons
        /// <summary>
        /// Handles the Click event of the Next_kryptonButton control.
        /// If the current page is less than the total pages, it increments the currentPage by 1, clears the item_Panel control, 
        /// and loads the items for the next page.
        /// </summary>
        private async void Next_kryptonButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                item_Panel.Controls.Clear();
                GC.Collect();
                UpdatePagesLabel();
                await LoadItems(keySelected, Search_kryptonTextBox.Text);
            }
        }

        /// <summary>
        /// Handles the Click event of the Previous_kryptonButton control.
        /// If the current page is greater than 1, it decreases the currentPage by 1, clears the item_Panel control, 
        /// and loads the items for the previous page.
        /// </summary>
        private async void Previous_kryptonButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                itemsLoaded -= ItemsPerLoad * 2; // Subtract twice the ItemsPerLoad to go back to the previous page
                if (itemsLoaded < 0) itemsLoaded = 0; // Ensure itemsLoaded doesn't go below 0
                item_Panel.Controls.Clear();
                GC.Collect();
                UpdatePagesLabel();

                await LoadItems(keySelected, Search_kryptonTextBox.Text);
            }
        }
        #endregion

        #region {Update Pages and Items} Labels
        private void UpdateItemsLabel(string searchText = null)
        {
            int totalItems;
            if (!string.IsNullOrEmpty(searchText))
            {
                totalItems = readJSON.GetJsonItems()
                    .Where(x => x.title.ToLower().Contains(searchText.ToLower()))
                    .Count();
            }
            else
            {
                totalItems = readJSON.GetJsonItems(keySelected).Count();
            }
            Items_label.Text = $"Total Items: {totalItems}";
        }
        private void UpdatePagesLabel(string searchText = null)
        {
            // Calculate total pages
            int totalItems;
            if (!string.IsNullOrEmpty(searchText))
            {
                totalItems = readJSON.GetJsonItems()
                    .Where(x => x.title.ToLower().Contains(searchText.ToLower()))
                    .Count();
            }
            else
            {
                totalItems = readJSON.GetJsonItems(keySelected).Count();
            }
            totalPages = (int)Math.Ceiling((double)totalItems / ItemsPerLoad);

            Pages_label.Text = $"Page: {currentPage} - {totalPages}";

            Search_Page_kryptonTextBox.Text = currentPage.ToString();
        }
        #endregion
    }
}
