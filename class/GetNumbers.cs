using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_library
{
    internal class GetNumbers
    {
        ReadJSON readJSON = new ReadJSON();
        Form1 MainForm;

        public GetNumbers(Form1 mainForm)
        {
            MainForm = mainForm;
            readJSON.filePath = MainForm.FilePath;
        }

        /// <summary>
        /// Gets the total number of items from the JSON data that contain the specified key.
        /// </summary>
        /// <param name="key">The key to search for in the JSON data.</param>
        /// <returns>The total number of items that contain the specified key.</returns>
        public int GetTotalItemsWithJsonKey(string key)
        {
            return readJSON.GetJsonItems(key).Count;
        }

        /// <summary>
        /// Gets the total number of items from the JSON data that contain the specified title.
        /// </summary>
        /// <param name="title">The title to search for in the JSON data.</param>
        /// <returns>The total number of items that contain the specified title.</returns>
        public int GetTotalItemsFormTitle(string title)
        {
            return readJSON.GetJsonItems().Where(x => x.title.ToLower().Contains(title.ToLower())).Count();
        }
    }
}
