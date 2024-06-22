namespace BestFood
{
    partial class UILogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textbox_username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_username = new ReaLTaiizor.Controls.MaterialLabel();
            label_Password = new ReaLTaiizor.Controls.MaterialLabel();
            textbox_password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            button_submit_login = new ReaLTaiizor.Controls.MaterialButton();
            radio_role_admin = new ReaLTaiizor.Controls.MaterialRadioButton();
            radio_role_staff = new ReaLTaiizor.Controls.MaterialRadioButton();
            radio_role_kitchen = new ReaLTaiizor.Controls.MaterialRadioButton();
            SuspendLayout();
            // 
            // textbox_username
            // 
            textbox_username.AnimateReadOnly = false;
            textbox_username.AutoCompleteMode = AutoCompleteMode.None;
            textbox_username.AutoCompleteSource = AutoCompleteSource.None;
            textbox_username.BackgroundImageLayout = ImageLayout.None;
            textbox_username.CharacterCasing = CharacterCasing.Normal;
            textbox_username.Depth = 0;
            textbox_username.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_username.HideSelection = true;
            textbox_username.LeadingIcon = null;
            textbox_username.Location = new Point(48, 126);
            textbox_username.MaxLength = 32767;
            textbox_username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_username.Name = "textbox_username";
            textbox_username.PasswordChar = '\0';
            textbox_username.PrefixSuffixText = null;
            textbox_username.ReadOnly = false;
            textbox_username.RightToLeft = RightToLeft.No;
            textbox_username.SelectedText = "";
            textbox_username.SelectionLength = 0;
            textbox_username.SelectionStart = 0;
            textbox_username.ShortcutsEnabled = true;
            textbox_username.Size = new Size(250, 48);
            textbox_username.TabIndex = 0;
            textbox_username.TabStop = false;
            textbox_username.TextAlign = HorizontalAlignment.Left;
            textbox_username.TrailingIcon = null;
            textbox_username.UseSystemPasswordChar = false;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Depth = 0;
            label_username.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_username.Location = new Point(48, 90);
            label_username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_username.Name = "label_username";
            label_username.Size = new Size(44, 19);
            label_username.TabIndex = 1;
            label_username.Text = "משתמש";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Depth = 0;
            label_Password.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_Password.Location = new Point(48, 199);
            label_Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(33, 19);
            label_Password.TabIndex = 3;
            label_Password.Text = "ססמא";
            // 
            // textbox_password
            // 
            textbox_password.AnimateReadOnly = false;
            textbox_password.AutoCompleteMode = AutoCompleteMode.None;
            textbox_password.AutoCompleteSource = AutoCompleteSource.None;
            textbox_password.BackgroundImageLayout = ImageLayout.None;
            textbox_password.CharacterCasing = CharacterCasing.Normal;
            textbox_password.Depth = 0;
            textbox_password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_password.HideSelection = true;
            textbox_password.LeadingIcon = null;
            textbox_password.Location = new Point(48, 235);
            textbox_password.MaxLength = 32767;
            textbox_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '\0';
            textbox_password.PrefixSuffixText = null;
            textbox_password.ReadOnly = false;
            textbox_password.RightToLeft = RightToLeft.No;
            textbox_password.SelectedText = "";
            textbox_password.SelectionLength = 0;
            textbox_password.SelectionStart = 0;
            textbox_password.ShortcutsEnabled = true;
            textbox_password.Size = new Size(250, 48);
            textbox_password.TabIndex = 2;
            textbox_password.TabStop = false;
            textbox_password.TextAlign = HorizontalAlignment.Left;
            textbox_password.TrailingIcon = null;
            textbox_password.UseSystemPasswordChar = false;
            // 
            // button_submit_login
            // 
            button_submit_login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_submit_login.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_submit_login.Depth = 0;
            button_submit_login.HighEmphasis = true;
            button_submit_login.Icon = null;
            button_submit_login.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            button_submit_login.Location = new Point(48, 379);
            button_submit_login.Margin = new Padding(4, 6, 4, 6);
            button_submit_login.MinimumSize = new Size(250, 48);
            button_submit_login.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            button_submit_login.Name = "button_submit_login";
            button_submit_login.NoAccentTextColor = Color.Empty;
            button_submit_login.Size = new Size(250, 48);
            button_submit_login.TabIndex = 4;
            button_submit_login.Text = "materialButton1";
            button_submit_login.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            button_submit_login.UseAccentColor = false;
            button_submit_login.UseVisualStyleBackColor = true;
            button_submit_login.Click += materialButton1_Click;
            // 
            // radio_role_admin
            // 
            radio_role_admin.AutoSize = true;
            radio_role_admin.Depth = 0;
            radio_role_admin.Location = new Point(144, 318);
            radio_role_admin.Margin = new Padding(0);
            radio_role_admin.MouseLocation = new Point(-1, -1);
            radio_role_admin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radio_role_admin.Name = "radio_role_admin";
            radio_role_admin.Ripple = true;
            radio_role_admin.Size = new Size(71, 37);
            radio_role_admin.TabIndex = 5;
            radio_role_admin.TabStop = true;
            radio_role_admin.Text = "הנהלה";
            radio_role_admin.UseAccentColor = false;
            radio_role_admin.UseVisualStyleBackColor = true;
            // 
            // radio_role_staff
            // 
            radio_role_staff.AutoSize = true;
            radio_role_staff.Depth = 0;
            radio_role_staff.Location = new Point(222, 318);
            radio_role_staff.Margin = new Padding(0);
            radio_role_staff.MouseLocation = new Point(-1, -1);
            radio_role_staff.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radio_role_staff.Name = "radio_role_staff";
            radio_role_staff.Ripple = true;
            radio_role_staff.Size = new Size(76, 37);
            radio_role_staff.TabIndex = 6;
            radio_role_staff.TabStop = true;
            radio_role_staff.Text = "מלצרות";
            radio_role_staff.UseAccentColor = false;
            radio_role_staff.UseVisualStyleBackColor = true;
            // 
            // radio_role_kitchen
            // 
            radio_role_kitchen.AutoSize = true;
            radio_role_kitchen.Depth = 0;
            radio_role_kitchen.Location = new Point(63, 318);
            radio_role_kitchen.Margin = new Padding(0);
            radio_role_kitchen.MouseLocation = new Point(-1, -1);
            radio_role_kitchen.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            radio_role_kitchen.Name = "radio_role_kitchen";
            radio_role_kitchen.Ripple = true;
            radio_role_kitchen.Size = new Size(66, 37);
            radio_role_kitchen.TabIndex = 7;
            radio_role_kitchen.TabStop = true;
            radio_role_kitchen.Text = "מטבח";
            radio_role_kitchen.UseAccentColor = false;
            radio_role_kitchen.UseVisualStyleBackColor = true;
            // 
            // UILogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 503);
            Controls.Add(radio_role_kitchen);
            Controls.Add(radio_role_staff);
            Controls.Add(radio_role_admin);
            Controls.Add(button_submit_login);
            Controls.Add(label_Password);
            Controls.Add(textbox_password);
            Controls.Add(label_username);
            Controls.Add(textbox_username);
            Name = "UILogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך כניסה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_username;
        private ReaLTaiizor.Controls.MaterialLabel label_username;
        private ReaLTaiizor.Controls.MaterialLabel label_Password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_password;
        private ReaLTaiizor.Controls.MaterialButton button_submit_login;
        private ReaLTaiizor.Controls.MaterialRadioButton radio_role_admin;
        private ReaLTaiizor.Controls.MaterialRadioButton radio_role_staff;
        private ReaLTaiizor.Controls.MaterialRadioButton radio_role_kitchen;
    }
}