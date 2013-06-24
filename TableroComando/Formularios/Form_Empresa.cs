using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Repositorios;

namespace TableroComando.Formularios
{
    public partial class Form_Empresa : Form
    {
        Empresa _empresa = EmpresaRepository.Instance.FindById(1);

        public Form_Empresa()
        {
            InitializeComponent();
        }

        private void Form_Empresa_Load(object sender, EventArgs e)
        {
            CargarEmpresa();            
        }

        private void CargarEmpresa()
        {
            txtDenominacion.Text = _empresa.Denominacion;
            txtCuit.Text = _empresa.Cuit;
            txtDireccion.Text = _empresa.Direccion;
            txtTelefono.Text = _empresa.Telefono;
            txtAutoridades.Text = _empresa.Autoridades;
            txtMision.Text = _empresa.Mision;
            txtVision.Text = _empresa.Vision;
            txtValores.Text = _empresa.Valores;
        }

        private void CrearDatosEmpresa()
        {

            _empresa.Denominacion = txtDenominacion.Text;
            _empresa.Cuit = txtCuit.Text;
            _empresa.Direccion = txtDireccion.Text;
            _empresa.Telefono = txtTelefono.Text;
            _empresa.Autoridades = txtAutoridades.Text;
            _empresa.Mision = txtMision.Text;
            _empresa.Vision = txtVision.Text;
            _empresa.Valores = txtValores.Text;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
                CrearDatosEmpresa();
                EmpresaRepository.Instance.Save(_empresa);
                MessageBox.Show("Los datos de su empresa se guardaron correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
