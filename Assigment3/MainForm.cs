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
            carMilage.CurrReading = double.Parse(txtCurRead.Text);
            carMilage.PrevReading= double.Parse(txtprevRead.Text);
            carMilage.FuelAmount = double.Parse(txtfuelAmount.Text);
            carMilage.UnitPrice = double.Parse(txtpricePerLiter.Text);
            UpdatesGUIFuel();
          //  ReadInputFuel();
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
        }

        private bool ReadInputFuel()
        {
            double value= 0;
            if (double.TryParse(txtCurRead.Text, out value))
            {
                carMilage.CurrReading(value);
            }else
            return true;

        }
    }
}
