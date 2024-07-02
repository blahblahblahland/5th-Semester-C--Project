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
    public partial class status_screen : Form
    {
        public status_screen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PMLS\source\repos\RealEstateManagement_Ahmed\RealEstateManagement_Ahmed\properties.mdf;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                availabledisplay();
                con.Open();
                string query = "SELECT * FROM [Booked]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                bookedgridview.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
        private void availabledisplay()
        {
            con.Open();
            string query = "SELECT * FROM [Properties]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            availablegridview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void availabledisplayname()
        {
            con.Open();
            string query = "SELECT * FROM [Properties] where [Seller Name] = '" + sbnbox.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            availablegridview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void availabledisplayid()
        {
            con.Open();
            string query = "SELECT * FROM [Properties] where property_id = '" + sbibox.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            availablegridview.DataSource = ds.Tables[0];
            con.Close();
        }

        private void availabledisplayl()
        {
            con.Open();
            string query = "SELECT * FROM [Properties] where location = '" + sblbox.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            availablegridview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                availabledisplayname();
                con.Open();
                string query = "SELECT * FROM [Booked] where Name = '" + sbnbox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                bookedgridview.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                availabledisplayid();
                con.Open();
                string query = "SELECT * FROM [Booked] where PID = '" + sbibox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                bookedgridview.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                availabledisplayl();
                con.Open();
                string query = "SELECT * FROM [Booked] where location = '" + sblbox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                bookedgridview.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
