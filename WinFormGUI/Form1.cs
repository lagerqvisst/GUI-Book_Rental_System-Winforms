using Models;
using ServiceLayer;

namespace WinFormGUI
{
    public partial class Form1 : Form
    {
        Servicelayer servicelayer = new Servicelayer();
        public Form1()
        {
            InitializeComponent();
            servicelayer.Seed();
            FyllTågstation();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FyllTågstation()
        {
            foreach (var station in servicelayer.database.tågstationer)
            {
                tågstationList.Items.Add(station.stad);
            }
        }

        private void tågstationList_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            Tågstation station = servicelayer.GetTågstation(tågstationList.SelectedItem as string); 
           
            bokmaskinerList.Items.Clear();
    
            foreach (Bokmaskin bokmaskin in station.Bokmaskiner)
            {
                        
                bokmaskinerList.Items.Add(bokmaskin.maskinID);
            }
                 
        }

        private void bokmaskinerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maskinID = bokmaskinerList.SelectedIndex;

            Bokmaskin maskin = servicelayer.GetBokmaskin(maskinID);

            boksaldoLabel.Text = $"Antal böcker: {servicelayer.VisaBokSaldo(maskin)}";
            
        }
    }
}
