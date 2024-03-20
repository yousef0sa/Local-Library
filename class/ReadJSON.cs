using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Local_library
{
    public class items
    {
        public string image { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string link { get; set; }
    }

    internal class ReadJSON
    {
        public string filePath { get; set; }

        /// <summary>
        /// Retrieves a list of keys from a JSON file.
        /// </summary>
        /// <returns>A list of keys retrieved from the JSON file.</returns>
        public List<string> GetJsonKeys()
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                return jsonObject.Keys.ToList();
            }
        }

        /// <summary>
        /// Retrieves a list of items from a JSON file.
        /// </summary>
        /// <param name="JsonKey">The key in the JSON file to retrieve items from. If empty, items from all keys will be retrieved.</param>
        /// <returns>A list of items retrieved from the JSON file.</returns>
        public List<items> GetJsonItems(string JsonKey = "")
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty", "path");
            }
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, List<items>>>(json);
                if (!string.IsNullOrEmpty(JsonKey) && jsonObject.ContainsKey(JsonKey))
                {
                    return jsonObject[JsonKey];
                }
                return jsonObject.Values.SelectMany(x => x).ToList();
            }
        }
        /// <summary>
        /// Retrieves a collection of titles from the JSON items.
        /// </summary>
        /// <returns>An AutoCompleteStringCollection containing the titles of the items.</returns>
        public AutoCompleteStringCollection GetTitles()
        {
            var titles = new AutoCompleteStringCollection();
            var items = this.GetJsonItems();
            foreach (var item in items)
            {
                titles.Add(item.title);
            }
            return titles;
        }
    }
}
