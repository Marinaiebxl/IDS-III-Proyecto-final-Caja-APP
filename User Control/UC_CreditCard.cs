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

namespace DS_III_Proyecto_final_Caja_APP.User_Control
{
    public partial class UC_CreditCard : UserControl
    {
        Function fn = new Function();
        //string query;
        public UC_CreditCard()
        {
            InitializeComponent();
            LoadDate();
        }

        private void LoadDate()
        {
            using (SqlConnection connection = fn.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [hotel].[dbo].[Huespedes]", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void UC_CreditCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = fn.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [hotel].[dbo].[Huespedes] ([Nombre], [Apellidos], [Telefono]) VALUES (@Nombre, @Apellidos, @Telefono)", connection);
                command.Parameters.AddWithValue("@Nombre", txtName.Text);
                command.Parameters.AddWithValue("@Apellidos", txtLastName.Text);
                command.Parameters.AddWithValue("@Telefono", Convert.ToInt32(txtPhoneNumber.Text));

                command.ExecuteNonQuery();
                LoadDate();

                
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void GetCardData(int HuespedID)
        //{
        //    using (SqlConnection con = fn.GetConnection())
        //    {
        //        SqlCommand cmd = new SqlCommand("ObtenerDatosHabitacion", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ID_Habitacion", roomID);

        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            txtRoomType.Text = reader["Descripcion"].ToString();
        //            txtBedLim.Text = reader["Limite"].ToString();
        //            txtroomPrice.Text = reader["precio_por_noche"].ToString();
        //        }

        //        reader.Close();
        //    }
        //}
    }
}
