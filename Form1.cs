using Local_library.UI;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_library
{
    public partial class Form1 : Form
    {
        private ReadJSON readJSON = new ReadJSON();
        private string filepath = "My files\\Games.json";
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
            GC.Collect();


            // Load initial items
            await LoadItems();
        }

        /// <summary>
        /// Asynchronously loads items from a JSON file and adds them to the item_Panel control.
        /// The number of items loaded per call is determined by the ItemsPerLoad constant.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task LoadItems(string key = "")
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
                await LoadItems();
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
                await LoadItems();
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
                    var button = new Button
                    {
                        Text = key,
                        TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                        FlatStyle = FlatStyle.Flat,
                        Size = new System.Drawing.Size(192, 23),
                        Location = new System.Drawing.Point(3, 3),
                        FlatAppearance = { BorderSize = 0 },
                        Name = key,
                        UseVisualStyleBackColor = true
                    };
                    button.Click += async (s, ev) =>
                    {
                        item_Panel.Controls.Clear();
                        itemsLoaded = 0;
                        GC.Collect();
                        await LoadItems(key);
                    };
                    content_Panel.Controls.Add(button);
                }
            }
        }
        #endregion
    }
}
