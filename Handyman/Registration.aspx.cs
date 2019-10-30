using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Handyman
{
    public partial class Registration : System.Web.UI.Page
    {
        user userModel = new user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text=txtPassword.Text = txtUserName.Text = txtUserType.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            userModel.user_name = txtUserName.Text;
            userModel.user_type = Convert.ToInt32(txtUserType.Text);
            userModel.password = txtPassword.Text;
            userModel.email = txtEmail.Text;
            using (handymanEntities handymanDB = new handymanEntities())
            {
                handymanDB.users.Add(userModel);
                handymanDB.SaveChanges();
            }
        }
    }
}