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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RealEstateManagement_Ahmed
{
    public partial class buy_screen : Form
    {


        public buy_screen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PMLS\source\repos\RealEstateManagement_Ahmed\RealEstateManagement_Ahmed\properties.mdf;Integrated Security=True");
        private void buy_screen_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [Properties]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

        }

        private void refereshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [Properties]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{ if(idBox.Text == "")
                {
                    MessageBox.Show("Missing ID");
                }
            else
                {
                    con.Open();
                    string qq = "INSERT INTO [Booked] values('" + id_buy.Text + "','" + Name_buy.Text + "','" + number_buy.Text + "','" + idBox.Text + "', '"+locationBox2.Text+"','"+Sellernamebox.Text+"','"+SellerNumberbox.Text+"')";
                    string q = "DELETE FROM [Properties] where property_id= '" + idBox.Text + "' ";
                    SqlCommand cmd = new SqlCommand(q,con);
                    SqlCommand cc = new SqlCommand(qq,con);
                    cmd.ExecuteNonQuery();
                    cc.ExecuteNonQuery();
                    con.Close() ;
                    MessageBox.Show("Property Booked for purchase, Please contaxt seller at '" + SellerNumberbox.Text + "'");
                    
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { con.Close(); }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        
        try{
                priceBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                typeBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Sellernamebox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                SellerNumberbox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                locationBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                idBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        
        }
    }
}
