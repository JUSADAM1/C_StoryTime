namespace STORY_TIME
{
    partial class Form5
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
            this.story_box = new System.Windows.Forms.RichTextBox();
            this.choice_Box = new System.Windows.Forms.ComboBox();
            this.choice_Button = new System.Windows.Forms.Button();
            this.Restart_Game = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.Continue2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // story_box
            // 
            this.story_box.Location = new System.Drawing.Point(50, 274);
            this.story_box.Name = "story_box";
            this.story_box.Size = new System.Drawing.Size(670, 164);
            this.story_box.TabIndex = 0;
            this.story_box.Text = "";
            // 
            // choice_Box
            // 
            this.choice_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.choice_Box.FormattingEnabled = true;
            this.choice_Box.Items.AddRange(new object[] {
            "Take Bugout bag!!!",
            "Run and Hide!!!!",
            "Just stand there and look STUPID!!!!"});
            this.choice_Box.Location = new System.Drawing.Point(325, 91);
            this.choice_Box.Name = "choice_Box";
            this.choice_Box.Size = new System.Drawing.Size(409, 21);
            this.choice_Box.TabIndex = 1;
            this.choice_Box.SelectedIndexChanged += new System.EventHandler(this.choice_Box_SelectedIndexChanged);
            // 
            // choice_Button
            // 
            this.choice_Button.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_Button.Location = new System.Drawing.Point(50, 66);
            this.choice_Button.Name = "choice_Button";
            this.choice_Button.Size = new System.Drawing.Size(229, 65);
            this.choice_Button.TabIndex = 2;
            this.choice_Button.Text = "Submit Decision";
            this.choice_Button.UseVisualStyleBackColor = true;
            this.choice_Button.Click += new System.EventHandler(this.choice_Button_Click);
            // 
            // Restart_Game
            // 
            this.Restart_Game.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart_Game.Location = new System.Drawing.Point(50, 158);
            this.Restart_Game.Name = "Restart_Game";
            this.Restart_Game.Size = new System.Drawing.Size(229, 37);
            this.Restart_Game.TabIndex = 3;
            this.Restart_Game.Text = "Restart the Game";
            this.Restart_Game.UseVisualStyleBackColor = true;
            this.Restart_Game.Click += new System.EventHandler(this.Restart_Game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "STORY BOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(467, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make A Choice";
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(430, 158);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(229, 37);
            this.Continue.TabIndex = 6;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Continue2
            // 
            this.Continue2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue2.Location = new System.Drawing.Point(430, 158);
            this.Continue2.Name = "Continue2";
            this.Continue2.Size = new System.Drawing.Size(229, 37);
            this.Continue2.TabIndex = 7;
            this.Continue2.Text = "Continue";
            this.Continue2.UseVisualStyleBackColor = true;
            this.Continue2.Click += new System.EventHandler(this.Continue2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STORY_TIME.Properties.Resources.Zombies_At_window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.Continue2);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart_Game);
            this.Controls.Add(this.choice_Button);
            this.Controls.Add(this.choice_Box);
            this.Controls.Add(this.story_box);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox story_box;
        private System.Windows.Forms.ComboBox choice_Box;
        private System.Windows.Forms.Button choice_Button;
        private System.Windows.Forms.Button Restart_Game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Continue2;
    }
}