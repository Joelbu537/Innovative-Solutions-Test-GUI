namespace Innovative_Solutions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            combobox_modeselection = new ComboBox();
            picture_ISlogo = new PictureBox();
            label_title = new Label();
            label_modeselection = new Label();
            labee_username = new Label();
            textBox_username = new TextBox();
            label_password = new Label();
            textBox_password = new TextBox();
            label_password_confirm = new Label();
            textBox_passwordconfirm = new TextBox();
            button_continue = new Button();
            label_errormessage = new Label();
            ((System.ComponentModel.ISupportInitialize)picture_ISlogo).BeginInit();
            SuspendLayout();
            // 
            // combobox_modeselection
            // 
            combobox_modeselection.AutoCompleteCustomSource.AddRange(new string[] { "Log In", "SIgn Up" });
            combobox_modeselection.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_modeselection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_modeselection.FormattingEnabled = true;
            combobox_modeselection.Items.AddRange(new object[] { "Log In", "Sign Up" });
            combobox_modeselection.Location = new Point(560, 150);
            combobox_modeselection.Name = "combobox_modeselection";
            combobox_modeselection.Size = new Size(200, 40);
            combobox_modeselection.TabIndex = 0;
            combobox_modeselection.SelectedIndexChanged += combobox_modeselection_SelectedIndexChanged;
            // 
            // picture_ISlogo
            // 
            picture_ISlogo.Image = Properties.Resources.logo_small;
            picture_ISlogo.Location = new Point(12, 12);
            picture_ISlogo.Name = "picture_ISlogo";
            picture_ISlogo.Size = new Size(359, 463);
            picture_ISlogo.TabIndex = 1;
            picture_ISlogo.TabStop = false;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label_title.Location = new Point(428, 12);
            label_title.Name = "label_title";
            label_title.Size = new Size(315, 135);
            label_title.TabIndex = 2;
            label_title.Text = "Innovative Solutions\r\nClient Connection\r\n\r\n";
            label_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_modeselection
            // 
            label_modeselection.AutoSize = true;
            label_modeselection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_modeselection.Location = new Point(425, 150);
            label_modeselection.Name = "label_modeselection";
            label_modeselection.Size = new Size(77, 32);
            label_modeselection.TabIndex = 3;
            label_modeselection.Text = "Mode";
            // 
            // labee_username
            // 
            labee_username.AutoSize = true;
            labee_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labee_username.Location = new Point(425, 235);
            labee_username.Name = "labee_username";
            labee_username.Size = new Size(121, 32);
            labee_username.TabIndex = 4;
            labee_username.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(560, 235);
            textBox_username.MaxLength = 25;
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Your Username";
            textBox_username.Size = new Size(200, 39);
            textBox_username.TabIndex = 5;
            textBox_username.TextChanged += textBox_username_TextChanged;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.Location = new Point(425, 320);
            label_password.Name = "label_password";
            label_password.Size = new Size(111, 32);
            label_password.TabIndex = 6;
            label_password.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(560, 320);
            textBox_password.MaxLength = 40;
            textBox_password.Name = "textBox_password";
            textBox_password.PlaceholderText = "Your Password";
            textBox_password.Size = new Size(200, 39);
            textBox_password.TabIndex = 7;
            textBox_password.UseSystemPasswordChar = true;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // label_password_confirm
            // 
            label_password_confirm.AutoSize = true;
            label_password_confirm.Font = new Font("Segoe UI", 12F);
            label_password_confirm.Location = new Point(425, 405);
            label_password_confirm.Name = "label_password_confirm";
            label_password_confirm.Size = new Size(100, 32);
            label_password_confirm.TabIndex = 8;
            label_password_confirm.Text = "Confirm";
            label_password_confirm.Visible = false;
            // 
            // textBox_passwordconfirm
            // 
            textBox_passwordconfirm.Font = new Font("Segoe UI", 12F);
            textBox_passwordconfirm.Location = new Point(560, 405);
            textBox_passwordconfirm.Name = "textBox_passwordconfirm";
            textBox_passwordconfirm.PlaceholderText = "Confirm Password";
            textBox_passwordconfirm.Size = new Size(200, 39);
            textBox_passwordconfirm.TabIndex = 9;
            textBox_passwordconfirm.UseSystemPasswordChar = true;
            textBox_passwordconfirm.Visible = false;
            textBox_passwordconfirm.TextChanged += textBox_passwordconfirm_TextChanged;
            // 
            // button_continue
            // 
            button_continue.Location = new Point(685, 455);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(112, 34);
            button_continue.TabIndex = 10;
            button_continue.Text = "Select mode";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Visible = false;
            button_continue.Click += button_continue_Click;
            // 
            // label_errormessage
            // 
            label_errormessage.AutoSize = true;
            label_errormessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_errormessage.ForeColor = Color.Red;
            label_errormessage.Location = new Point(400, 460);
            label_errormessage.Name = "label_errormessage";
            label_errormessage.Size = new Size(0, 25);
            label_errormessage.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(label_errormessage);
            Controls.Add(button_continue);
            Controls.Add(textBox_passwordconfirm);
            Controls.Add(label_password_confirm);
            Controls.Add(textBox_password);
            Controls.Add(label_password);
            Controls.Add(textBox_username);
            Controls.Add(labee_username);
            Controls.Add(label_modeselection);
            Controls.Add(label_title);
            Controls.Add(picture_ISlogo);
            Controls.Add(combobox_modeselection);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picture_ISlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combobox_modeselection;
        private PictureBox picture_ISlogo;
        private Label label_title;
        private Label label_modeselection;
        private Label labee_username;
        private TextBox textBox_username;
        private Label label_password;
        private TextBox textBox_password;
        private Label label_password_confirm;
        private TextBox textBox_passwordconfirm;
        private Button button_continue;
        private Label label_errormessage;
    }
}
