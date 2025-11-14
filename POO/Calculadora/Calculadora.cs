namespace Calculadora;

    public class Calculator
    {


    public double Numero1;

        public double Numero2;

        public double Resultado;

        //métodos 

        public double Somar()
        {
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"Resultado da soma: {Resultado}");
            return Resultado;
        }

        public double Subtrair()
        {
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"Resultado da Subtração {Resultado}");
            return Resultado;
        }

        public double Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"Resultado da Multiplicação {Resultado}");
            return Resultado;

        }
    
    
        public double Dividr()
    {
        if (Numero2 == 0)
        {
            Console.WriteLine($"divisão por zero");
            return -1;
        }
            Resultado = Numero1 / Numero2;
            return Resultado;

        }

    }


