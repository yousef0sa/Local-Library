using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_library.UI
{
    public partial class ItemsForm : UserControl
    {
        public string image { get; set; }
        public string first_text { get; set; }
        public string second_text { get; set; }

        public ItemsForm()
        {
            InitializeComponent();
        }
    }
}
