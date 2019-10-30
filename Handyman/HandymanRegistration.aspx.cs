using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Handyman
{
    public partial class HandymanRegistration : System.Web.UI.Page
    {
        handyman handymanModel = new handyman();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtArea.Text = txtFirstName.Text = txtLastName.Text = txtPhone.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            handymanModel.first_name = txtFirstName.Text;
            handymanModel.work_avaliable_area =Convert.ToDouble(txtArea.Text);
            handymanModel.last_name = txtLastName.Text;
            handymanModel.phone_num = txtPhone.Text;

            using (handymanEntities handymanDB = new handymanEntities())
            {
                handymanDB.handymen.Add(handymanModel);
                handymanDB.SaveChanges();
            }


        }
    }
}