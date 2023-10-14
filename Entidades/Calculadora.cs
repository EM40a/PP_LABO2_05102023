using System.Text;
namespace Entidades
{
    public class Calculadora
    {
        private string nombre;
        private List<string> operaciones;
        private Numeracion primerOperando;

        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        #region Constructores
        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno) : this()
        {
            this.nombre = nombreAlumno;
        }
        #endregion

        #region Propiedades
        public string NombreAlumno { get => nombre; set => nombre = value; }
        public List<string> Operaciones { get => operaciones; }
        public static ESistema Sistema { get => sistema; set => sistema = value; }
        public Numeracion Resultado { get => resultado; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Realiza la operacion de suma entre los operandos.
        /// </summary>
        public void Calcular()
        {
            Calcular('+');
        }

        /// <summary>
        /// Realiza operaciones entre los operandos. Por defecto realiza una suma
        /// </summary>
        /// <param name="operador">Un caracter que determinara la operacion a realizar</param>
        public void Calcular(char operador)
        {
            double resultado = double.MinValue;
            if (this.primerOperando == this.segundoOperando)
            {
                switch (operador)
                {
                    case '-':
                        resultado = this.primerOperando - this.segundoOperando;
                        break;

                    case '*':
                        resultado = this.primerOperando * this.segundoOperando;
                        break;

                    case '/':
                        if (this.segundoOperando.ValorNumerico != 0)
                        {
                            resultado = this.primerOperando / this.segundoOperando;
                        }
                        break;

                    default:
                        resultado = this.primerOperando + this.segundoOperando;
                        break;
                }
            }

            this.resultado = this.MapeaResultado(resultado);
        }

        /// <summary>
        /// Limpia el historial de operaciones.
        /// </summary>
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        /// <summary>
        /// Mapea el resultado de la operacion a un tipo Numeracion.
        /// </summary>
        private Numeracion MapeaResultado(double valor)
        {
            Numeracion resultado = (SistemaDecimal) valor.ToString(); 
            return resultado.CambiarSistemaDeNumeracion(Calculadora.sistema);
        }

        /// <summary>
        /// Actualiza el historial de operaciones con la ultima operacion realizada.
        /// </summary>
        public void ActualizarHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new();
            sb.Append(Calculadora.Sistema);
            sb.Append(": ");
            sb.Append(this.primerOperando.Valor);
            sb.Append(' ');
            sb.Append(operador);
            sb.Append(' ');
            sb.Append(this.segundoOperando.Valor);
            sb.Append(" = ");
            sb.Append(this.resultado.Valor);
            operaciones.Add(sb.ToString());
        }
        #endregion
    }
}