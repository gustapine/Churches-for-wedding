using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace churches
{
    public partial class add_churches : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-60CK96A\SQLEXPRESS;Initial Catalog=churches_system;Integrated Security=True");
  
        public add_churches()
        {
            InitializeComponent();
        }

        private void add_churches_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection GetCon()
        {
            return con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into church_info values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";


            MessageBox.Show("Igreja adicioanda com sucesso!");
        }
    }
}
