namespace WinFormGUI
{
    partial class AnsvarigHantera
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
            lbInloggadSomText = new Label();
            dataGridViewMaskiner = new DataGridView();
            label2 = new Label();
            btnVäljMaskin = new Button();
            dataGridViewBöckerMaskin = new DataGridView();
            lbBokSaldo = new Label();
            lbMaskinTitelGridview = new Label();
            dataGridViewBokLager = new DataGridView();
            label3 = new Label();
            btnLäggTillBok = new Button();
            dataGridViewLånadeBöcker = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaskiner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöckerMaskin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBokLager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLånadeBöcker).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lbInloggadSomText
            // 
            lbInloggadSomText.AutoSize = true;
            lbInloggadSomText.BackColor = SystemColors.Info;
            lbInloggadSomText.Location = new Point(26, 25);
            lbInloggadSomText.Name = "lbInloggadSomText";
            lbInloggadSomText.Size = new Size(86, 15);
            lbInloggadSomText.TabIndex = 1;
            lbInloggadSomText.Text = "Inloggad som: ";
            // 
            // dataGridViewMaskiner
            // 
            dataGridViewMaskiner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaskiner.Location = new Point(26, 90);
            dataGridViewMaskiner.Name = "dataGridViewMaskiner";
            dataGridViewMaskiner.RowTemplate.Height = 25;
            dataGridViewMaskiner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaskiner.Size = new Size(243, 95);
            dataGridViewMaskiner.TabIndex = 2;
            dataGridViewMaskiner.CellClick += dataGridViewMaskiner_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 3;
            label2.Text = "Ansvar över följande maskin(er)";
            // 
            // btnVäljMaskin
            // 
            btnVäljMaskin.Location = new Point(26, 191);
            btnVäljMaskin.Name = "btnVäljMaskin";
            btnVäljMaskin.Size = new Size(94, 32);
            btnVäljMaskin.TabIndex = 4;
            btnVäljMaskin.Text = "Välj maskin";
            btnVäljMaskin.UseVisualStyleBackColor = true;
            btnVäljMaskin.Click += btnVäljMaskin_Click;
            // 
            // dataGridViewBöckerMaskin
            // 
            dataGridViewBöckerMaskin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBöckerMaskin.Location = new Point(348, 90);
            dataGridViewBöckerMaskin.Name = "dataGridViewBöckerMaskin";
            dataGridViewBöckerMaskin.RowTemplate.Height = 25;
            dataGridViewBöckerMaskin.Size = new Size(571, 150);
            dataGridViewBöckerMaskin.TabIndex = 5;
            // 
            // lbBokSaldo
            // 
            lbBokSaldo.AutoSize = true;
            lbBokSaldo.Location = new Point(855, 72);
            lbBokSaldo.Name = "lbBokSaldo";
            lbBokSaldo.Size = new Size(42, 15);
            lbBokSaldo.TabIndex = 6;
            lbBokSaldo.Text = "Saldo: ";
            // 
            // lbMaskinTitelGridview
            // 
            lbMaskinTitelGridview.AutoSize = true;
            lbMaskinTitelGridview.BackColor = SystemColors.ActiveCaption;
            lbMaskinTitelGridview.Location = new Point(348, 72);
            lbMaskinTitelGridview.Name = "lbMaskinTitelGridview";
            lbMaskinTitelGridview.Size = new Size(90, 15);
            lbMaskinTitelGridview.TabIndex = 7;
            lbMaskinTitelGridview.Text = "Böcker i maskin";
            // 
            // dataGridViewBokLager
            // 
            dataGridViewBokLager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBokLager.Location = new Point(348, 327);
            dataGridViewBokLager.Name = "dataGridViewBokLager";
            dataGridViewBokLager.RowTemplate.Height = 25;
            dataGridViewBokLager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBokLager.Size = new Size(571, 150);
            dataGridViewBokLager.TabIndex = 8;
            dataGridViewBokLager.CellClick += dataGridViewBokLager_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(348, 309);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Böcker i lager";
            // 
            // btnLäggTillBok
            // 
            btnLäggTillBok.BackColor = SystemColors.Info;
            btnLäggTillBok.Location = new Point(348, 483);
            btnLäggTillBok.Name = "btnLäggTillBok";
            btnLäggTillBok.Size = new Size(139, 23);
            btnLäggTillBok.TabIndex = 10;
            btnLäggTillBok.Text = "Lägg till bok i maskin";
            btnLäggTillBok.UseVisualStyleBackColor = false;
            btnLäggTillBok.Click += btnLäggTillBok_Click;
            // 
            // dataGridViewLånadeBöcker
            // 
            dataGridViewLånadeBöcker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLånadeBöcker.Location = new Point(26, 327);
            dataGridViewLånadeBöcker.Name = "dataGridViewLånadeBöcker";
            dataGridViewLånadeBöcker.RowTemplate.Height = 25;
            dataGridViewLånadeBöcker.Size = new Size(240, 150);
            dataGridViewLånadeBöcker.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 309);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 12;
            label4.Text = "Lånade böcker från maskin:";
            // 
            // AnsvarigHantera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 602);
            Controls.Add(label4);
            Controls.Add(dataGridViewLånadeBöcker);
            Controls.Add(btnLäggTillBok);
            Controls.Add(label3);
            Controls.Add(dataGridViewBokLager);
            Controls.Add(lbMaskinTitelGridview);
            Controls.Add(lbBokSaldo);
            Controls.Add(dataGridViewBöckerMaskin);
            Controls.Add(btnVäljMaskin);
            Controls.Add(label2);
            Controls.Add(dataGridViewMaskiner);
            Controls.Add(lbInloggadSomText);
            Controls.Add(label1);
            Name = "AnsvarigHantera";
            Text = "AnsvarigHantera";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaskiner).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBöckerMaskin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBokLager).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLånadeBöcker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbInloggadSomText;
        private DataGridView dataGridViewMaskiner;
        private Label label2;
        private Button btnVäljMaskin;
        private DataGridView dataGridViewBöckerMaskin;
        private Label lbBokSaldo;
        private Label lbMaskinTitelGridview;
        private DataGridView dataGridViewBokLager;
        private Label label3;
        private Button btnLäggTillBok;
        private DataGridView dataGridViewLånadeBöcker;
        private Label label4;
    }
}