namespace WinFormGUI
{
    partial class ResenärLån
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
            dataGridViewLånadeBöcker = new DataGridView();
            labelLånadeBöcker = new Label();
            dataGridViewTågstationer = new DataGridView();
            label2 = new Label();
            dataGridViewBöcker = new DataGridView();
            lbLånadeböcker = new Label();
            btnValdBok = new Button();
            dataGridViewBokmaskiner = new DataGridView();
            label4 = new Label();
            btnValdStation = new Button();
            btnValdMaskin = new Button();
            btnLämnaTillbakaBok = new Button();
            btnLoggautResenär = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLånadeBöcker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTågstationer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöcker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBokmaskiner).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            // 
            // dataGridViewLånadeBöcker
            // 
            dataGridViewLånadeBöcker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLånadeBöcker.Location = new Point(12, 40);
            dataGridViewLånadeBöcker.Name = "dataGridViewLånadeBöcker";
            dataGridViewLånadeBöcker.RowTemplate.Height = 25;
            dataGridViewLånadeBöcker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLånadeBöcker.Size = new Size(497, 153);
            dataGridViewLånadeBöcker.TabIndex = 1;
            dataGridViewLånadeBöcker.CellClick += dataGridViewLånadeBöcker_CellClick;
            // 
            // labelLånadeBöcker
            // 
            labelLånadeBöcker.AutoSize = true;
            labelLånadeBöcker.Location = new Point(12, 22);
            labelLånadeBöcker.Name = "labelLånadeBöcker";
            labelLånadeBöcker.Size = new Size(108, 15);
            labelLånadeBöcker.TabIndex = 3;
            labelLånadeBöcker.Text = "Lånade böcker för: ";
            // 
            // dataGridViewTågstationer
            // 
            dataGridViewTågstationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTågstationer.Location = new Point(10, 356);
            dataGridViewTågstationer.Name = "dataGridViewTågstationer";
            dataGridViewTågstationer.RowTemplate.Height = 25;
            dataGridViewTågstationer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTågstationer.Size = new Size(155, 129);
            dataGridViewTågstationer.TabIndex = 5;
            dataGridViewTågstationer.CellClick += dataGridViewTågstationer_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 338);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Välj tågstation";
            // 
            // dataGridViewBöcker
            // 
            dataGridViewBöcker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBöcker.Location = new Point(491, 356);
            dataGridViewBöcker.Name = "dataGridViewBöcker";
            dataGridViewBöcker.RowTemplate.Height = 25;
            dataGridViewBöcker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBöcker.Size = new Size(434, 187);
            dataGridViewBöcker.TabIndex = 9;
            dataGridViewBöcker.CellContentClick += dataGridViewBöcker_CellContentClick;
            // 
            // lbLånadeböcker
            // 
            lbLånadeböcker.AutoSize = true;
            lbLånadeböcker.Location = new Point(491, 338);
            lbLånadeböcker.Name = "lbLånadeböcker";
            lbLånadeböcker.Size = new Size(110, 15);
            lbLånadeböcker.TabIndex = 10;
            lbLånadeböcker.Text = "Tillgängliga böcker:";
            // 
            // btnValdBok
            // 
            btnValdBok.Location = new Point(491, 549);
            btnValdBok.Name = "btnValdBok";
            btnValdBok.Size = new Size(75, 23);
            btnValdBok.TabIndex = 11;
            btnValdBok.Text = "Låna ";
            btnValdBok.UseVisualStyleBackColor = true;
            btnValdBok.Click += btnValdBok_Click;
            // 
            // dataGridViewBokmaskiner
            // 
            dataGridViewBokmaskiner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBokmaskiner.Location = new Point(211, 356);
            dataGridViewBokmaskiner.Name = "dataGridViewBokmaskiner";
            dataGridViewBokmaskiner.RowTemplate.Height = 25;
            dataGridViewBokmaskiner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBokmaskiner.Size = new Size(245, 129);
            dataGridViewBokmaskiner.TabIndex = 12;
            dataGridViewBokmaskiner.CellClick += dataGridViewBokmaskiner_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 338);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 13;
            label4.Text = "Välj bokmaskin";
            // 
            // btnValdStation
            // 
            btnValdStation.Location = new Point(12, 491);
            btnValdStation.Name = "btnValdStation";
            btnValdStation.Size = new Size(75, 23);
            btnValdStation.TabIndex = 14;
            btnValdStation.Text = "Välj station";
            btnValdStation.UseVisualStyleBackColor = true;
            btnValdStation.Click += btnValdStation_Click;
            // 
            // btnValdMaskin
            // 
            btnValdMaskin.Location = new Point(211, 491);
            btnValdMaskin.Name = "btnValdMaskin";
            btnValdMaskin.Size = new Size(75, 23);
            btnValdMaskin.TabIndex = 15;
            btnValdMaskin.Text = "Välj maskin";
            btnValdMaskin.UseVisualStyleBackColor = true;
            btnValdMaskin.Click += btnValdMaskin_Click;
            // 
            // btnLämnaTillbakaBok
            // 
            btnLämnaTillbakaBok.BackColor = SystemColors.Info;
            btnLämnaTillbakaBok.Location = new Point(13, 201);
            btnLämnaTillbakaBok.Name = "btnLämnaTillbakaBok";
            btnLämnaTillbakaBok.Size = new Size(152, 35);
            btnLämnaTillbakaBok.TabIndex = 16;
            btnLämnaTillbakaBok.Text = "Lämna tillbaka bok";
            btnLämnaTillbakaBok.UseVisualStyleBackColor = false;
            btnLämnaTillbakaBok.Click += btnLämnaTillbakaBok_Click;
            // 
            // btnLoggautResenär
            // 
            btnLoggautResenär.BackColor = SystemColors.ControlText;
            btnLoggautResenär.ForeColor = SystemColors.ControlLightLight;
            btnLoggautResenär.Location = new Point(850, 40);
            btnLoggautResenär.Name = "btnLoggautResenär";
            btnLoggautResenär.Size = new Size(75, 23);
            btnLoggautResenär.TabIndex = 17;
            btnLoggautResenär.Text = "Logga ut";
            btnLoggautResenär.UseVisualStyleBackColor = false;
            btnLoggautResenär.Click += btnLoggautResenär_Click;
            // 
            // ResenärLån
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 603);
            Controls.Add(btnLoggautResenär);
            Controls.Add(btnLämnaTillbakaBok);
            Controls.Add(btnValdMaskin);
            Controls.Add(btnValdStation);
            Controls.Add(label4);
            Controls.Add(dataGridViewBokmaskiner);
            Controls.Add(btnValdBok);
            Controls.Add(lbLånadeböcker);
            Controls.Add(dataGridViewBöcker);
            Controls.Add(label2);
            Controls.Add(dataGridViewTågstationer);
            Controls.Add(labelLånadeBöcker);
            Controls.Add(dataGridViewLånadeBöcker);
            Controls.Add(label1);
            Name = "ResenärLån";
            Text = "ResenärLån";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLånadeBöcker).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTågstationer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöcker).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBokmaskiner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewLånadeBöcker;
        private Label labelLånadeBöcker;
        private DataGridView dataGridViewTågstationer;
        private Label label2;
        private DataGridView dataGridViewBöcker;
        private Label lbLånadeböcker;
        private Button btnValdBok;
        private DataGridView dataGridViewBokmaskiner;
        private Label label4;
        private Button btnValdStation;
        private Button btnValdMaskin;
        private Button btnLämnaTillbakaBok;
        private Button btnLoggautResenär;
    }
}