using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using Models;

namespace WinFormGUI
{
    public partial class AnsvarigStart : Form
    {
        private Servicelayer servicelayer;
        private Maskinansvarig valdAnsvarig;
        public AnsvarigStart(Servicelayer servicelayer)
        {
            InitializeComponent();
            this.servicelayer = servicelayer;
            RefreshDataGridViewMaskinAnsvariga();
        }

        private void RefreshDataGridViewMaskinAnsvariga()
        {
            dataGridViewMaskinAnsvariga.DataSource = new BindingList<Maskinansvarig>(servicelayer.GetMaskinansvariga());
        }

        private void dataGridViewMaskinAnsvariga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdAnsvarig = dataGridViewMaskinAnsvariga.SelectedRows[0].DataBoundItem as Maskinansvarig;

        }

        private void btnLoggainAnsvarig_Click(object sender, EventArgs e)
        {
            if (valdAnsvarig != null)
            {
                AnsvarigHantera ansvarighantera = new AnsvarigHantera(servicelayer, valdAnsvarig);
                ansvarighantera.Show();
            }
            else 
            {
                MessageBox.Show("Vänligen välj en maskinansvarig innan du fortsätter.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTillbakaFrånMaskinStart_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
