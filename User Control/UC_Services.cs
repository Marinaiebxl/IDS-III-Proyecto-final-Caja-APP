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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DS_III_Proyecto_final_Caja_APP.User_Control
{
    public partial class UC_Services : UserControl
    {
        Function fn = new Function();
        string query;
        private int id_huesped;
        int idServicio;
        public UC_Services()
        {
            InitializeComponent();
        }

     

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            id_huesped = int.Parse(guna2TextBox2.Text);

            using (SqlConnection connection = fn.GetConnection())
            {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con tu stored procedure
                SqlCommand command = new SqlCommand("ObtenerDatosServicioPorIdHuesped", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro @IdHuesped al stored procedure
                command.Parameters.AddWithValue("@IdHuesped", id_huesped);

                // Crear un objeto SqlDataAdapter para ejecutar el comando SQL
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Crear un nuevo objeto DataTable
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los resultados del comando SQL
                adapter.Fill(dataTable);

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(guna2TextBox2.Text, out int servicioId))
            {
                id_huesped = servicioId;
               GetServiceData(servicioId);
            }




        }

        public void GetServiceData(int servicioId)
        {
            using (SqlConnection con = fn.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ObtenerTotalPreciosServicioPorIdHuesped", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdHuesped", id_huesped);
                int totalPrecios = 0;

                SqlParameter outputParameter = new SqlParameter("@TotalPrecios", totalPrecios);
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                cmd.ExecuteNonQuery();

                
                int totalPrecios2 = Convert.ToInt32(outputParameter.Value);
                guna2TextBox1.Text = totalPrecios2.ToString();


                
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

  

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
