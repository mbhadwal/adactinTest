using System;
using System.Windows.Forms;

namespace CalculatePremiumApp
{
    public partial class Form1 : Form, IPremiumView
    {
        IController controller;
        bool IsFormLoadCompleted = false;
        public Form1()
        {
            InitializeComponent();
        }

        public string PremiumAmount
        {
            get
            {
                return lblPremiumValue.Text;
            }
            set
            {
                lblPremiumValue.Text = value;
            }
        }

        public void AddListner(IController controller)
        {
            this.controller = controller;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpBirthdate.Value.Year - (DateTime.Now.DayOfYear < dtpBirthdate.Value.DayOfYear ? 1 : 0);
            lblAgeValue.Text = age.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsFormLoadCompleted = false;
            cboOccupation.DataSource = new OccupationItem[]
            {
                new OccupationItem{ Rating = "WhiteCollar", Text = "Author"},
                new OccupationItem{ Rating = "LightManual", Text = "Cleaner"},
                new OccupationItem{ Rating = "Professional", Text = "Doctor"},
                new OccupationItem{ Rating = "HeavyManual", Text = "Farmer"},
                new OccupationItem{ Rating = "LightManual", Text = "Florist"},
                new OccupationItem{ Rating = "HeavyManual", Text = "Mechanic"}
            };
            IsFormLoadCompleted = true;
        }

        private void btnCalcPremium_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter your name.", "Error Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (lblAgeValue.Text.Equals("0") || Int32.Parse(lblAgeValue.Text.ToString()) < 0)
            {
                MessageBox.Show("Please check the age field. It cannot be 0 or less.", "Error Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpBirthdate.Focus();
            }
            else if (txtSumInsured.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please enter current input for Sum assured.", "Error Sum Insured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSumInsured.Focus();
            }
            else
            {
                float sumInsured = float.Parse(txtSumInsured.Text.ToString());
                int age = Int32.Parse(lblAgeValue.Text.ToString());
                float occupationRate = GetOccupationRate();
                controller.onClick_ViewPremium(sumInsured, age, occupationRate);
            }
        }

        private float GetOccupationRate()
        {
            OccupationItem item = (OccupationItem)cboOccupation.SelectedItem;
            switch (item.Rating)
            {
                case "Professional":
                    return 1.0F;
                case "WhiteCollar":
                    return 1.25F;
                case "LightManual":
                    return 1.5F;
                case "HeavyManual":
                    return 1.75F;
            }
            return 0F;
        }

        private void cboOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsFormLoadCompleted)
                btnCalcPremium_Click(null, null);
        }

        private void txtSumInsured_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Close dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    /// <summary>
    /// Occupation Item
    /// </summary>
    class OccupationItem
    {
        public string Rating { get; set; }
        public string Text { get; set; }
    }


    /// <summary>
    /// View Interface
    /// </summary>
    interface IPremiumView
    {
        void AddListner(IController controller);
        string PremiumAmount { get; set; }
    }

    /// <summary>
    /// Controller Interface
    /// </summary>
    public interface IController
    {
        void onClick_ViewPremium(float sumInsured, int age, float occupationRate);
    }

    /// <summary>
    /// Premium Model
    /// </summary>
    interface IPremiumModel
    {
        float CalculatePremium(float sumInsured, int age, float occupationRate);
    }

    class PremiumModel : IPremiumModel
    {
        public float CalculatePremium(float sumInsured, int age, float occupationRate)
        {
            return (sumInsured * occupationRate * age) / 1000 * 12;
        }
    }

    /// <summary>
    /// Controller class
    /// </summary>
    class PremiumController : IController
    {
        IPremiumView view;
        IPremiumModel model;
        public PremiumController(IPremiumModel model, IPremiumView view)
        {
            this.model = model;
            this.view = view;
            this.view.AddListner(this);
        }
        public void onClick_ViewPremium(float sumInsured, int age, float occupationRate)
        {
            view.PremiumAmount = model.CalculatePremium(sumInsured, age, occupationRate).ToString();
        }
    }
}
