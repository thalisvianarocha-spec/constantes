namespace constantes
{
    
    
        internal class Program
        {
            static void Main(string[] args)
            {
                // Constante: o valor nunca muda
                const double Pi = 3.14;

                // Variável: o valor pode mudar
                double raio = 5;

                double area = Pi * raio * raio;

                Console.WriteLine("O valor de Pi é: " + Pi);
                Console.WriteLine("A área do círculo é: " + area);

                // Pi = 3.5;  // ERRO! Uma constante não pode ser alterada
            }
        }
    }