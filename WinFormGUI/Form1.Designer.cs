using ServiceLayer;

namespace WinFormGUI
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
            tågstationList = new ListBox();
            label1 = new Label();
            tågstationRubrik = new Label();
            bokmaskinerList = new ListBox();
            label2 = new Label();
            boksaldoLabel = new Label();
            SuspendLayout();
            // 
            // tågstationList
            // 
            tågstationList.FormattingEnabled = true;
            tågstationList.ItemHeight = 15;
            tågstationList.Location = new Point(28, 56);
            tågstationList.Name = "tågstationList";
            tågstationList.Size = new Size(120, 94);
            tågstationList.TabIndex = 2;
            tågstationList.SelectedIndexChanged += tågstationList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // tågstationRubrik
            // 
            tågstationRubrik.AutoSize = true;
            tågstationRubrik.Location = new Point(29, 38);
            tågstationRubrik.Name = "tågstationRubrik";
            tågstationRubrik.Size = new Size(71, 15);
            tågstationRubrik.TabIndex = 3;
            tågstationRubrik.Text = "Tågstationer";
            // 
            // bokmaskinerList
            // 
            bokmaskinerList.FormattingEnabled = true;
            bokmaskinerList.ItemHeight = 15;
            bokmaskinerList.Location = new Point(208, 56);
            bokmaskinerList.Name = "bokmaskinerList";
            bokmaskinerList.Size = new Size(120, 49);
            bokmaskinerList.TabIndex = 4;
            bokmaskinerList.SelectedIndexChanged += bokmaskinerList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Bokmaskiner (ID)";
            // 
            // boksaldoLabel
            // 
            boksaldoLabel.AutoSize = true;
            boksaldoLabel.Location = new Point(367, 56);
            boksaldoLabel.Name = "boksaldoLabel";
            boksaldoLabel.Size = new Size(61, 15);
            boksaldoLabel.TabIndex = 8;
            boksaldoLabel.Text = "Boksaldo: ";
            // 
            // Form1
            // 
            ClientSize = new Size(585, 369);
            Controls.Add(boksaldoLabel);
            Controls.Add(label2);
            Controls.Add(bokmaskinerList);
            Controls.Add(tågstationRubrik);
            Controls.Add(label1);
            Controls.Add(tågstationList);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tågstationList;
        private Label label1;
        private Label tågstationRubrik;
        private ListBox bokmaskinerList;
        private Label label2;
        private Label boksaldoLabel;
    }
}
