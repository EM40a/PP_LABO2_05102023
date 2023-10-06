using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public Calculadora(string nombreAlumno)
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
                resultado = value;
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
            if (this.primerOperando != this.segundoOperando)
            {
                this.resultado =  new SistemaDecimal(double.MinValue.ToString());
            }

            Calcular('+');
        }

        public void Calcular(char operador)
        {
            double resultado;
            switch (operador)
            {
                case '+':
                    resultado = primerOperando.ValorNumerico + segundoOperando.ValorNumerico;
                    break;
                case '-':
                    resultado = primerOperando.ValorNumerico - segundoOperando.ValorNumerico;
                    break;
                case '*':
                    resultado = primerOperando.ValorNumerico * segundoOperando.ValorNumerico;
                    break;
                case '/':
                    resultado = primerOperando.ValorNumerico / segundoOperando.ValorNumerico;
                    break;
                default:
                    resultado = double.MinValue;
                    break;
            }
            MapeaResultado(resultado);
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            if (sistema == ESistema.Binario)
            {
                return new SistemaBinario(valor.ToString());
            }
            else 
            {
                return new SistemaDecimal(valor.ToString());
            }
        }

        public void ActualizarHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new ();
            sb.Append(Sistema);
            sb.Append(" - ");
            sb.Append(PrimerOperando);
            sb.Append(operador);
            sb.Append(SegundoOperando);
            sb.Append(" = ");
            sb.Append(Resultado);
            
            operaciones.Add(sb.ToString());
        }
    }
}