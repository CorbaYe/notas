using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holaMundo
{
    internal class ClasePrincipal
    {
        static int fila = 0;
        static float def = 0;
        static String[,] notas = new String[100,5];

        public static void Main(String[] args)
        {
            fntMenu(true);
        }
        private static void fntGuardarNotas(String nombre, double n1, double n2, double n3)
        {
            double pN1 = n1 * 0.30D;
            double pN2 = n2 * 0.30D;
            double pN3 = n3 * 0.40D;
            notas[fila,0] = "Estudiante: " + nombre;
            notas[fila,1] = "Nota 1 (30%): " + n1 + " en porcentaje: " + pN1;
            notas[fila,2] = "Nota 2 (30%): " + n2 + " en porcentaje: " + pN2;
            notas[fila,3] = "Nota 3 (40%): " + n3 + " en porcentaje: " + pN3;
            notas[fila,4] = "Nota definitiva: " + (pN1 + pN2 + pN3);
            fila++;
            Console.WriteLine("\nNotas registradas con éxito");
            fntLimpiar();
        }
        private static void fntLimpiar()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void fntMenu(bool menu)
        {
            int m = 0;
            do
            {
                Console.WriteLine("<< Menú principal >>\n 1. Guardar notas\n 2. Mostrar notas\n 3. Salir");
                var opcion = Console.ReadLine();
                if (opcion != null)
                {
                    try
                    {
                        m = Convert.ToInt32(opcion);
                    }
                    catch (FormatException ex)
                    {
                        Console.Write("\nNo se puede convertir un caracter a entero <ENTER>...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    switch (m)
                    {
                        case 1:
                            Console.Write("\nNombre del estudiante: ");
                            var n = Console.ReadLine();
                            Console.Write("Nota 1: ");
                            var nota1 = Console.ReadLine();
                            Console.Write("Nota 2: ");
                            var nota2 = Console.ReadLine();
                            Console.Write("Nota 3: ");
                            var nota3 = Console.ReadLine();
                            if (n != "" && nota1 != "" && nota2 != "" && nota3 != "")
                            {
                                try
                                {
                                    double n1 = Convert.ToDouble(nota1);
                                    double n2 = Convert.ToDouble(nota2);
                                    double n3 = Convert.ToDouble(nota3);
                                    fntGuardarNotas(n, n1, n2, n3);
                                }
                                catch (FormatException ex)
                                {
                                    Console.Write("\nNotas no validas <ENTER>...");
                                    fntLimpiar();
                                }
                            }else
                            {
                                Console.Write("\nDebe ingresar todos los campos <ENTER>...");
                                fntLimpiar();
                            }
                            break;

                        case 2:
                            Console.WriteLine("Guardar");
                            break;
                        case 3:
                            menu = false;
                            break;
                        default: Console.WriteLine("Opción no valida.");
                            break;
                    }
                } 
            } while (menu);
        }   
    }
}
