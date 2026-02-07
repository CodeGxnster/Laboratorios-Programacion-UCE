namespace Lab3
{
  public class Laboratorio3 { 

    public static void Main(string[] arg) { 

      Console.Write("Escriba:\ns -> para sumar\nr -> para restar\nm -> para multiplicar\nd -> para dividir\n"); 
      string opcionDelUsuario = Console.ReadLine();
      
      double[] nums = new double[2];

      Console.Write("Escriba el primer numero "); 
      nums[0] = double.Parse(Console.ReadLine());

      Console.Write("Escriba el segundo numero "); 
      nums[1] = double.Parse(Console.ReadLine());

      switch (opcionDelUsuario[0])
      {
        case 's':
          double suma = sumar(nums);
          Console.Write("El resultado es: " + suma); 
          break;
        case 'r':
          double resta = restar(nums);
          Console.Write("El resultado es: " + resta); 
          break;
        case 'm':
          double multi = multiplicar(nums);
          Console.Write("El resultado es: " + multi); 
          break;
        case 'd':
          if (nums[1] != 0) {
            double divicion = dividir(nums);
            Console.Write("El resultado es: " + divicion); 
          } else {

            Console.Write("No se puede dividir por 0"); 
          }
          break;
        default:
          Console.Write(opcionDelUsuario + " Opción incorrecta"); 
          Main(arg);
          break;
      }
    
    }
    private static double sumar(double[] nums) {
      return  nums[0] + nums[1];
    }
    private static double restar(double[] nums) {
      return  nums[0] - nums[1];
    }
    private static double multiplicar(double[] nums) {
      return  nums[0] * nums[1];
    }
    private static double dividir(double[] nums) {
      return  nums[0] / nums[1];
    }
  } 
}
