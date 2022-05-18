using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApe1.Text = "";
            txtApe2.Text = "";
            txtCalle.Text = "";
            txtCedula.Text = "";
            txtEmail.Text = "";
            txtFecha.Text = "";
            txtInter.Text = "";
            txtNom1.Text = "";
            txtNom2.Text = "";
            txtNum.Text = "";
            txtTel.Text = "";



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedula.Text);
            String nom1 = txtNom1.Text;
            String nom2 = txtNom2.Text;
            String ape1 = txtApe1.Text;
            String ape2 = txtApe2.Text;
            String fecha = txtFecha.Text;
            String calle = txtCalle.Text;
            int num = Convert.ToInt32(txtNum.Text);
            String inter = txtInter.Text;
            int tel = Convert.ToInt32(txtTel.Text);
            String email = txtEmail.Text;

            if (txtCedula.Text == "" || txtApe1.Text == "" || txtCalle.Text == "" || txtEmail.Text == "" || txtFecha.Text == "" || txtNom1.Text == "" ||
                txtNum.Text == "" || txtEmail.Text == "" || txtInter.Text == "")
            {
                MessageBox.Show("Uno de los campos está vació");
            }
            else
            {

                MessageBox.Show("Tu cedula es: " + cedula + "\nTu primer nombre es: " + nom1 + "\nTu segundo nombre es: " + nom2 +
                    "\nTu primer apellido es: " + ape1 + "\nTu segundo apellido es: " + ape2 + "\nTu fecha de nacimiento es: " + fecha + "\nTu email es: " + email +
                    "\nLa direccion de tu casa es: " + "        \nCalle: " + calle + "      \nNúmero: " + num + "       \nIntersección: " + inter);

            }



        }
    }
}
