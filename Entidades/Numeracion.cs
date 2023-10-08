namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        public string Valor
        {
            get 
            {
                return valor;
            }
        }

        internal abstract double ValorNumerico{ get; }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        public static bool operator ==(Numeracion numeracion1, Numeracion numeracion2)
        {
            bool mismoTipo = numeracion1.GetType() == numeracion2.GetType();
            bool ambasNulas = numeracion1 is null && numeracion2 is null;

            return !ambasNulas && mismoTipo;
        }

        public static bool operator !=(Numeracion numeracion1, Numeracion numeracion2)
        {
            return !(numeracion1 == numeracion2);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }

        //* Los operadores realizarán las operaciones correspondientes entre dos números.
        public static Numeracion operator +(Numeracion numeracion1, Numeracion numeracion2)
        {
            double resultado = numeracion1.ValorNumerico + numeracion2.ValorNumerico;
            return new SistemaDecimal(resultado.ToString());
        }

        public static Numeracion operator -(Numeracion numeracion1, Numeracion numeracion2)
        {
            double resultado = numeracion1.ValorNumerico - numeracion2.ValorNumerico;
            return new SistemaDecimal(resultado.ToString());
        }

        public static Numeracion operator *(Numeracion numeracion1, Numeracion numeracion2)
        {
            double resultado = numeracion1.ValorNumerico * numeracion2.ValorNumerico;
            return new SistemaDecimal(resultado.ToString());
        }

        public static Numeracion operator /(Numeracion numeracion1, Numeracion numeracion2)
        {
            double resultado = numeracion1.ValorNumerico / numeracion2.ValorNumerico;
            return new SistemaDecimal(resultado.ToString());
        }
    }
}