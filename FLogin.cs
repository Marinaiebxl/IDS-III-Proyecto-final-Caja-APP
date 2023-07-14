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

namespace DS_III_Proyecto_final_Caja_APP
{
    public partial class FLogin : Form
    {
        Function fn = new Function();


        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            string username = guna2TextBox1.Text.Trim();
            string password = guna2TextBox2.Text;

            // Crear la conexión y el comando para llamar al procedimiento almacenado
            using (SqlConnection connection = fn.GetConnection())
            using (SqlCommand command = new SqlCommand("LoginProcedure", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros de entrada al comando
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar el comando y obtener el resultado de la autenticación
                    bool isAuthenticated = (bool)command.ExecuteScalar();

                    // Verificar el resultado de la autenticación
                    if (isAuthenticated)
                    {
                        MessageBox.Show("Inicio de sesión exitoso");
                        FMain main = new FMain();
                        main.Show();
                        this.Hide();
                        // Realizar las acciones necesarias después del inicio de sesión exitoso
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error en el inicio de sesión: " + ex.Message);
                }
            }

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
