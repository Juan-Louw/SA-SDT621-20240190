namespace SectionC_ScenarioBasedPractical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text);
            string mobileMake = txtMake.Text;
            int quantity = int.Parse(txtQuantity.Text);

            string MobileData = 
                $"Code: {code} \n" +
                $" Make: {mobileMake} \n" +
                $" Quantity: {quantity}";

            lbMobilePhones.Items.Add(MobileData);

            lblOutput.Text = "Record Added!";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Function to delete the list in lbMobilePhones that has the same code as the one in txtCode
            int code = int.Parse(txtCode.Text);
            string mobileMake = txtMake.Text;
            int quantity = int.Parse(txtQuantity.Text);

            string MobileData = 
                $"Code: {code} \n" +
                $" Make: {mobileMake} \n" +
                $" Quantity: {quantity}";

            if (lbMobilePhones.Items.Contains(MobileData))
            {
                lblOutput.Text = "Record Deleted!";
                lbMobilePhones.Items.Remove(MobileData);    
            }
            else
            {
                lblOutput.Text = "Record Not Found!";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text);
            string mobileMake = txtMake.Text;
            int quantity = int.Parse(txtQuantity.Text);

            string MobileData = 
                $"Code: {code} \n" +
                $" Make: {mobileMake} \n" +
                $" Quantity: {quantity}";

            if (lbMobilePhones.Items.Contains(MobileData))
            {
                lblOutput.Text = "Record Found!";
            }
            else
            {
                lblOutput.Text = "Record Not Found!";
            }
        }
    }
}
