
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
                return (double)CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            //TODO
            return DecimalABinario();
        }

        private SistemaBinario DecimalABinario()
        {
            if (!int.TryParse(this.valor, out int valorDecimal) || valorDecimal <= 0)
            {
                return new SistemaBinario("Valor inválido");
            }

            string valorBinario = "";

            do
            {
                valorBinario = (valorDecimal % 2) + valorBinario;
                valorDecimal /= 2;
            }
            while (ValorNumerico >= 2);
            valorBinario = valorDecimal + valorBinario;

            return new SistemaBinario(valorBinario);
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor);
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