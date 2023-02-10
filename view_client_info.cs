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
    public partial class view_client_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-60CK96A\SQLEXPRESS;Initial Catalog=churches_system;Integrated Security=True");

        public view_client_info()
        {
            InitializeComponent();
        }

        private void view_client_info_Load(object sender, EventArgs e)
        {
             int i = 0;

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from client_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 500;
            imageCol.HeaderText = "Imagen do cliente";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.Width = 100;
            dataGridView1.Columns.Add(imageCol);

            foreach(DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["client_images"].ToString());
                dataGridView1.Rows[i].Cells[8].Value = img;
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }


        }
    }
}
