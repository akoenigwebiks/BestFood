using MaterialSkin.Controls;

namespace BestFood
{
    public partial class UILogin : MaterialForm
    {
        
        public UILogin()
        {
            InitializeComponent();
            radio_role_client.Checked = true;
        }

        private string GetSelectedRole()
        {
            string role = "";

            if (radio_role_owner.Checked)
            {
                role = "owner";
            }
            else if (radio_role_cook.Checked)
            {
                role = "cook";
            }
            else if (radio_role_client.Checked)
            {
                role = "client";
            }

            return role;
         
        }

        private void button_submit_login_Click(object sender, EventArgs e)
        {
            string role = GetSelectedRole();
            string username = textbox_username.Text;
            string password = textbox_password.Text;

            MessageBox.Show("Role: " + role + "\nUsername: " + username + "\nPassword: " + password);
        }
    }
}
