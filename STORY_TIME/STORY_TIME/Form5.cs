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
    public partial class Form5 : Form
    {
    
        public Form5()
        {
            InitializeComponent();
            Restart_Game.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // List 1 where the Character gets everything
             Program.inventoryList = new List<string>();
            // List 2 is a little bit hard the player doesnt get everything which makes it hard
             Program.inventoryList2 = new List<string>();
          
        }

        private void choice_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
        //Choices being made
        private void choices1()
        { 
            //Switch statment to makes choices
            switch(choice_Box.SelectedIndex)
            {
                // To Be honest I totally for got how different C# is when it came down to certain thing like switch statements and other things. 
                case 0:
                    // The first choice
                    choice_Made_0();
                    Restart_Game.Show();
                    break;
                    //Standing like a dumbass while zombies are coming choice.
                case 1:
                    choice_made_1();
                    Restart_Game.Show();
                        break;
                // The die choice
                case 2:
                    choice_made_2();
                    Restart_Game.Show();
                    break;
            }
                
            }

        // This is so choices are confirmed when user picks a choice
        private void choice_Button_Click(object sender, EventArgs e)
        {
            // Submit button
            choices1();
          
        }
        // The restart Function
        private void Restart_Game_Click(object sender, EventArgs e)
        {
            Restart();
        }
        // If user pick the 'Die choice they can restart the game or quit!'
        private void Restart ()
        {
            // To restart the game
            Application.Restart();
        }
        // This Function is for when the user makes the first which is the bugout choice.
        private void choice_Made_0()
        {
            //Background changes when choice is selceted.
            this.BackgroundImage = Properties.Resources.choice1_pic;
            // I had to put this all in a text box instead of doing storybox.text all the time I just decided to just put newline
            story_box.Text = "Since your choice was to take the bugout bag which consist of: " + Environment.NewLine +"1 medic kit" 
                + "\nBullet Proof Vest" + "\nknee guards" + "Survival kit" +"\n1 Colt .45 ACP  with 3 magazines, 27 rounds" + "\n1 Ruger AR-556 5.56 Semiautomatic Rifle, with 90 rounds of 5.56 NATO" +"\n\nAR Attachments: " +
                "\nSights: 45 Degree AR-15 Transition Sight combo with Red dot sight" + "\nFAB Defense Quick Release Vertical Foregrip " + "\n\n" + 
                "Since you grabbed the bugout bag, you decided to lock and load and start killin some ZOMBIES, because they are in front of your window.\n" + "Before you started blasting off shot you see headlight coming straight towards your window and move out the way." +
                "Turns to find out it is your friends coming to pick up!! and armed to the teeth"+ "\n\nSTORY TO BE CONTINUED!!!!!!!!!!!!";
            choice_Button.Hide();
            Continue2.Hide();
           
            Program.inventoryList.Add("1 medic kit");
            Program.inventoryList.Add("Bullet Proof Vest");
            Program.inventoryList.Add("knee guardsSurvival kit");
            Program.inventoryList.Add("1 Colt .45 ACP  with 3 magazines, 27 rounds");
            Program.inventoryList.Add("1 Ruger AR-556 5.56 Semiautomatic Rifle, with 90 rounds of 5.56 NATO\n " +
                " AR Attachments: \n" +
                "       Sights: 45 Degree AR-15 Transition Sight combo with Red dot sight\n" + 
                "       FAB Defense Quick Release Vertical Foregrip "
                );
            Program.inventoryList.Add("Tool Kit");
        }

        private void choice_made_1()
        {
            this.BackgroundImage = Properties.Resources.hiding;
            story_box.Text = "Since you decided to run and hide you decided that the best place was to hide in your walking closet which had nothing but a couple of knives." + "\nAs you here Zombies break in you hear a loud truck come blast through the wall" + 
                "\nAnd you here your name and yell out here and it was your friends who are armed to the teeth. They asked you do you have your bugout bag and you reply No." + "So you end up getting it" + 
                "as you hope in the back you decide to check the bag and realized some of your equipment is broken and missing because you were in a rush";
            choice_Button.Hide();
            Continue.Hide();
            
            Program.inventoryList2.Add("Bullet Proof Vest");
            Program.inventoryList2.Add("1 Ruger AR-556 5.56 Semiautomatic Rifle, with 90 rounds of 5.56 NATO\n " +
                " AR Attachments: \n" +
                "       Sights: 45 Degree AR-15 Transition Sight combo with Red dot sight\n" + 
                "       FAB Defense Quick Release Vertical Foregrip "
                );
            Program.inventoryList2.Add("Tool Kit");
        }
        private void choice_made_2()
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }
        //When the user click the continue button on choice 0 'Which is the bugout bag it got to the new page'
        private void Continue_Click(object sender, EventArgs e)
        {
            
          choice0_continue();
           
        }
        private void choice0_continue()
        {
            choice_Made_0();
            FormChoice0 openForm = new FormChoice0();
            openForm.Show();
            Visible = false;


        }
        //
        private void choice1_continue()
        {
            choice_made_1();
            FormChoice1 openForm = new FormChoice1();
            openForm.Show();
            Visible = false;
        }

        private void Continue2_Click(object sender, EventArgs e)
        {
            choice1_continue();
        }
    }
}
