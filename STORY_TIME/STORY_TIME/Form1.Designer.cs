namespace STORY_TIME
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Start1 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(76, 31);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(618, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome to Zombie or Survive";
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Green;
            this.Start_Button.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.Black;
            this.Start_Button.Location = new System.Drawing.Point(11, 104);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(225, 48);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "PLAY OR DIE!";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Black;
            this.Quit.Location = new System.Drawing.Point(11, 181);
            this.Quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(225, 48);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "QUITTER!!!!";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(473, 104);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(210, 23);
            this.Start1.TabIndex = 3;
            this.Start1.Text = "Start Game";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(356, 215);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 22);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Username:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(495, 216);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(157, 20);
            this.UsernameInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STORY_TIME.Properties.Resources.wp2740272;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 447);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ZOMBIE_DUDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox UsernameInput;
    }
}

