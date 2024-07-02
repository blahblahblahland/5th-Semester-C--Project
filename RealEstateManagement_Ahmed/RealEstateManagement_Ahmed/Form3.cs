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

namespace RealEstateManagement_Ahmed
{
    public partial class sell_screen : Form
    {
        public sell_screen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PMLS\source\repos\RealEstateManagement_Ahmed\RealEstateManagement_Ahmed\properties.mdf;Integrated Security=True");
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idboxadd.Text == "" || nameboxadd.Text == "" || numberboxadd.Text == "" || locationboxadd.Text == "" || priceboxadd.Text == "" || typeboxadd.Text == "")
                {
                    MessageBox.Show("Missing Information, Cannot List");
                }
                else
                {
                    con.Open();
                    string q = "INSERT INTO [Properties] values( '"+typeboxadd.Text+ "', '"+priceboxadd.Text+"', '"+locationboxadd.Text+"', '"+idboxadd.Text+"', '"+nameboxadd.Text+"','"+numberboxadd.Text+"' )";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Property has been listed, Please regularly check status for updates");
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
