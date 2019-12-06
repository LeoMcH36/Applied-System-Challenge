using System;

namespace Applied_Systems_web
{
    public partial class Calculator : System.Web.UI.Page
    {
        Driver drv1 = new Driver();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            drv1.SetName(name);
        }

        public void txtOccupation_TextChanged(object sender, EventArgs e)
        {
            string occupation = txtOccupation.Text;
            drv1.SetOccupation(occupation);
        }

        protected void txtDOB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime DOB = Convert.ToDateTime(txtDOB.Text);
                drv1.SetDOB(DOB);
            }
            catch (FormatException)
            {
                lblPremium.Text = "Invalid Date";

            }
        }

        protected void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime policyStart = Convert.ToDateTime(txtStartDate.Text);
                drv1.SetPolicyStart(policyStart);
            }
            catch (FormatException)
            {
                lblPremium.Text = "Invalid Date";
            }
        }


        protected void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {


                lblPremium.Text = "Your Insurance Premium Will cost £" + drv1.PremiumCalc(txtOccupation.Text, Convert.ToDateTime(txtDOB.Text), Convert.ToDateTime(txtStartDate.Text)).ToString() + ".          Thank You For Using Insurance Premium Calculator";
            }
            
            catch(FormatException)
            {
                lblPremium.Text = "Invalid Date";
            }
            catch (Exception ex)
            {
                lblPremium.Text = ex.Message;
            }
        }


    }
}