using ComponentFactory.Krypton.Toolkit;
using Local_library.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_library
{
    public partial class Form1 : Form
    {
        private ReadJSON readJSON = new ReadJSON();
        private string filepath = "My files\\Games.json";
        private string keySelected = "";
        public Form1()
        {
            InitializeComponent();
            // Handle mouse wheel scrolling
            item_Panel.MouseWheel += item_Panel_MouseWheel;
        }

        private int itemsLoaded = 0;
        private const int ItemsPerLoad = 45;

        /// <summary>
        /// Event handler for the All_subjects_button click event.
        /// Clears the item_Panel control and loads a new set of items from the Games.json file.
        /// </summary>
        private async void All_subjects_button_Click(object sender, EventArgs e)
        {
            //get the json file path
            readJSON.filePath = filepath;

            // clear the memory 
            item_Panel.Controls.Clear();
            itemsLoaded = 0;
            keySelected = "";
            GC.Collect();


            // Load initial items
            await LoadItems(keySelected);
        }

        /// <summary>
        /// Asynchronously loads items from a JSON file and adds them to the item_Panel control.
        /// The number of items loaded per call is determined by the ItemsPerLoad constant.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task LoadItems(string key)
        {
            var items = await Task.Run(() => readJSON.GetJsonItems(key).Skip(itemsLoaded).Take(ItemsPerLoad));
            foreach (var item in items)
            {
                var itemControl = new ItemsForm
                {
                    image = item.image,
                    title = item.title,
                    date = item.date,
                    link = item.link
                };
                item_Panel.Controls.Add(itemControl);
            }
            itemsLoaded += items.Count();
        }


        /// <summary>
        /// Handles the MouseWheel event of the item_Panel control.
        /// This method is triggered when the mouse wheel is scrolled.
        /// If the scroll position is at the bottom, it loads more items.
        /// </summary>
        private async void item_Panel_MouseWheel(object sender, MouseEventArgs e)
        {
            // If scrolled to bottom
            if (item_Panel.VerticalScroll.Value >= item_Panel.VerticalScroll.Maximum - item_Panel.VerticalScroll.LargeChange)
            {
                await LoadItems(keySelected);
                // clear the memory 
                GC.Collect();
            }
        }

        /// <summary>
        /// Handles the Scroll event of the item_Panel control.
        /// If the scroll position is at the bottom, it loads more items.
        /// </summary>
        private async void item_Panel_Scroll(object sender, ScrollEventArgs e)
        {
            // If scrolled to bottom
            if (item_Panel.VerticalScroll.Value >= item_Panel.VerticalScroll.Maximum - item_Panel.VerticalScroll.LargeChange)
            {
                await LoadItems(keySelected);
                // clear the memory 
                GC.Collect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the content buttons
            loadContentButtons();
        }

        #region private function

        /// <summary>
        /// Loads content buttons for each key in the JSON file.
        /// If the file path exists, it creates a button for each key in the JSON file and adds the button to the content_Panel.
        /// </summary>
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
                        item_Panel.Controls.Clear();
                        keySelected = key;
                        itemsLoaded = 0;
                        GC.Collect();
                        await LoadItems(key);
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
    }
}
