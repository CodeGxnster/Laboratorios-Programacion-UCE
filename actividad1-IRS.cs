

// Descripción
// Crear un programa que lea el sueldo de un empleado, calcule el ISR (Impuesto Sobre la
// Renta) y muestre en pantalla el resultado, de acuerdo con una escala salarial disponible
// en la plataforma de la DGII. Para realizar el cálculo, debe investigar cómo se realiza
// para este país y en base a este año. El resultado debe ser el sueldo y cuanto debe pagar
// por el ISR, si no aplica, colocar N/A

namespace Actividad1
{
  public class Program {
    public static void Main(string[] args)
    {
      double sueldo, ISR, sueldo_bruto, sueldo_anual;

      Console.Write("[+] Ingrese su sueldo (mensual) ");  
      string entrada = Console.ReadLine(); 

      double ISR_minimo = 416220;
      double ISR_15_por_ciento_max = 624329;
      double ISR_20_por_ciento_max = 867123;

      if(!(double.TryParse(entrada, out sueldo_bruto)) || sueldo_bruto <= 0) {
        Console.Write("[+] Ingrese una cantidad valida.\n");  
        Main(args);

      } 

      sueldo = sueldo_bruto - (sueldo_bruto * 0.0591); // 5.91% ---> AFP% + ARS% 
      sueldo_anual = sueldo * 12;

      if (sueldo_anual < ISR_minimo)
      {
        Console.Write("N/A");  
        return;
      } 

      if(sueldo_anual >= ISR_20_por_ciento_max) {

        double excedente = sueldo_anual - (ISR_20_por_ciento_max);
        ISR = (79776.00 + (excedente * 0.25))/12;

      }
      else if (sueldo_anual > ISR_15_por_ciento_max)
      {
        double excedente = sueldo_anual - (ISR_15_por_ciento_max);
        ISR = (31216.00 + (excedente * 0.20))/12;
      }
      else {
        double excedente = sueldo_anual - (ISR_minimo);
        ISR = (excedente * 0.15)/12;
      }

      Console.Write($"[+] Tu sueldo es de: {sueldo} con un ISR de {ISR}");
    }
  }
}
