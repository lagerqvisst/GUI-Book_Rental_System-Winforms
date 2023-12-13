using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using ServiceLayer;

namespace WinFormGUI
{
    public partial class AnsvarigHantera : Form
    {
        private Servicelayer servicelayer;
        private Maskinansvarig maskinansvarig;
        private Bokmaskin valdBokmaskin;
        private Bok valdBok;
        public AnsvarigHantera(Servicelayer servicelayer, Maskinansvarig maskinansvarig)
        {
            InitializeComponent();
            this.servicelayer = servicelayer;
            this.maskinansvarig = maskinansvarig;
            RefreshDataGridViewMaskiner();
            RefreshDataGridViewBöckerFrånLager();
            UpdateAnsvarigLabel();
        }

        private void RefreshDataGridViewMaskiner()
        {
            dataGridViewMaskiner.DataSource = new BindingList<Bokmaskin>(servicelayer.GetMaskinerSomAnsvarigHar(maskinansvarig));
        }
        private void RefreshDataGridViewBöckerMaskin()
        {
            dataGridViewBöckerMaskin.DataSource = new BindingList<Bok>(servicelayer.GetBöckerFrånMaskin(valdBokmaskin));
        }
        private void RefreshDataGridViewBöckerFrånLager()
        {
            dataGridViewBokLager.DataSource = new BindingList<Bok>(servicelayer.GetBöckerFrånDatabas());
        }
        private void UpdateAnsvarigLabel()
        {
            lbInloggadSomText.Text = $"Inloggad som: {maskinansvarig.förnamn} {maskinansvarig.efternamn}.";
        }

        private void dataGridViewMaskiner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBokmaskin = dataGridViewMaskiner.SelectedRows[0].DataBoundItem as Bokmaskin;

        }

        private void btnVäljMaskin_Click(object sender, EventArgs e)
        {
            if (valdBokmaskin != null) 
            {
                RefreshDataGridViewBöckerMaskin();
                UpdateBokSaldo();
                UppdateraAntalLånadeBöcker();
                RefreshLånadeBöcker();
            }
            else 
            {
                MessageBox.Show("Vänligen välj en maskin innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void UpdateBokSaldo()
        {
            lbBokSaldo.Text = $"Saldo: {valdBokmaskin.böcker.Count}";
        }

        private void dataGridViewBokLager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdBok = dataGridViewBokLager.SelectedRows[0].DataBoundItem as Bok;
        }

        private void btnLäggTillBok_Click(object sender, EventArgs e)
        {
            if(valdBok != null) 
            {
                servicelayer.LäggTillBokIMaskinFrånLager(valdBok, valdBokmaskin);
                RefreshDataGridViewBöckerMaskin();
                UpdateBokSaldo();
            }

            else 
            {
                MessageBox.Show("Vänligen välj en bok innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void RefreshLånadeBöcker()
        {
            dataGridViewLånadeBöcker.DataSource = new BindingList<BokLån>(servicelayer.GetLånadeBöckerFrånMaskin(valdBokmaskin));
        }

        private void UppdateraAntalLånadeBöcker()
        {
            lbLånadeBöckerFrånMaskin.Text = $"Lånade böcker från maskin: {valdBokmaskin.lånadeBöckerFrånMaskin.Count}";
        }
        private void btnLoggautMaskin_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
