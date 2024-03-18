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
            readJSON.filePath = "My files\\Games.json";

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
        private async Task LoadItems()
        {
            var items = await Task.Run(() => readJSON.GetJsonItems().Skip(itemsLoaded).Take(ItemsPerLoad));
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
    }
}
