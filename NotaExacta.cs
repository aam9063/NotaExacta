/*
Se pide una nota exacta. Si la nota es 5 se visualizará el texto APROBADO, Si la nota es 6 se
visualizará el texto BIEN, si la nota es 7 u 8 se visualizará el texto NOTABLE, si la nota es 9 o
10 se visualizará el texto SOBRESALIENTE, si la nota es 4 o menor se visualizará el texto
SUSPENSO, en otro caso visualizará el texto NOTA INCORRECTA.
Nota: Usaras la expresión switch de C#8 para conseguir la cadena de salida.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la nota:");
        int nota = Convert.ToInt32(Console.ReadLine());

        string resultado = ObtenerResultado(nota);
        Console.WriteLine(resultado);
    }

    static string ObtenerResultado(int nota)
    {
        switch (nota)
        {
            case 5:
                return "APROBADO";
            case 6:
                return "BIEN";
            case 7:
            case 8:
                return "NOTABLE";
            case 9:
            case 10:
                return "SOBRESALIENTE";
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                return "SUSPENSO";
            default:
                return "NOTA INCORRECTA";
        }
    }
}
