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
            textbox_username = new MaterialSkin.Controls.MaterialTextBox2();
            textbox_password = new MaterialSkin.Controls.MaterialTextBox2();
            button_submit_login = new MaterialSkin.Controls.MaterialButton();
            radio_role_owner = new MaterialSkin.Controls.MaterialRadioButton();
            radio_role_cook = new MaterialSkin.Controls.MaterialRadioButton();
            radio_role_client = new MaterialSkin.Controls.MaterialRadioButton();
            label_username = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            textbox_username.Location = new Point(63, 153);
            textbox_username.Margin = new Padding(5, 3, 5, 3);
            textbox_username.MaxLength = 32767;
            textbox_username.MouseState = MaterialSkin.MouseState.OUT;
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
            textbox_username.TextAlign = HorizontalAlignment.Right;
            textbox_username.TrailingIcon = null;
            textbox_username.UseSystemPasswordChar = false;
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
            textbox_password.Location = new Point(63, 267);
            textbox_password.Margin = new Padding(5, 3, 5, 3);
            textbox_password.MaxLength = 32767;
            textbox_password.MouseState = MaterialSkin.MouseState.OUT;
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
            textbox_password.TabIndex = 1;
            textbox_password.TabStop = false;
            textbox_password.TextAlign = HorizontalAlignment.Right;
            textbox_password.TrailingIcon = null;
            textbox_password.UseSystemPasswordChar = false;
            // 
            // button_submit_login
            // 
            button_submit_login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_submit_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            button_submit_login.Depth = 0;
            button_submit_login.HighEmphasis = true;
            button_submit_login.Icon = null;
            button_submit_login.Location = new Point(63, 581);
            button_submit_login.Margin = new Padding(6, 10, 6, 10);
            button_submit_login.MinimumSize = new Size(250, 48);
            button_submit_login.MouseState = MaterialSkin.MouseState.HOVER;
            button_submit_login.Name = "button_submit_login";
            button_submit_login.NoAccentTextColor = Color.Empty;
            button_submit_login.Size = new Size(250, 48);
            button_submit_login.TabIndex = 2;
            button_submit_login.Text = "כניסה";
            button_submit_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_submit_login.UseAccentColor = false;
            button_submit_login.UseVisualStyleBackColor = true;
            button_submit_login.Click += button_submit_login_Click;
            // 
            // radio_role_owner
            // 
            radio_role_owner.AutoSize = true;
            radio_role_owner.Depth = 0;
            radio_role_owner.Location = new Point(63, 355);
            radio_role_owner.Margin = new Padding(0);
            radio_role_owner.MouseLocation = new Point(-1, -1);
            radio_role_owner.MouseState = MaterialSkin.MouseState.HOVER;
            radio_role_owner.Name = "radio_role_owner";
            radio_role_owner.Ripple = true;
            radio_role_owner.Size = new Size(71, 37);
            radio_role_owner.TabIndex = 3;
            radio_role_owner.TabStop = true;
            radio_role_owner.Text = "הנהלה";
            radio_role_owner.UseVisualStyleBackColor = true;
            // 
            // radio_role_cook
            // 
            radio_role_cook.AutoSize = true;
            radio_role_cook.Depth = 0;
            radio_role_cook.Location = new Point(63, 462);
            radio_role_cook.Margin = new Padding(0);
            radio_role_cook.MouseLocation = new Point(-1, -1);
            radio_role_cook.MouseState = MaterialSkin.MouseState.HOVER;
            radio_role_cook.Name = "radio_role_cook";
            radio_role_cook.Ripple = true;
            radio_role_cook.Size = new Size(66, 37);
            radio_role_cook.TabIndex = 4;
            radio_role_cook.TabStop = true;
            radio_role_cook.Text = "מטבח";
            radio_role_cook.UseVisualStyleBackColor = true;
            // 
            // radio_role_client
            // 
            radio_role_client.AutoSize = true;
            radio_role_client.Depth = 0;
            radio_role_client.Location = new Point(63, 409);
            radio_role_client.Margin = new Padding(0);
            radio_role_client.MouseLocation = new Point(-1, -1);
            radio_role_client.MouseState = MaterialSkin.MouseState.HOVER;
            radio_role_client.Name = "radio_role_client";
            radio_role_client.Ripple = true;
            radio_role_client.Size = new Size(76, 37);
            radio_role_client.TabIndex = 5;
            radio_role_client.TabStop = true;
            radio_role_client.Text = "מלצרות";
            radio_role_client.UseVisualStyleBackColor = true;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Depth = 0;
            label_username.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_username.Location = new Point(63, 123);
            label_username.MouseState = MaterialSkin.MouseState.HOVER;
            label_username.Name = "label_username";
            label_username.Size = new Size(64, 19);
            label_username.TabIndex = 6;
            label_username.Text = "שם משתמש";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(63, 235);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(33, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "ססמא";
            // 
            // UILogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 659);
            Controls.Add(materialLabel1);
            Controls.Add(label_username);
            Controls.Add(radio_role_client);
            Controls.Add(radio_role_cook);
            Controls.Add(radio_role_owner);
            Controls.Add(button_submit_login);
            Controls.Add(textbox_password);
            Controls.Add(textbox_username);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "UILogin";
            Padding = new Padding(5, 107, 5, 3);
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך כניסה";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 textbox_username;
        private MaterialSkin.Controls.MaterialTextBox2 textbox_password;
        private MaterialSkin.Controls.MaterialButton button_submit_login;
        private MaterialSkin.Controls.MaterialRadioButton radio_role_owner;
        private MaterialSkin.Controls.MaterialRadioButton radio_role_cook;
        private MaterialSkin.Controls.MaterialRadioButton radio_role_client;
        private MaterialSkin.Controls.MaterialLabel label_username;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}