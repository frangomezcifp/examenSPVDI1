using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace W02_BibliotecaWinformUI
{
    public partial class BibliotecaMainForm : Form
    {
        private string connectionString =
            "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t;";
        bool existsAuthorsForm = true;

        public BibliotecaMainForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            String sql = $"SELECT film_id, title FROM film" +
                $" WHERE title LIKE '%{searchTextBox.Text}%'";

            books = connection.Query<Book>(sql).ToList();
            booksListBox.DataSource = books;
            booksListBox.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void CredencialsButton_Click(object sender, EventArgs e)
        {
            string User = this.UserTextBox.Text;
            string Password = this.PasswordTextBox.Text;

            if (User == "guest" || Password == "123")
            {
                
            } else 
            {
                
            }

            if (User == "Username field of staff table" || Password == "456")
            {

            }
            else
            {
                
            }
        }














        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
