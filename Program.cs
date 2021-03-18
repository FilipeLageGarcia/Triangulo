using System; 
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0], CultureInfo.InvariantCulture);
            b = Convert.ToDouble(valor[1], CultureInfo.InvariantCulture);
            c = Convert.ToDouble(valor[2], CultureInfo.InvariantCulture);

            if(( a % b !=0  ) && ( b % c != 0 ) && ( c % a != 0)) //complete a condicional
            {
                Console.WriteLine("Perimetro = {0:0.0}", a+b+c); //complete a saida
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}", (a+b/2*c)  ); //complete a saida
            }

    }

}