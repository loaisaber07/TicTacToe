namespace TicTakToc
{
    partial class Form2
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
            p1name = new Label();
            p2name = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            playerNow = new Label();
            winner = new Label();
            SuspendLayout();
            // 
            // p1name
            // 
            p1name.AutoSize = true;
            p1name.Location = new Point(38, 20);
            p1name.Name = "p1name";
            p1name.Size = new Size(105, 32);
            p1name.TabIndex = 0;
            p1name.Text = "Player 1 ";
            // 
            // p2name
            // 
            p2name.AutoSize = true;
            p2name.Location = new Point(451, 20);
            p2name.Name = "p2name";
            p2name.Size = new Size(98, 32);
            p2name.TabIndex = 1;
            p2name.Text = "Player 2";
            // 
            // button1
            // 
            button1.Location = new Point(76, 89);
            button1.Name = "button1";
            button1.Size = new Size(136, 88);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 89);
            button2.Name = "button2";
            button2.Size = new Size(136, 88);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(360, 89);
            button3.Name = "button3";
            button3.Size = new Size(136, 88);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(76, 187);
            button4.Name = "button4";
            button4.Size = new Size(136, 88);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(218, 194);
            button5.Name = "button5";
            button5.Size = new Size(136, 88);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(360, 187);
            button6.Name = "button6";
            button6.Size = new Size(136, 88);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(76, 292);
            button7.Name = "button7";
            button7.Size = new Size(136, 88);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(218, 292);
            button8.Name = "button8";
            button8.Size = new Size(136, 88);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(360, 292);
            button9.Name = "button9";
            button9.Size = new Size(136, 88);
            button9.TabIndex = 10;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // playerNow
            // 
            playerNow.AutoSize = true;
            playerNow.Location = new Point(250, 397);
            playerNow.Name = "playerNow";
            playerNow.Size = new Size(78, 32);
            playerNow.TabIndex = 11;
            playerNow.Text = "label1";
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Location = new Point(471, 397);
            winner.Name = "winner";
            winner.Size = new Size(0, 32);
            winner.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(winner);
            Controls.Add(playerNow);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(p2name);
            Controls.Add(p1name);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label p1name;
        private Label p2name;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label playerNow;
        private Label winner;
    }
}