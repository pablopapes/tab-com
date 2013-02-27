﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TableroComando.Fachadas;
using Dominio;

namespace TableroComando.Formularios
{
    public partial class Form_Indicador : Form
    {
        private ObjetivoFachada ObjetivoFachada = ObjetivoFachada.Instance;
        private IndicadorFachada IndicadorFachada = IndicadorFachada.Instance;
        public Indicador Indicador { get; set; }


        public Form_Indicador(string textButton = "Agregar")
        {
            InitializeComponent();
            GuardarBtn.Text = textButton;
            
        }

        private void Form_AgregarIndicador_Load(object sender, EventArgs e)
        {
            ObjetivosCB.DataSource = ObjetivoFachada.All();
            ObjetivosCB.DisplayMember = "Nombre";
            MenorRB.Checked = true; // Por defecto, el radio buton de "tendencia menor" está seleccionado.
            CargarPropiedadesIndicador();
            MedicionesGridView.DataSource = new BindingList<Medicion>(Indicador.Mediciones);

            MedicionesGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            IndicadorFachada.SaveOrUpdate(Indicador);
        }

        private void CargarPropiedadesIndicador()
        {
            if (Indicador == null) 
                Indicador = new Indicador();
            
            ObjetivosCB.SelectedItem = Indicador.Objetivo;
            NombreTxt.DataBindings.Add("Text", Indicador, "Nombre");
            CodigoTxt.DataBindings.Add("Text", Indicador, "Codigo");
            CaracteristicaTxt.DataBindings.Add("Text", Indicador, "Caracteristica");
            PropositoTxt.DataBindings.Add("Text", Indicador, "Proposito");
            ObjetivosCB.DataBindings.Add("SelectedItem", Indicador, "Objetivo");
            
            //if(Indicador.Espectativa == "mayor") MayorRB.DataBindings.Add("Checked", true, ;
            //else MenorRB.Checked = true;

            PrioridadUD.DataBindings.Add("Value", Indicador, "Prioridad");

        }
    }
}