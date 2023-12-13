using Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGUI
{
    public partial class ResenärLån : Form
    {
        private Servicelayer servicelayer;
        private Resenär valdResenär;
        private Tågstation valdTågstation;
        private Bokmaskin valdBokmaskin;
        private Bok valdBok;
        private BokLån lånadBok;
        public ResenärLån(Resenär valdResenär, Servicelayer servicelayer)
        {
            InitializeComponent();
            this.valdResenär = valdResenär;
            this.servicelayer = servicelayer;
            UppdateraAnvändarText();
            RefreshDataGridviewLånadeböcker();
            RefreshDataGridviewTågstationer();
        }
        private void RefreshDataGridviewLånadeböcker()
        {
            dataGridViewLånadeBöcker.DataSource = new BindingList<BokLån>(servicelayer.GetBokLån(valdResenär));

        }
        private void RefreshDataGridviewTågstationer()
        {
            dataGridViewTågstationer.DataSource = new BindingList<Tågstation>(servicelayer.GetTågstationer());

        }

        private void btnRefreshLånadeböcker_Click(object sender, EventArgs e)
        {
            RefreshDataGridviewLånadeböcker();
        }
        private void UppdateraAnvändarText()
        {
            labelLånadeBöcker.Text = $"Lånade böcker för: {valdResenär.förnamn} {valdResenär.efternamn}";
        }


        private void dataGridViewTågstationer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdTågstation = dataGridViewTågstationer.SelectedRows[0].DataBoundItem as Tågstation;
        }

        private void dataGridViewBokmaskiner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBokmaskin = dataGridViewBokmaskiner.SelectedRows[0].DataBoundItem as Bokmaskin;
        }

        private void dataGridViewBöcker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBok = dataGridViewBöcker.SelectedRows[0].DataBoundItem as Bok;
        }

        private void RefreshDataGridviewBokmaskiner()
        {
            dataGridViewBokmaskiner.DataSource = new BindingList<Bokmaskin>(servicelayer.GetBokmaskiner(valdTågstation));
        }

        private void btnValdStation_Click(object sender, EventArgs e)
        {
            if(valdTågstation != null) 
            {
                RefreshDataGridviewBokmaskiner();
            }
            else 
            {
                MessageBox.Show("Vänligen välj en tågstation innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridviewBöcker()
        {
            dataGridViewBöcker.DataSource = new BindingList<Bok>(servicelayer.GetBöckerFrånMaskin(valdBokmaskin));
            RefreshBokSaldo();
        }

        private void btnValdMaskin_Click(object sender, EventArgs e)
        {
            if(valdBokmaskin != null) 
            {
                RefreshDataGridviewBöcker();
            }
            else
            {
                MessageBox.Show("Vänligen välj en maskin innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnValdBok_Click(object sender, EventArgs e)
        {
            if(valdBok != null) 
            {
                servicelayer.LånaBok(valdBok, valdResenär, valdBokmaskin);
                RefreshDataGridviewBöcker();
                RefreshDataGridviewLånadeböcker();
                RefreshBokSaldo();
                valdBok = null;
            }
            else
            {
                MessageBox.Show("Vänligen välj en bok innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RefreshBokSaldo()
        {
            lbLånadeböcker.Text = $"Tillgängliga böcker: {valdBokmaskin.böcker.Count}";
        }

        private void btnLämnaTillbakaBok_Click(object sender, EventArgs e)
        {
            if(lånadBok != null) 
            {
                servicelayer.LämnaTillbakaBok(valdBok, valdResenär, valdBokmaskin, lånadBok);
                RefreshDataGridviewBöcker();
                RefreshDataGridviewLånadeböcker();
                RefreshBokSaldo();
            }
            else 
            {
                MessageBox.Show("Vänligen välj en lånad bok innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewLånadeBöcker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lånadBok = dataGridViewLånadeBöcker.SelectedRows[0].DataBoundItem as BokLån;
            valdBok = lånadBok.bok;
        }

        private void btnLoggautResenär_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
