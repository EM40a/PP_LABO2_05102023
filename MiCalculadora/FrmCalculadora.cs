namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        //private Numeracion.ESistema sistema;
        //private Numeracion? primerOperando;
        //private Numeracion? segundoOperando;
        //private Numeracion? resultado;
        //private Operacion? calculadora;
        private List<string> historial;


        public FrmCalculadora()
        {
            InitializeComponent();
        }

        //? El formulario se encuentra en memoria pero invisible
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora de EM40a";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.cmbOperacion.SelectedIndex = 0;
            this.historial = new();
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

        //? Mostrara el resultado de la operación, convertido de acuerdo con el sistema numérico seleccionado
        //private void SetResultado()
        //{
        //    if (this.resultado is not null)
        //    {
        //        lblResultadoNumerico.Text = this.resultado.ConvertirA(sistema);
        //    }
        //}

        //* Cambia el sistema segun el RadioButton seleccionado
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbDecimal.Checked)
            //{
            //    this.sistema = Numeracion.ESistema.Decimal;
            //    this.SetResultado();
            //}
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbBinario.Checked)
            //{
            //    this.sistema = Numeracion.ESistema.Binario;
            //    this.SetResultado();
            //}
        }

        //* Instancia los operadores con los valores de los TextBox
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            //this.primerOperando = new(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            //this.segundoOperando = new(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la operacion y muestra el resultado en el Label de resultado de la pantalla
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            //? Valida que los TextBox no estén vacíos o sean nulos
            if ((string.IsNullOrEmpty(txtPrimerOperador.Text) || string.IsNullOrEmpty(txtSegundoOperador.Text)))
            {
                MessageBox.Show("Debe ingresar los dos operandos para realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //this.calculadora = new Operacion(primerOperando, segundoOperando);
            //this.resultado = calculadora.Operar(cmbOperacion.Text[0]);
            //this.SetResultado();


            string operacionCompleta = $"{txtPrimerOperador.Text} {cmbOperacion.Text} {txtSegundoOperador.Text} = {lblResultadoNumerico.Text}";
            this.historial.Add(operacionCompleta);

            // Actualizar el ListBox con el historial
            lstHistorial.DataSource = null;
            lstHistorial.DataSource = historial;
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Borra los datos de los TextBox, Label de resultado de la pantalla y también asignará null al atributo resultado del formulario
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultadoNumerico.Text = null;
            //this.resultado = null;
        }
    }
}
