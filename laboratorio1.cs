// Manejo de metodos
//
// Laboratirio 1 - Diferencia entre procedimiento y funciónamespace 
//
// Crear un procedimiento que solicite el nombre de un estudiante.
// muestre un mensaje presonalizado.
//
// Crear una funcion que solicite la base y la altura de un rectangulo y retorne el resultado.
//
// En el metodo main, pedir al usuario ingresar los datos correspondientes y llamanr dichos metodos 


namespace Lab1
{

  public class Laboratorio1 { 

    public static void Main(string[] arg) { 

      // nombre 
      Console.Write("Escribe lo que quieres hacer. n para -> nombre | a para -> area "); 
      string usrDesicion = Console.ReadLine();

      switch (usrDesicion)
      {
        case "n": 
          nombreDeEstudiante();
          break;
        case "a":
          double area = areaDeRectangulo();
          Console.Write("El area es: " + area + "m^2");  

          break;
        default:
          Console.Write("Opcion incorrecta"); 
          Main(arg);
          break;
      }
      

    }

    private static void nombreDeEstudiante() {

      Console.Write("Escribe tu nombre. "); 
      string nombre = Console.ReadLine();
      Console.Write("Gracias por escribir tu nombre " + nombre);  

    }

    private static double areaDeRectangulo() {
      Console.Write("Ingrese la base en metros. "); 
      double baseR = double.Parse(Console.ReadLine());

      Console.Write("Ingrese la altura en metros. "); 
      double altura = double.Parse(Console.ReadLine());

      return (baseR * altura);
    }
  }
}


