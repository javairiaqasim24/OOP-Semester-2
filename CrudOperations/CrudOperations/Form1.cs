using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Student(RegNo,Name,Contact) VALUES ('" + textBox8.Text + "', '" + textBox10.Text + "', '" + textBox7.Text + "')";
            DatabaseHelper.Instance.Update(query);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string name = textBox9.Text;
            string RegNo = textBox12.Text;


            string query = $"UPDATE Student SET Name = '{name}' WHERE RegNo = '{RegNo}'";
            DatabaseHelper.Instance.Update(query);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string regNo = textBox11.Text;
            string query = $"DELETE FROM Student WHERE RegNo = '{regNo}'";
            DatabaseHelper.Instance.Update(query);

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Student";

            
            DataTable dt = new DataTable();

            
            var reader = DatabaseHelper.Instance.getData(query);

            
            dt.Load(reader);

            
            dataGridView2.DataSource = dt;
            
        }
    }
}
