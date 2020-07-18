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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("I got your " + Program.inventoryList.ElementAt(0) + " right here." );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is used to load up form 3 
            Form3 openForm = new Form3();
            // We close form 2
            openForm.Show();
            // Closing form 2
            Visible = false;
        }
    }
}
