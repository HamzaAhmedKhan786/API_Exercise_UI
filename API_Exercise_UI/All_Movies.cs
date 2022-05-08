using Newtonsoft.Json;
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
    public partial class All_Movies : Form
    {
        private string view_type = string.Empty;
        private List<Movies> movie_data = new List<Movies>();
        private User_Data user = new User_Data();
        
        public All_Movies()
        {
            InitializeComponent();
        }

        public void Set_User(User_Data login_user) 
        { 
            this.user = login_user; 
        }

        public void Set_View_Type(string view)
        {
            this.view_type = view;
        }
        private void Get_All_Movies()
        {
            API movies_api = new API();
            dataGridView1.DataBindings.Clear();
            var res = movies_api.Get_all_movies(user.user_role);
            var data = JsonConvert.DeserializeObject<List<Movies>>(res);
            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;   
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["assignee"].Visible = false;
        }

        private void Get_My_Collection()
        {
            API movies_api = new API();
            dataGridView1.DataBindings.Clear();
            movies_api.Set_User(user);
            var res = movies_api.Get_User_Collection();
            var data = JsonConvert.DeserializeObject<List<Movies>>(res);
            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["assignee"].Visible = false;
        }

        private void All_Movies_Load(object sender, EventArgs e)
        {
            if (view_type.Equals("AllMovies")) 
            {
                Get_All_Movies();
            }else if (view_type.Equals("MyCollection")) 
            {
                Get_My_Collection();
            }else if (view_type.Equals("AllCOllection"))
            {
                Get_All_Collection();
            }
            
        }

        private void Get_All_Collection()
        {
            API movies_api = new API();
            dataGridView1.DataBindings.Clear();
            movies_api.Set_User(user);
            var res = movies_api.Get_All_COllection();
            var data = JsonConvert.DeserializeObject<List<Movies>>(res);
            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_id = string.Empty;
            Get_User_Collection(user_id);
        }

        private void Get_User_Collection(string user_id)
        { 

        }
        
    }
}
