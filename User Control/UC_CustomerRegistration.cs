using DS_III_Proyecto_final_Caja_APP.hotelDataSetTableAdapters;
using Guna.UI2.WinForms;
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
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DS_III_Proyecto_final_Caja_APP.User_Control
{
    public partial class UC_CustomerRegistration : UserControl

    {
        Function fn = new Function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Roomtypecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bedlimtcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void AlloeRoombtn_Click(object sender, EventArgs e)
        {
            


        }

        private void txtNoRoom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBedLim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroomPrice_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //string nombre = txtNombre.Text;
            //string apellidos = txtApellidos.Text;

            using (SqlConnection connection = fn.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("BuscarHuesped", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", txtname.Text);
                command.Parameters.AddWithValue("@Apellidos", txtapellidos.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }



        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshDataGridView()
        {

        }

    }
    }
