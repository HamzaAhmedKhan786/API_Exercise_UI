using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Exercise_UI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_validation = false;
            if (!Is_Text_Box_Empty(this.user_name))
            {
                Remove_Error_Validation(this.user_name);
                is_validation = false;
            }
            else
            {
                Set_Error_Validation(this.user_name);
                is_validation = true;
            }


            if (!Is_Text_Box_Empty(this.password))
            {
                Remove_Error_Validation(this.password);
                is_validation = false;
            }
            else
            {
                Set_Error_Validation(this.password);
                is_validation = true;
            }

            if (!is_validation)
            {
                this.Hide();
                API login_user = new API();
                string response = login_user.Get_User_Login(this.user_name.Text, this.password.Text);
                if (!response.Equals(String.Empty) && !response.Equals("No connection available"))
                {
                    using (Movies_Dashboard m_d = new Movies_Dashboard())
                    {
                        User_Data user = new User_Data();
                        user = login_user.Get_User_Data(this.user_name.Text);
                        m_d.Set_User_Data(user);
                        DialogResult dr = m_d.ShowDialog();
                        if (dr == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    this.Error.Text = response;
                    this.ShowDialog();
                }
            }
        }

        private bool Is_Text_Box_Empty(TextBox text_box_name)
        {
            bool is_empty = false;
            if (text_box_name.Text.Equals(string.Empty))
            {
                is_empty = true;
            }

            return is_empty;
        }

        private void Set_Error_Validation(TextBox text_box_name)
        {
            errorProvider1.SetError(text_box_name, "Required");
        }

        private void Remove_Error_Validation(TextBox textBox)
        {
            errorProvider1.SetError(textBox, string.Empty);
            errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
