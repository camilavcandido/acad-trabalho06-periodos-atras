using System;

namespace PeriodosAtras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Data data = new Data();

            Console.WriteLine("Informe uma data: ");
            data.dataInformada = DateTime.Parse(Console.ReadLine());
            TimeSpan timeSpanNumeroDias = data.dataAtual.Subtract(data.dataInformada);
            int numeroDias = timeSpanNumeroDias.Days;

            int contadorAnos = 0, contadorMeses = 0, contadorSemanas = 0, contadorDias = 0;
            string resultado = "";


            if (numeroDias == 0)
            {
                Console.WriteLine("Horas: " + timeSpanNumeroDias.Hours);
                Console.WriteLine("Minutos: " + timeSpanNumeroDias.Minutes);
                Console.WriteLine("Segundos: " + timeSpanNumeroDias.Seconds);
            }
            else
            {


                while (numeroDias > 0)
                {
                    if (numeroDias > 365)
                    {
                        contadorAnos++;
                        numeroDias = numeroDias - 365;
                    }
                    else if (numeroDias > 30)
                    {
                        contadorMeses++;
                        numeroDias = numeroDias - 30;
                    }
                    else if (numeroDias > 7)
                    {
                        contadorSemanas++;
                        numeroDias = numeroDias - 7;
                    }
                    else if (numeroDias > 0)
                    {
                        contadorDias++;
                        numeroDias = numeroDias - 1;
                    }
                }

                //saida
                if (contadorAnos > 0)
                {
                    resultado = numeroPorExtenso(contadorAnos) + " anos atrás";
                    if (contadorMeses > 0)
                    {
                        resultado = numeroPorExtenso(contadorAnos) + " anos e " + numeroPorExtenso(contadorMeses) + " mes(es) atrás";
                    }

                }
                else if (contadorMeses > 0)
                {
                    resultado = numeroPorExtenso(contadorMeses) + " mes(es) atrás";
                    if (contadorSemanas > 0)
                    {
                        resultado = numeroPorExtenso(contadorMeses) + " mes(es) e " + numeroPorExtenso(contadorSemanas) + " semana(s) atrás";
                    }

                }
                else if (contadorSemanas > 0)
                {
                    resultado = numeroPorExtenso(contadorSemanas) + " semana(s) atrás";
                    if (contadorSemanas > 0)
                    {
                        resultado = numeroPorExtenso(contadorSemanas) + " semana(s) e " + numeroPorExtenso(numeroDias) +
                            " dia(s) atrás";
                    }

                }
                else if (contadorDias > 0)
                {
                    resultado = numeroPorExtenso(contadorDias) + " dia(s) atrás";

                }
                Console.WriteLine(resultado);

            }

            static string numeroPorExtenso(int contador)
            {
                string numero = null;

                switch (contador)
                {
                    case 1:
                        numero = "um";
                        break;

                    case 2:
                        numero = "dois";
                        break;

                    case 3:
                        numero = "três";
                        break;

                    case 4:
                        numero = "quatro";
                        break;

                    case 5:
                        numero = "cinco";
                        break;

                    case 6:
                        numero = "seis";
                        break;

                    case 7:
                        numero = "sete";
                        break;

                    case 8:
                        numero = "oito";
                        break;

                    case 9:
                        numero = "nove";
                        break;

                    case 10:
                        numero = "dez";
                        break;
                }

                return numero;

            }

        }
    }
}
