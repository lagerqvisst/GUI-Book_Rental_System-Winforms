namespace WinFormGUI
{
    partial class ResenärStart
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
            dataGridViewResenär = new DataGridView();
            btnResenärLoggain = new Button();
            label1 = new Label();
            btnRefreshResenärData = new Button();
            btnTillbakaFrånResenärStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResenär).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResenär
            // 
            dataGridViewResenär.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResenär.Location = new Point(12, 72);
            dataGridViewResenär.Name = "dataGridViewResenär";
            dataGridViewResenär.RowTemplate.Height = 25;
            dataGridViewResenär.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResenär.Size = new Size(465, 152);
            dataGridViewResenär.TabIndex = 0;
            dataGridViewResenär.CellClick += dataGridViewResenär_CellClick;
            // 
            // btnResenärLoggain
            // 
            btnResenärLoggain.Location = new Point(12, 243);
            btnResenärLoggain.Name = "btnResenärLoggain";
            btnResenärLoggain.Size = new Size(75, 23);
            btnResenärLoggain.TabIndex = 1;
            btnResenärLoggain.Text = "Logga in";
            btnResenärLoggain.UseVisualStyleBackColor = true;
            btnResenärLoggain.Click += btnResenärLoggain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "Välj användare";
            // 
            // btnRefreshResenärData
            // 
            btnRefreshResenärData.Location = new Point(346, 243);
            btnRefreshResenärData.Name = "btnRefreshResenärData";
            btnRefreshResenärData.Size = new Size(131, 23);
            btnRefreshResenärData.TabIndex = 3;
            btnRefreshResenärData.Text = "Uppdatera Data";
            btnRefreshResenärData.UseVisualStyleBackColor = true;
            btnRefreshResenärData.Click += btnRefreshResenärData_Click;
            // 
            // btnTillbakaFrånResenärStart
            // 
            btnTillbakaFrånResenärStart.BackColor = SystemColors.InactiveCaptionText;
            btnTillbakaFrånResenärStart.ForeColor = SystemColors.ButtonHighlight;
            btnTillbakaFrånResenärStart.Location = new Point(12, 326);
            btnTillbakaFrånResenärStart.Name = "btnTillbakaFrånResenärStart";
            btnTillbakaFrånResenärStart.Size = new Size(75, 23);
            btnTillbakaFrånResenärStart.TabIndex = 4;
            btnTillbakaFrånResenärStart.Text = "Tillbaka";
            btnTillbakaFrånResenärStart.UseVisualStyleBackColor = false;
            btnTillbakaFrånResenärStart.Click += btnTillbakaFrånResenärStart_Click;
            // 
            // ResenärStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 361);
            Controls.Add(btnTillbakaFrånResenärStart);
            Controls.Add(btnRefreshResenärData);
            Controls.Add(label1);
            Controls.Add(btnResenärLoggain);
            Controls.Add(dataGridViewResenär);
            Name = "ResenärStart";
            Text = "ResenärStart";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResenär).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResenär;
        private Button btnResenärLoggain;
        private Label label1;
        private Button btnRefreshResenärData;
        private Button btnTillbakaFrånResenärStart;
    }
}