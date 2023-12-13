namespace WinFormGUI
{
    partial class AnsvarigStart
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
            dataGridViewMaskinAnsvariga = new DataGridView();
            btnLoggainAnsvarig = new Button();
            label1 = new Label();
            btnTillbakaFrånMaskinStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaskinAnsvariga).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaskinAnsvariga
            // 
            dataGridViewMaskinAnsvariga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaskinAnsvariga.Location = new Point(63, 80);
            dataGridViewMaskinAnsvariga.Name = "dataGridViewMaskinAnsvariga";
            dataGridViewMaskinAnsvariga.RowTemplate.Height = 25;
            dataGridViewMaskinAnsvariga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaskinAnsvariga.Size = new Size(471, 150);
            dataGridViewMaskinAnsvariga.TabIndex = 0;
            dataGridViewMaskinAnsvariga.CellClick += dataGridViewMaskinAnsvariga_CellClick;
            // 
            // btnLoggainAnsvarig
            // 
            btnLoggainAnsvarig.Location = new Point(63, 251);
            btnLoggainAnsvarig.Name = "btnLoggainAnsvarig";
            btnLoggainAnsvarig.Size = new Size(75, 23);
            btnLoggainAnsvarig.TabIndex = 1;
            btnLoggainAnsvarig.Text = "Logga in";
            btnLoggainAnsvarig.UseVisualStyleBackColor = true;
            btnLoggainAnsvarig.Click += btnLoggainAnsvarig_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(63, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Välj maskinansvarig";
            // 
            // btnTillbakaFrånMaskinStart
            // 
            btnTillbakaFrånMaskinStart.BackColor = SystemColors.ActiveCaptionText;
            btnTillbakaFrånMaskinStart.ForeColor = SystemColors.ControlLightLight;
            btnTillbakaFrånMaskinStart.Location = new Point(63, 373);
            btnTillbakaFrånMaskinStart.Name = "btnTillbakaFrånMaskinStart";
            btnTillbakaFrånMaskinStart.Size = new Size(75, 23);
            btnTillbakaFrånMaskinStart.TabIndex = 3;
            btnTillbakaFrånMaskinStart.Text = "Tillbaka";
            btnTillbakaFrånMaskinStart.UseVisualStyleBackColor = false;
            btnTillbakaFrånMaskinStart.Click += btnTillbakaFrånMaskinStart_Click;
            // 
            // AnsvarigStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTillbakaFrånMaskinStart);
            Controls.Add(label1);
            Controls.Add(btnLoggainAnsvarig);
            Controls.Add(dataGridViewMaskinAnsvariga);
            Name = "AnsvarigStart";
            Text = "AnsvarigStart";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaskinAnsvariga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMaskinAnsvariga;
        private Button btnLoggainAnsvarig;
        private Label label1;
        private Button btnTillbakaFrånMaskinStart;
    }
}