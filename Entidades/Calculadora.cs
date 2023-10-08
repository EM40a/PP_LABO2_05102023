using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno) : this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public string NombreAlumno
        {
            get
            {
                return nombreAlumno;
            }
            set
            {
                nombreAlumno = value;
            }
        }

        public List<string> Operaciones
        {
            get
            {
                return operaciones;
            }
        }

        public static ESistema Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                sistema = value;
            }
        }

        public Numeracion Resultado
        {
            get
            {
                return resultado;
            }
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                segundoOperando = value;
            }
        }

        public void Calcular()
        {
            if (primerOperando != segundoOperando)
            {
                resultado = new SistemaDecimal(double.MinValue.ToString());
            }
            else
            {
                Calcular('+');
            }
        }

        public void Calcular(char operador)
        {
            if (primerOperando is null || segundoOperando is null)
            {
                return;
            }


            switch (operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    resultado = primerOperando / segundoOperando;
                    break;
                default:
                    resultado = new SistemaDecimal(double.MinValue.ToString());
                    break;
            }
            MapeaResultado((double) resultado);
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {

            string valorStr = valor.ToString();

            switch (sistema)
            {
                 case ESistema.Binario:
                    return new SistemaBinario(valorStr);
                
                 case ESistema.Decimal:
                 default:
                    return new SistemaDecimal(valorStr);
            }
        }

        public void ActualizarHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new();
            sb.Append(Sistema);
            sb.Append(": ");
            sb.Append(primerOperando.Valor);
            sb.Append(' ');
            sb.Append(operador);
            sb.Append(' ');
            sb.Append(segundoOperando.Valor);
            sb.Append('=');
            sb.Append(resultado.Valor);
            operaciones.Add(sb.ToString()); 
        }
    }
}