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

        }
    }
}
