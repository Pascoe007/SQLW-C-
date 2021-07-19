using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_DataBase_Link
{
    public partial class Form1 : Form
    {
        private SqlConnection connectionStr = new SqlConnection("server=FISH-PC-041;database=AdventureWorks2019; Trusted_Connection=True");
        bool orderBY = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Search_Database(string query)
        {
            try
            {
                
                connectionStr.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connectionStr)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter command = new SqlDataAdapter("", connectionStr)
                {
                    SelectCommand = sqlCommand
                };
                var table = new DataTable();
                command.Fill(table);
                dataGridView1.DataSource = table;
                connectionStr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add_Data_(string m_firstName,string m_middleName, string m_lastName)
        {
            try 
            {
                int ID = Get_BusinessEntityID();
                connectionStr.Open();
                //string query = $"EXECUTE Person.spInsertPerson @BusinessEntityID = {ID}, @Title = 'Mr', @FirstName = '{m_firstName}', @MiddleName = '{m_middleName}', @LastName = '{m_lastName}' GO";
                string query = "Person.spInsertPerson";
                SqlCommand sqlCommand = new SqlCommand(query, connectionStr)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@BusinessEntityID", SqlDbType.Int).Value = ID ;
                sqlCommand.Parameters.AddWithValue("@Title", "Mr");
                sqlCommand.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = m_firstName;
                sqlCommand.Parameters.AddWithValue("@MiddleName", SqlDbType.NVarChar).Value = m_middleName;
                sqlCommand.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = m_lastName;

                sqlCommand.ExecuteNonQuery();
                connectionStr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Person.spPerson_GetAll";
            Search_Database(query);
        }
        private void Find_Address_Click(object sender, EventArgs e)
        {
            string AddressQuery = "Person.spGetAddress";
            Search_Database(AddressQuery);
        }

        private void JoinTables_Click(object sender, EventArgs e)
        {
            string JoinQuery = "Person.spJoinTable";
            Search_Database(JoinQuery);
        }

        private void Add_Data_Click(object sender, EventArgs e)
        {
            AddPerson form = new AddPerson(this);
            form.Show();
        }

        private int Get_BusinessEntityID()
        {
            connectionStr.Open();
            string query = "SELECT TOP 1 BusinessEntityID FROM Person.PersonNew ORDER BY BusinessEntityID DESC";
            SqlCommand sqlCommand = new SqlCommand(query, connectionStr);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            string businessID = reader["BusinessEntityID"].ToString();
            int ID = Int32.Parse(businessID) + 1;
            connectionStr.Close();
            return ID;
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string FnText = FN_SearchBox.Text;
            string LnText = LN_SearchBox.Text;

            if (FnText == "")
            {
                FnText = "%";
            }
            if (LnText == "")
            {
                LnText = "%";
            }

            connectionStr.Open();
            string query = "Person.spSearchTable";
            SqlCommand sqlCommand = new SqlCommand(query, connectionStr)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value =FnText;
            sqlCommand.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value =LnText;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            DataTable tb = new DataTable();
            var table = tb;
            table.Load(reader);
            dataGridView1.DataSource = table;


            connectionStr.Close();
        }
    }
}
