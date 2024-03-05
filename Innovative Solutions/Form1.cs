namespace Innovative_Solutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combobox_modeselection.SelectedIndex = 0;
        }

        private void combobox_modeselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_errormessage.Text = "";
            button_continue.Text = combobox_modeselection.SelectedItem.ToString();
            if (combobox_modeselection.SelectedIndex == 1)
            {
                label_password_confirm.Visible = true;
                textBox_passwordconfirm.Visible = true;
            }
            else
            {
                label_password_confirm.Visible = false;
                textBox_passwordconfirm.Visible = false;
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            label_errormessage.Text = "";
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                button_continue.Visible = true;
            }
            else
            {
                button_continue.Visible = false;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            label_errormessage.Text = "";
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                button_continue.Visible = true;
            }
            else
            {
                button_continue.Visible = false;
            }
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            switch(combobox_modeselection.SelectedIndex)
            {
                case 0:
                    //LOG IN
                    //TEST
                    label_errormessage.Text = "Password Invalid!";
                    //TEST
                    break;
                case 1:
                    //SIGN UP
                    //TEST
                    label_errormessage.Text = "Password Invalid!";
                    //TEST
                    break;
                default:
                    label_errormessage.Text = "Select a mode!";
                    break;
            }
        }

        private void textBox_passwordconfirm_TextChanged(object sender, EventArgs e)
        {
            label_errormessage.Text = "";
        }
    }
}
