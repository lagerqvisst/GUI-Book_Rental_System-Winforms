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
    public partial class StartMeny : Form
    {
        private Servicelayer servicelayer; 
        public StartMeny()
        {
            InitializeComponent();
            servicelayer = new Servicelayer();
            servicelayer.Seed(); 
        }

        private void btnResenärLogin_Click(object sender, EventArgs e)
        {
            ResenärStart resenärstart = new ResenärStart(servicelayer);
            resenärstart.Show();
        }


        private void btnMaskinAnsvarLogin_Click(object sender, EventArgs e)
        {
            AnsvarigStart ansvarigstart = new AnsvarigStart(servicelayer);
            ansvarigstart.Show();
        }
    }
}
