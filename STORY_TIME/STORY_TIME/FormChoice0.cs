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
    public partial class FormChoice0 : Form
    {
        public FormChoice0()
        {
            InitializeComponent();
        }

        private void FormChoice0_Load(object sender, EventArgs e)
        {
             MessageBox.Show("you have a " + Program.inventoryList.ElementAt(0));
             MessageBox.Show("you have a " + Program.inventoryList.ElementAt(1));
             MessageBox.Show("you have a  " + Program.inventoryList.ElementAt(2));
             MessageBox.Show("you have a  " + Program.inventoryList.ElementAt(3));
             MessageBox.Show("you have a  " + Program.inventoryList.ElementAt(4));
             MessageBox.Show("you have a  " + Program.inventoryList.ElementAt(5));
        }
    }
}
