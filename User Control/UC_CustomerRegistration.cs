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
            if (txtname.Text != "" && txtapellidos.Text != "" && txttelefono.Text != "" && txtcorreo.Text != "" && txtcorreo.Text != "")
            {
                String name = txtname.Text;
                String apellido = txtapellidos.Text;
                String Correo = txtcorreo.Text;
                String Telefono = txttelefono.Text;

                // poner los campos de la tabla Huespedes
                query = "insert into Huespedes() values ('" +name+"', "+apellido+", '" +Correo+", '" +Telefono+" )";
            }
            else
            {
                MessageBox.Show("los campos son mandatorios", "Informacion !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

        }

        private void txtNoRoom_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(txtNoRoom.Text, out int roomID))
            //{
            //    GetRoomData(roomID);
            //}
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

        //private void GetRoomData(int roomID)
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
            using (SqlConnection connection = fn.GetConnection())
            {

                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con tu consulta SQL
                SqlCommand command = new SqlCommand("Select * from Huespedes", connection);
                command.CommandType = CommandType.Text;

                // Crear un objeto SqlDataAdapter para ejecutar el comando SQL
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Crear un nuevo objeto DataTable
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los resultados del comando SQL
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();

            }



        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(txtname.Text, out int roomID))
            //{
            //    GetRoomData(roomID);
            //}
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (string.IsNullOrEmpty(txtname.Text))
            //    {
            //        huespedesBindingSource.Filter = string.Empty;
            //    }
            //    else
            //    {
            //        huespedesBindingSource.Filter = string.Format("{0}='{1}'", txtname.Text);
            //    }
            //}
        }

        private void GetGuestData(int phoneNumber)
        {
            using (SqlConnection con = fn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ObtenerDatosHuespedPorTelefono", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Telefono", phoneNumber);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtname.Text = reader["Nombre"].ToString();
                    txtapellidos.Text = reader["Apellidos"].ToString();
                    txttelefono.Text = reader["Telefono"].ToString();
                    // Aquí puedes asignar otros valores a los TextBox correspondientes
                }

                reader.Close();
            }
        }


        // }
    }
}
