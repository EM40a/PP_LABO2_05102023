using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;


        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("S.Emanuel Hermosilla");
        }

        //? El formulario se encuentra en memoria pero invisible
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
            Text = calculadora.NombreAlumno;
            MaximizeBox = false;
            this.MinimizeBox = false;
            cmbOperacion.SelectedIndex = 0;
        }

        //? Comienza el cierre del Form, se puede cancelar
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "¿Desea cerrar la calculadora?", "Cierre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            // ?Si contesta SI se cerrará, si contesta NO debe continuar en ejecución.
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }


        //* Cambia el sistema segun el RadioButton seleccionado
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                Calculadora.Sistema = ESistema.Binario;
            }
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                Calculadora.Sistema = ESistema.Binario;
            }
        }

        private void MostrarHistorial()
        {
            lstHistorial.DataSource = null;
            lstHistorial.DataSource = calculadora.Operaciones;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = GetOperando(txtPrimerOperador.Text);
            calculadora.SegundoOperando = GetOperando(txtSegundoOperador.Text);

            operador = (char)cmbOperacion.SelectedItem;

            calculadora.Calcular(operador);
            calculadora.ActualizarHistorialDeOperaciones(operador);

            lblResultadoNumerico.Text = calculadora.Resultado.Valor;
            MostrarHistorial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            calculadora.EliminarHistorialDeOperaciones();
            txtPrimerOperador.Text = string.Empty;
            txtSegundoOperador.Text = string.Empty;
            lblResultadoNumerico.Text = string.Empty;
            MostrarHistorial();
        }
    }
}
