using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment3
{
    public partial class MainForm : Form
    {
        private FuelCalculater carMilage = new FuelCalculater();
        private String name = String.Empty;
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            txtCurRead.Text = "";
            txtprevRead.Text = "";
            txtfuelAmount.Text = "";
            txtpricePerLiter.Text = "";
            lblcostPerKm.Text = "";
            lblkmPerLiter.Text = "";
            lbllitPerKm.Text = "";
            lbllitPerMetMile.Text = "";
            lbllitPerSweMil.Text = "";

        }

        private void btnCalculateFuel_Click(object sender, EventArgs e)
        {
            ReadInput();

            if (carMilage.ValidateOdometerValues())
            {
                UpdatesGUIFuel();
            }
            else
            {
                MessageBox.Show("Current reading must be bigger than prev reading ");
            }
          
           
           
        }

        private void ReadInput()
        {
            
            carMilage.PrevReading = double.Parse(txtprevRead.Text);
            carMilage.UnitPrice = double.Parse(txtpricePerLiter.Text);
            carMilage.FuelAmount = double.Parse(txtfuelAmount.Text);


            


        }

        private void ClearLabels(Control ctrCollection)
        {

        }
        private void ClearTextBoxes(Control ctrCollection)
        {

        }

        private void UpdatesGUIFuel()
        {

            lblkmPerLiter.Text = carMilage.CalcConsumptionKilometerPerLiter().ToString();
            lbllitPerKm.Text = carMilage.CalcFuelConsumptionPerKM().ToString();
            lbllitPerMetMile.Text = carMilage.CalcConsumptionKilometerPerMetricMile().ToString();
            lbllitPerSweMil.Text = carMilage.CalcFuelConsumptionPerSweMil().ToString();
            lblcostPerKm.Text = carMilage.CalcCostPerKm().ToString();
        }

        private void txtCurRead_Validating(object sender, CancelEventArgs e)
        {
            double a = 0;
            if(double.TryParse(txtCurRead.Text, out  a))
            {
                carMilage.CurrReading = a;
            }
            else
            {
                MessageBox.Show("enter a value");
            }
        }

        private void txtprevRead_Validated(object sender, EventArgs e)
        {
            double a = 0;
            if(double.TryParse(txtprevRead.Text, out a))
            {
                carMilage.PrevReading = a;
                txtprevRead.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("enter a real value");
                txtprevRead.BackColor = Color.Red;
            }
        }
    }
    }
