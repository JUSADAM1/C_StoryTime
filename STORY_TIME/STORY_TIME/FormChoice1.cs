using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STORY_TIME
{
    public partial class FormChoice1 : Form
    {
        public FormChoice1()
        {
            InitializeComponent();
        }

        private void FormChoice1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("you have a " + Program.inventoryList2.ElementAt(0));
             MessageBox.Show("you have a " + Program.inventoryList2.ElementAt(1));
             MessageBox.Show("you have a  " + Program.inventoryList2.ElementAt(2));
        }
    }
}
