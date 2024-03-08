using System.Security.Cryptography;

namespace Innovative_Solutions
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            combobox_modeselection.SelectedIndex = 0;
        }

        private void combobox_modeselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_continue.Visible = false;
            textBox_password.Text = "";
            textBox_passwordconfirm.Text = "";
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
            if(combobox_modeselection.SelectedIndex == 0)
            {
                if (textBox_username.Text != "" && textBox_password.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }
            else
            {
                if (textBox_username.Text != "" && textBox_password.Text != "" && textBox_passwordconfirm.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            label_errormessage.Text = "";
            if (combobox_modeselection.SelectedIndex == 0)
            {
                if (textBox_username.Text != "" && textBox_password.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }
            else
            {
                if (textBox_username.Text != "" && textBox_password.Text != "" && textBox_passwordconfirm.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            switch(combobox_modeselection.SelectedIndex)
            {
                case 0:
                    //LOG IN
                    if(textBox_username.Text != "" && textBox_password.Text != "")
                    {
                        try
                        {
                            string[] userdata = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "userdata.dat"));
                            int id = -1;
                            for(int i = 0; i < 1000; i++)
                            {
                                if (userdata[i].ToLower() == textBox_username.Text.ToLower())
                                {
                                    id = i;
                                    break;
                                }
                                if(id != -1)
                                {
                                    if (Convert.ToString(MD5.Create(userdata[id + 1000] + label_password.Text)) == userdata[id + 2000])
                                    {
                                        label_errormessage.Text = "Login success!";
                                        label_errormessage.ForeColor = Color.Green;
                                        button_continue.Enabled = false;
                                    }
                                    else
                                    {
                                        label_errormessage.Text = "Password incorrect!";
                                    }
                                }
                                if(id == -1)
                                {
                                    label_errormessage.Text = "User not found!";
                                }
                                else
                                {
                                    label_errormessage.Text = "Database error!";
                                }
                            }
                        }
                        catch
                        {
                            label_errormessage.Text = "Database error!";
                        }
                    }
                    else
                    {
                        label_errormessage.Text = "Fill out all fields!";
                    }
                    break;
                case 1:
                    //SIGN UP
                    try
                    {
                        string[] userdata = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "userdata.dat"));
                        int id = -1;
                        for(int i = 0; i < 1000; i++)
                        {
                            if (textBox_username.Text.ToLower() == userdata[i])
                            {
                                id = i;
                                label_errormessage.Text = "User already existing!";
                                break;
                            }
                        }
                        if (id == -1)
                        {
                            for (int i = 0; i < 1000; i++)
                            {
                                if (userdata[i] == "" && id == -1)
                                {
                                    id = i;
                                    break;
                                }
                            }
                            if(textBox_password.Text == textBox_passwordconfirm.Text)
                            {
                                userdata[id] = textBox_username.Text;
                                const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!§$%&/()=?-_.:,;#'+*";
                                string salt = "";
                                var rnd = new Random();
                                for (int i = 0; i < 5; i++)
                                {
                                    salt += ALPHABET[rnd.Next(ALPHABET.Length)];
                                }
                                userdata[id + 1000] = salt;
                                userdata[id + 2000] = Convert.ToString(MD5.Create(salt + textBox_password.Text));
                                try
                                {
                                    File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "userdata.dat"), userdata);
                                    label_errormessage.Text = "Sign Up success!";
                                    label_errormessage.ForeColor = Color.Green;
                                }
                                catch
                                {
                                    label_errormessage.Text = "Database Error!";
                                }

                            }
                            else
                            {
                                label_errormessage.Text = "Passwords do not match!";
                            }
                        }
                    }
                    catch
                    {
                        label_errormessage.Text = "Database error!";
                    }
                    break;
                default:
                    label_errormessage.Text = "Select a mode!";
                    break;
            }
        }

        private void textBox_passwordconfirm_TextChanged(object sender, EventArgs e)
        {
            if (combobox_modeselection.SelectedIndex == 0)
            {
                if (textBox_username.Text != "" && textBox_password.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }
            else
            {
                if (textBox_username.Text != "" && textBox_password.Text != "" && textBox_passwordconfirm.Text != "")
                {
                    button_continue.Visible = true;
                }
                else
                {
                    button_continue.Visible = false;
                }
            }
        }
    }
}
