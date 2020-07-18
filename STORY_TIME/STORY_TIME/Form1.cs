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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start1.Hide();
            NameLabel.Hide();
            UsernameInput.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program.inventoryList = new List<string>();
            //Program.inventoryList.Add("Crowbar");

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
           
            Start1.Show();
            NameLabel.Show();
            UsernameInput.Show();
            Start_Button.Hide();
        }
        // Quit button
        private void Quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        //When button is clicked name switcher function is activated and then next form
        private void Start1_Click(object sender, EventArgs e)
        {
            name_form_switcher();
        }
        //Once name is inputted the crrectly then it will switch to the nex form
        private void name_form_switcher()
        {
            // For user name input
            string Username = UsernameInput.Text;
            // For if user doesnt input there name.
            if (String.IsNullOrEmpty(Username))
            {
                // MessageBox will pop up if you dont 
                MessageBox.Show("No Username provide.");
            }
            else
            {
                // Hides form after
                this.Hide();
                Form2 openForm = new Form2();
                // Opens Form 2;
                openForm.Show();
            }
        }
    }
}
