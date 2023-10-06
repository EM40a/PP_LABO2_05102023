
namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
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
            return (sistema == ESistema.Binario) ? new SistemaBinario(valor) : BinarioADecimal();
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            if (valor.Length == 0)
            {
                return false;
            }

            foreach (char i in valor)
            {
                if (i != '0' && i != '1')
                {
                    return false;
                }
            }

            return true;
        }


        private SistemaDecimal BinarioADecimal()
        {
            if (string.IsNullOrEmpty(msgError))
            {
                return double.MinValue;
            }

            double valorDecimal = 0;
            int potencia = 0;

            for (int i = valor.Length - 1; i >= 0; i--)
            {
                if (valor[i] == '1')
                {
                    valorDecimal += Math.Pow(2, potencia); // 2 ^ x
                }

                potencia++;
            }

            return new SistemaDecimal(valorDecimal.ToString());
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}