using Entidades;

namespace FrmView
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;

        #region Form
        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("EM40a");
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };

        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Metodos
        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }


        #endregion

        #region Botones
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            this.calculadora.PrimerOperando = this.GetOperando(this.txtPrimerOperando.Text);
            this.calculadora.SegundoOperando = this.GetOperando(this.txtSegundoOperando.Text);

            operador = (char)this.cmbOperacion.SelectedItem;

            this.calculadora.Calcular(operador);
            this.calculadora.ActualizarHistorialDeOperaciones(operador);
            this.lblResultado.Text = calculadora.Resultado.Valor;
            this.MostrarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = "0";
            this.MostrarHistorial();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.lblHistorial.Visible ^= true;
            this.lstHistorial.Visible ^= true;
            this.btnOperar.Enabled ^= true;
            this.MostrarHistorial();
        }
        #endregion

        #region Cambio de sistema
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void rdbOctal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Octal;
        }
        #endregion
    }
}