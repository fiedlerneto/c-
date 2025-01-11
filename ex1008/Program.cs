using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

     int numero = int.Parse(Console.ReadLine());
      int horas = int.Parse(Console.ReadLine());
       double salary = double.Parse(Console.ReadLine());
       
       double salario = horas * salary;
       
       Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " +salario.ToString("F2", CultureInfo.InvariantCulture));

    }

} 