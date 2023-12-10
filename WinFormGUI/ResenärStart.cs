using Models;
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
using System.Security.AccessControl;

namespace WinFormGUI
{

    public partial class ResenärStart : Form
    {
        private Servicelayer servicelayer;
        private Resenär valdResenär;
        public ResenärStart(Servicelayer servicelayer)
        {
            InitializeComponent();
            this.servicelayer = servicelayer;
            RefreshDataGridviewResenärData();
        }

        private void RefreshDataGridviewResenärData()
        {

            dataGridViewResenär.DataSource = new BindingList<Resenär>(servicelayer.GetResenärer());

        }

        private void btnRefreshResenärData_Click(object sender, EventArgs e)
        {
            RefreshDataGridviewResenärData();
        }

        private void dataGridViewResenär_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valdResenär = dataGridViewResenär.SelectedRows[0].DataBoundItem as Resenär;
        }

        private void btnResenärLoggain_Click(object sender, EventArgs e)
        {
            if (valdResenär != null)
            {
                ResenärLån resenärSession = new ResenärLån(valdResenär, servicelayer);
                resenärSession.Show();
            }

        }

        private void btnTillbakaFrånResenärStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
