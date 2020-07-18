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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Well when we click this button we branch off to form 4
        private void Open_The_Door_Click(object sender, EventArgs e)
        {
            // Calling form 4
            Form4 openForm = new Form4();
            // Show form 4
            openForm.Show();
            // Closing form 3
            Visible = false;
        }
        // Branching off to form 5
        private void Go_To_Room_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
            Visible = false;
        }
    }
}
