using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_DataBase_Link
{
    public partial class AddPerson : Form
    {
        //public Form1 Form1;
        private Form1 form1;
        public AddPerson(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = "", middleName = "", lastName = "";
                string Name = NameTextBox.Text;
                if (Name != "")
                {
                    List<string> splitName = new List<string>();
                    splitName = Name.Split(' ').ToList();
                    firstName = splitName[0];
                    lastName = splitName[splitName.Count - 1];
                    middleName = string.Join(" ", splitName.GetRange(1, splitName.Count - 2));

                    listView1.Items.Add(firstName);
                    listView1.Items.Add(middleName);
                    listView1.Items.Add(lastName);

                    form1.Show();
                    form1.Add_Data_(firstName, middleName, lastName);
                }
                else
                {
                    MessageBox.Show("No Data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
