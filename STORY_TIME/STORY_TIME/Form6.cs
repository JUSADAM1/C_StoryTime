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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        static Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
           random_Number();
        }
        private void random_Number()
        {
            for (int i = 0; i < 1; i++)
            {
                MessageBox.Show("You Killed this many people before you died: " + Convert.ToString(random.Next(10,20)));
                Application.Restart();
            }
        }
        
    }
}
