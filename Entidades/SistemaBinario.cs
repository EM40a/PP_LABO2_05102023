
namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor) { }

        internal override double ValorNumerico
        {
            get => (double)this.CambiarSistemaDeNumeracion(ESistema.Decimal);
        }

        #region Metodos
        /// <summary>
        /// Cambia el sistema de numeracion segun el que sistema que recibe.
        /// </summary>
        /// <returns>Una numeracion en el sistema recibido</returns>
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.BinarioADecimal();
            }
            //else if (sistema == ESistema.Octal)
            //{
            //    TODO
            //}
            return this;
        }

        /// <summary>
        /// Verifica que el valor recibido sea un numero binario valido y que no sea nulo o contenga espacios.
        /// </summary>
        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        /// <summary>
        /// Verifica que el valor recibido sea un numero binario valido.
        /// </summary>
        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char i in valor)
            {
                if (i != '0' && i != '1')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Realiza  la conversion de un numero binario a decimal.
        /// </summary>
        /// <returns>Una nueva numeracion en sistema decimal</returns>
        private SistemaDecimal BinarioADecimal()
        {
            if (base.valor != Numeracion.msgError)
            {
                double valorDecimal = 0;
                int potencia = 0;

                for (int i = base.valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        valorDecimal += Math.Pow(2, potencia); // 2 ^ potencia
                    }

                    potencia++;
                }

                return valorDecimal.ToString();
            }

            return double.MinValue;
        }
        #endregion

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}