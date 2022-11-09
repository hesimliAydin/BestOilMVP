using BestOilMVP.Model;
using BestOilMVP.Views;

namespace BestOilMVP
{
    public partial class Form1 : Form,IMainView
    {
        public Form1()
        {
            InitializeComponent();


        }


       public EventHandler<EventArgs> LiterRadioButtonClicked { get; set; }
       public EventHandler<EventArgs> PriceRadioButtonClicked { get; set; }
       public EventHandler<EventArgs> PriceSelectedIndexChanged { get; set; }

       public string LiterTxtB { get=>literTxtB.Text; set=>literTxtB.Text=value; }
       public string PriceTxtB { get => priceTxtB.Text; set=>priceTxtB.Text=value; }
       public bool isActive { get=>literRadioBtn.Enabled; set=>literRadioBtn.Enabled=value; }

        private void literRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LiterRadioButtonClicked(sender, e);
            
        }

        private void priceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceRadioButtonClicked(sender, e);
        }

        private void literTxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Fuel> FuelType = new List<Fuel>()
            {
                new("AI-92",1),
                new("AI-95",2),
                new("AI-98",2.3),
                new("Diesel",0.8),
                new("LPG",0.65),
                new("CNG",0.45)
            };
            fuelTypeComboB.DisplayMember = nameof(Fuel.Name);
            fuelTypeComboB.Items.AddRange(FuelType.ToArray());
            fuelTypeComboB.SelectedIndex = 0;
        }

        private void fuelTypeComboB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}