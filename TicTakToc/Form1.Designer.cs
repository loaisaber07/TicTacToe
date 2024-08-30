namespace TicTakToc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            p1Name = new TextBox();
            p2Name = new TextBox();
            logGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(671, 65);
            label1.TabIndex = 0;
            label1.Text = "welcome to TocTaKTocGame";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 144);
            label2.Name = "label2";
            label2.Size = new Size(169, 50);
            label2.TabIndex = 1;
            label2.Text = "Player 1 :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 278);
            label3.Name = "label3";
            label3.Size = new Size(160, 50);
            label3.TabIndex = 2;
            label3.Text = "player 2:";
            label3.Click += label3_Click;
            // 
            // p1Name
            // 
            p1Name.Location = new Point(314, 155);
            p1Name.Name = "p1Name";
            p1Name.Size = new Size(365, 39);
            p1Name.TabIndex = 3;
            // 
            // p2Name
            // 
            p2Name.Location = new Point(325, 289);
            p2Name.Name = "p2Name";
            p2Name.Size = new Size(354, 39);
            p2Name.TabIndex = 4;
            // 
            // logGame
            // 
            logGame.Location = new Point(406, 423);
            logGame.Name = "logGame";
            logGame.Size = new Size(202, 46);
            logGame.TabIndex = 5;
            logGame.Text = "Log To Game";
            logGame.TextAlign = ContentAlignment.BottomCenter;
            logGame.UseVisualStyleBackColor = true;
            logGame.Click += logGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 534);
            Controls.Add(logGame);
            Controls.Add(p2Name);
            Controls.Add(p1Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox p1Name;
        private TextBox p2Name;
        private Button logGame;
    }
}
