using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgenciaSeguros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Conexion.Abrir();
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if(txtContra.Text == txtContra.Hint)
            {
                txtContra.PasswordChar = new char();
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            txtContra.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void iniciarSesion()
        {
            String sql = $"SELECT contraseña FROM USUARIOS WHERE USUARIO = '{txtUsu.Text}'";
            Conexion.SetComando(sql);
            MySqlDataReader lector = Conexion.comando.ExecuteReader();
            if (lector.Read())
            {
                String contra = lector.GetString(0);

                if (txtContra.Text == contra)
                {
                    Console.WriteLine("Sesión iniciada.");
                    lblError.Visible = false;

                    Inicio p = new Inicio();
                    this.Hide();
                    lector.Close();
                    p.ShowDialog();

                    if (p.DialogResult == DialogResult.Cancel)
                        this.Close();
                    else if (p.DialogResult == DialogResult.OK)
                    {
                       // txtUsu.Text = txtUsu.Hint;
                       // txtContra.Text = txtContra.Hint;
                       // txtUsu.ForeColor = Color.Gray;
                       // txtContra.ForeColor = Color.Gray;
                        this.Show();
                    }
                }
                else
                {
                    lblError.Text = "Contraseña incorrecta";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Usuario incorrecto";
                lblError.Visible = true;
            }
            lector.Close();
        }

        private void pulsarEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                iniciarSesion();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsu.Text.Length > 0 && txtContra.Text.Length > 0)
                {
                    Console.WriteLine("Usuario registrado.");
                    lblError.Visible = false;

                    String sql = $"INSERT INTO USUARIOS VALUES ('{txtUsu.Text}', '{txtContra.Text}')";
                    Conexion.SetComando(sql);
                    Conexion.comando.ExecuteNonQuery();
                }
                else
                {
                    lblError.Text = "Debes rellenar los datos";
                    lblError.Visible = true;
                }
            }
            catch (MySqlException)
            {
                lblError.Text = "Ya existe un usuario con ese nombre";
                lblError.Visible = true;
            }
        }
    }
}
