
namespace Actividad2
{
  public class Program {
    public static void Main(string[] args)
    {
      int num_de_estudiantes;
      double[][] notas;
      double[] promedios;

      Console.Write("[+] Ingrese el numero de estudiantes ");  
      string entrada = Console.ReadLine();
      
      if(!(int.TryParse(entrada, out num_de_estudiantes)) || num_de_estudiantes <= 0) {
        Console.Write("[+] Ingrese una cantidad de estudiantes valida.\n");  
        Main(args);
      } 

      string[] nombres = new string[num_de_estudiantes];
      notas = new double[num_de_estudiantes][];
      promedios = new double[num_de_estudiantes];

      // bucles para obtener datos
      for (int i = 0; i <= num_de_estudiantes - 1 ; i++){

        Console.Write($"[+] Ingrese el nombre del estudiante NO. {i + 1} ");  
        nombres[i] = Console.ReadLine();
        notas[i] = new double[4];

        for (int j = 0; j < 4; j++){

          Console.Write($"[+] Ingrese nota NO. {j + 1} de {nombres[i]} ");  
          notas[i][j] = double.Parse(Console.ReadLine());
          promedios[i] += notas[i][j];
        } 

          
      }

     // bucle para mostrar los datos 
      string estatus; 
      Console.Write($"Estudiante\tNota1\tNota2\tNota3\tNota4\tpromedio\testatus\n");  

      for (int i = 0; i <= notas.Length - 1; i++)
      {
        estatus = "Reprobado";

        if (promedios[i]/4 >= 70){
          estatus = "Aprobado";
        }
        Console.Write($"{nombres[i]}\t{notas[i][0]}\t{notas[i][1]}\t{notas[i][2]}\t{notas[i][3]}\t{promedios[i]/4}\t\t{estatus}\n");   
      }  

    }
  }
}
