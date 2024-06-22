using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFood
{
    public partial class UILogin : MaterialForm
    {
        enum Role
        {
            Admin,
            Waiter,
            Kitchen
        }
        public UILogin()
        {
            InitializeComponent();
            radio_role_staff.Checked = true;
        }

        private string GetRole()
        {
            if (radio_role_admin.Checked)
            {
                return Role.Admin.ToString();
            }
            else if (radio_role_staff.Checked)
            {
                return Role.Waiter.ToString();
            }
            else
            {
                return Role.Kitchen.ToString();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string role = GetRole();
            string username = textbox_username.Text;
            string password = textbox_password.Text;

            MessageBox.Show("Role: " + role + "\nUsername: " + username + "\nPassword: " + password);
        }
    }
}
