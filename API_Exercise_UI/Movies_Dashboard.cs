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
    public partial class Movies_Dashboard : Form
    {
        private string token;
        private Login_User login_user = new Login_User();
        private User_Data user_data = new User_Data();
        public Movies_Dashboard()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void see_all_movies_Click(object sender, EventArgs e)
        {
            All_Movies all_Movies = new All_Movies();
            all_Movies.Set_User(user_data);
            all_Movies.Set_View_Type("AllMovies");
            all_Movies.ShowDialog();
        }

        private void my_collection_Click(object sender, EventArgs e)
        {
            All_Movies all_Movies = new All_Movies();
            all_Movies.Set_User(user_data);
            all_Movies.Set_View_Type("MyCollection");
            all_Movies.ShowDialog();
        }
        internal void Set_User_Data(User_Data user)
        {
            this.user_data = user;
            this.user_name.Text = user_data.user_name;
            this.email_address.Text = user_data.email_address;
            this.user_phone_number.Text = user_data.user_phone_number;
            this.user_address.Text = user_data.address;

        }

        private void all_collection_Click(object sender, EventArgs e)
        {
            All_Movies all_Movies = new All_Movies();
            all_Movies.Set_User(user_data);
            all_Movies.Set_View_Type("AllCOllection");
            all_Movies.ShowDialog();
        }
    }
}
