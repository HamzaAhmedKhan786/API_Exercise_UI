namespace API_Exercise_UI
{
    partial class Movies_Dashboard
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
            this.see_all_movies = new System.Windows.Forms.Button();
            this.my_collection = new System.Windows.Forms.Button();
            this.all_collection = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_address = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            this.user_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_phone_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // see_all_movies
            // 
            this.see_all_movies.Location = new System.Drawing.Point(31, 194);
            this.see_all_movies.Name = "see_all_movies";
            this.see_all_movies.Size = new System.Drawing.Size(223, 61);
            this.see_all_movies.TabIndex = 0;
            this.see_all_movies.Text = "See all movies";
            this.see_all_movies.UseVisualStyleBackColor = true;
            this.see_all_movies.Click += new System.EventHandler(this.see_all_movies_Click);
            // 
            // my_collection
            // 
            this.my_collection.Location = new System.Drawing.Point(269, 194);
            this.my_collection.Name = "my_collection";
            this.my_collection.Size = new System.Drawing.Size(223, 61);
            this.my_collection.TabIndex = 1;
            this.my_collection.Text = "See my Collection";
            this.my_collection.UseVisualStyleBackColor = true;
            this.my_collection.Click += new System.EventHandler(this.my_collection_Click);
            // 
            // all_collection
            // 
            this.all_collection.Location = new System.Drawing.Point(498, 194);
            this.all_collection.Name = "all_collection";
            this.all_collection.Size = new System.Drawing.Size(223, 61);
            this.all_collection.TabIndex = 2;
            this.all_collection.Text = "See All Collections";
            this.all_collection.UseVisualStyleBackColor = true;
            this.all_collection.Click += new System.EventHandler(this.all_collection_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(652, 393);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 35);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(83, 22);
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Size = new System.Drawing.Size(165, 23);
            this.user_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email Address";
            // 
            // email_address
            // 
            this.email_address.Location = new System.Drawing.Point(375, 22);
            this.email_address.Name = "email_address";
            this.email_address.ReadOnly = true;
            this.email_address.Size = new System.Drawing.Size(160, 23);
            this.email_address.TabIndex = 7;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(31, 62);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(49, 15);
            this.asd.TabIndex = 8;
            this.asd.Text = "Address";
            // 
            // user_address
            // 
            this.user_address.Location = new System.Drawing.Point(84, 57);
            this.user_address.Name = "user_address";
            this.user_address.ReadOnly = true;
            this.user_address.Size = new System.Drawing.Size(164, 23);
            this.user_address.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number";
            // 
            // user_phone_number
            // 
            this.user_phone_number.Location = new System.Drawing.Point(375, 50);
            this.user_phone_number.Name = "user_phone_number";
            this.user_phone_number.ReadOnly = true;
            this.user_phone_number.Size = new System.Drawing.Size(160, 23);
            this.user_phone_number.TabIndex = 11;
            // 
            // Movies_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_phone_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_address);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.email_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.all_collection);
            this.Controls.Add(this.my_collection);
            this.Controls.Add(this.see_all_movies);
            this.Name = "Movies_Dashboard";
            this.Text = "Movies Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button see_all_movies;
        private Button my_collection;
        private Button all_collection;
        private Button cancel;
        private Label label1;
        private TextBox user_name;
        private Label label2;
        private TextBox email_address;
        private Label asd;
        private TextBox user_address;
        private Label label3;
        private TextBox user_phone_number;
    }
}