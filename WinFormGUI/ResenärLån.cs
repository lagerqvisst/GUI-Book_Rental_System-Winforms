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

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridviewTågstationer();
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
            RefreshDataGridviewBokmaskiner();
        }
        private void RefreshDataGridviewBöcker()
        {
            dataGridViewBöcker.DataSource = new BindingList<Bok>(servicelayer.GetBöckerFrånMaskin(valdBokmaskin));
            RefreshBokSaldo();
        }

        private void btnValdMaskin_Click(object sender, EventArgs e)
        {
            RefreshDataGridviewBöcker();
        }

        private void btnValdBok_Click(object sender, EventArgs e)
        {
            servicelayer.LånaBok(valdBok, valdResenär, valdBokmaskin);
            RefreshDataGridviewBöcker();
            RefreshDataGridviewLånadeböcker();
            RefreshBokSaldo();
            valdBok = null;
        }
        private void RefreshBokSaldo()
        {
            lbLånadeböcker.Text = $"Tillgängliga böcker: {valdBokmaskin.böcker.Count}";
        }

        private void btnLämnaTillbakaBok_Click(object sender, EventArgs e)
        {
            servicelayer.LämnaTillbakaBok(valdBok, valdResenär, valdBokmaskin, lånadBok);
            RefreshDataGridviewBöcker();
            RefreshDataGridviewLånadeböcker();
            RefreshBokSaldo();
        }

        private void dataGridViewLånadeBöcker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lånadBok = dataGridViewLånadeBöcker.SelectedRows[0].DataBoundItem as BokLån;
            valdBok = lånadBok.bok;
        }
    }
}
