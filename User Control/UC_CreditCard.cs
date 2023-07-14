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
        }

        private void UC_CreditCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
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
