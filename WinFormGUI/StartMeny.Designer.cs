namespace WinFormGUI
{
    partial class StartMeny
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
            label1 = new Label();
            btnResenärLogin = new Button();
            label2 = new Label();
            btnMaskinAnsvarLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 55);
            label1.TabIndex = 0;
            label1.Text = "Book Travelers";
            // 
            // btnResenärLogin
            // 
            btnResenärLogin.Location = new Point(12, 110);
            btnResenärLogin.Name = "btnResenärLogin";
            btnResenärLogin.Size = new Size(75, 23);
            btnResenärLogin.TabIndex = 1;
            btnResenärLogin.Text = "Resenär";
            btnResenärLogin.UseVisualStyleBackColor = true;
            btnResenärLogin.Click += btnResenärLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 3;
            label2.Text = "Tryck på relevant användartyp för att logga in";
            // 
            // btnMaskinAnsvarLogin
            // 
            btnMaskinAnsvarLogin.Location = new Point(106, 110);
            btnMaskinAnsvarLogin.Name = "btnMaskinAnsvarLogin";
            btnMaskinAnsvarLogin.Size = new Size(112, 23);
            btnMaskinAnsvarLogin.TabIndex = 4;
            btnMaskinAnsvarLogin.Text = "Maskinansvarig";
            btnMaskinAnsvarLogin.UseVisualStyleBackColor = true;
            btnMaskinAnsvarLogin.Click += btnMaskinAnsvarLogin_Click;
            // 
            // StartMeny
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 159);
            Controls.Add(btnMaskinAnsvarLogin);
            Controls.Add(label2);
            Controls.Add(btnResenärLogin);
            Controls.Add(label1);
            Name = "StartMeny";
            Text = "StartMeny";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnResenärLogin;
        private Label label2;
        private Button btnMaskinAnsvarLogin;
    }
}