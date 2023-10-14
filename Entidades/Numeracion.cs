namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        #region Constructores
        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }
        #endregion

        #region Propiedades
        public string Valor { get => valor; }
        internal abstract double ValorNumerico { get; }
        #endregion

        #region Metodos
        /// <summary>
        /// Inicializa el atributo si el valor recibido es valido, en caso contrario lo inicializa con un mensaje de error.
        /// </summary>
        /// <param name="valor">Es el valor que va a tomar la numeracion</param>
        private void InicializaValor(string valor)
        {
            this.valor = EsNumeracionValida(valor) ? valor : Numeracion.msgError;
        }

        /// <summary>
        /// Metodo abstracto que cambia el sistema de la numeracion segun el sistema recibido.
        /// </summary>
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        /// <summary>
        /// Verifica que el valor recibido no sea nulo o contenga espacios.
        /// </summary>
        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }
        #endregion

        #region Sobrecargas de operadores
        /// <summary>
        /// Dos numeraciones seran iguales si ninguna es nulas y ambas son del mismo tipo.
        /// </summary>
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return (n1 is not null && n2 is not null) && (n1.GetType() == n2.GetType());
        }

        /// <summary>
        /// Dos numeraciones seran distintas si ambas son nulas o si no son del mismo tipo.
        /// </summary>
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            double.TryParse(numeracion.valor, out double resultado);
            return resultado;
        }

        //* Los operadores realizarán las operaciones correspondientes entre dos números.
        public static double operator +(Numeracion n1, Numeracion n2)
        {
            return n1.ValorNumerico + n2.ValorNumerico;
        }

        public static double operator -(Numeracion n1, Numeracion n2)
        {
            return n1.ValorNumerico - n2.ValorNumerico;
        }

        public static double operator *(Numeracion n1, Numeracion n2)
        {
            return n1.ValorNumerico * n2.ValorNumerico;
        }

        public static double operator /(Numeracion n1, Numeracion n2)
        {
            return n1.ValorNumerico / n2.ValorNumerico;
        }
        #endregion
    }
}