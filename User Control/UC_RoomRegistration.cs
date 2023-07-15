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
    public partial class UC_RoomRegistration : UserControl
    {
        Function fn = new Function();
        //string query;
        public UC_RoomRegistration()
        {
            InitializeComponent();
        }

        private void txtNoRoom_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNoRoom.Text, out int roomID))
            {
                GetRoomData(roomID);
            }
        }

        private void txtBedLim_TextChanged(object sender, EventArgs e)
        {

        }


        private void GetRoomData(int roomID)
        {
            using (SqlConnection con = fn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ObtenerDatosHabitacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Habitacion", roomID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtRoomType.Text = reader["Descripcion"].ToString();
                    txtBedLim.Text = reader["Limite"].ToString();
                    txtroomPrice.Text = reader["precio_por_noche"].ToString();
                }

                reader.Close();
            }
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = checkin.Value.Date;
            DateTime fechaFin = checkout.Value.Date;

            TimeSpan diferencia = fechaFin - fechaInicio;
            int cantidadDias = diferencia.Days;

            txtCalcDia.Text = cantidadDias.ToString();
        }

        private void txtCalcDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlloeRoombtn_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = DateTime.Today; // Obtén la fecha de entrada de algún control en tu formulario
            DateTime fechaSalida = DateTime.Today.AddDays(3); // Obtén la fecha de salida de algún control en tu formulario
            int idHabitacion = 1; // Obtén el ID de habitación de algún control en tu formulario
            int idHuesped = 1; // Obtén el ID de huésped de algún control en tu formulario
            decimal montoTotal = 100.00m; // Obtén el monto total de algún control en tu formulario
            DateTime fechaFactura = DateTime.Today; // Obtén la fecha de la factura de algún control en tu formulario

            using (SqlConnection connection = fn.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertarReservacionYFactura", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FechaEntrada", DateTime.Now);
                command.Parameters.AddWithValue("@FechaSalida", Convert.ToDateTime(checkout.Text));
                command.Parameters.AddWithValue("@IdHabitacion", txtNoRoom.Text);
                command.Parameters.AddWithValue("@IdHuesped", txtHuesped.Text);
                command.Parameters.AddWithValue("@MontoTotal", Convert.ToInt32( txtCalcDia.Text) * Convert.ToInt32(txtroomPrice.Text));
                command.Parameters.AddWithValue("@FechaFactura", DateTime.Now);

                command.ExecuteNonQuery();

                MessageBox.Show("La reservación y la factura han sido insertadas correctamente.");
            }
        }

        private void UC_RoomRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarFact_Click(object sender, EventArgs e)
        {
            FormFactura.Form1 form1 = new FormFactura.Form1();
            form1.ShowDialog();
        }
    }
}
