
namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                if (double.TryParse(valor, out double valorNumerico))
                {
                    return valorNumerico;
                }
                return double.MinValue;
            }
        }


        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return (sistema == ESistema.Decimal) ? new SistemaDecimal(valor) : new SistemaDecimal(valor);
        }


        private SistemaBinario DecimalABinario()
        {
            if (!int.TryParse(valor, out int valorDecimal))
            {
                if (valorDecimal < 0)
                {
                    return new SistemaBinario(msgError);

                }
            }

            string valorBinario = "";

            do
            {
                valorBinario = (valorDecimal % 2) + valorBinario;
                valorDecimal /= 2;
            }
            while (valorDecimal >= 2);
            valorBinario = valorDecimal + valorBinario;

            return new SistemaBinario(valorBinario);
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double numero);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}