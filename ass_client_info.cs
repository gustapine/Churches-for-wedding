using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace churches
{
    public partial class ass_client_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-60CK96A\SQLEXPRESS;Initial Catalog=churches_system;Integrated Security=True");
        string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        string pwd = Class1.GetRandomPassword(20);
       
        public ass_client_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string img_path="";
                pwd = pwd + 1;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\client_images\\"+pwd+".jpg");

                img_path = "client_images\\"+pwd+".jpg";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into client_info values('"+ textBox1.Text +"','"+ img_path.ToString() +"','"+ textBox3.Text +"','"+ textBox4.Text +"')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string pwd = Class1.GetRandomPassword(20);
            string wanted_path;
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files(*.jpeg)|.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if(result == DialogResult.OK)// teste de resultado
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //pictureBox1.ImageLocation = @"..\..\client_images\" + pwd + ".jpg";
        }

        private void ass_client_info_Load(object sender, EventArgs e)
        {

        }
    }
}
