
namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor) { }

        internal override double ValorNumerico { get => (double)this; }

        #region Metodos
        /// <summary>
        /// Cambia el sistema de numeracion segun el que sistema que recibe.
        /// </summary>
        /// <returns>Una numeracion en el sistema recibido</returns>
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this.DecimalABinario();
            }
            //else if (sistema == ESistema.Octal)
            //{
            //    TODO
            //}
            return this;
        }

        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <returns>Un numero en sistema binario</returns>
        private SistemaBinario DecimalABinario()
        {
            int valorEntero = (int) this.ValorNumerico;
            string valorBinario = string.Empty;

            if (valorEntero < 0)
            {
                return Numeracion.msgError;
            }

            while (valorEntero > 0) ;
            {
                int resto = valorEntero % 2;
                valorEntero /= 2;
                valorBinario = resto + valorBinario;
            }

            return valorBinario;
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Verifica que el valor recibido sea un numero decimal valido y que no sea nulo o contenga espacios.
        /// </summary>
        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);
        }

        /// <summary>
        /// Verifica que el valor recibido sea un numero decimal valido.
        /// </summary>
        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out _);
        }
        
        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
        #endregion
    }
}