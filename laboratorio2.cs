 

namespace Lab2
{

  public class Laboratorio2 { 

    public static void Main(string[] arg) { 

      // notas 
      double[] notas = new double[4];
      Console.Write("Por escriba las 4 calificaciones\n"); 
      Console.Write("Calficación 1:\n"); 
      notas[0] = double.Parse(Console.ReadLine());
      Console.Write("Calficación 2:\n"); 
      notas[1] = double.Parse(Console.ReadLine());
      Console.Write("Calficación 3:\n"); 
      notas[2] = double.Parse(Console.ReadLine());
      Console.Write("Calficación 4:\n"); 
      notas[3] = double.Parse(Console.ReadLine());

      double promedio = calculaPromedio(notas);
      string resultado = promedio >= 70 ?  "Aprovado" : "Reprobado"; 

      Console.Write("El promedio es de: " + promedio + " " + resultado); 
    }

    
    private static double calculaPromedio(double[] notas) {


      double sum = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

      return sum;
    }
  }
}


