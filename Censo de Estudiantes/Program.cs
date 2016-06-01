using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censo_de_Estudiantes
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        

        struct Student
        {
            public int studentid;
            public string studentname;
            public string sex;
            public double age;
        };
        
        static Student[] Students;
        static void AddStudents()
        {
            String sex = "";
            int Mujer = 0;
            int Hombre = 0;
            int age = 0;
            int menores = 0;
            int jovenes = 0;
            int adultos = 0;
            int r = 0;
            while (r != 2)
            {
                Console.Clear();
                if (i < Students.Length)
                {
                    Console.WriteLine("*-* Ingreso de informacion de estudiantes de la UH  *-*");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.Write("Digite el ID del estudiante:                  ");
                    Students[i].studentid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante    ");
                    Students[i].studentname = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante: M = Masculino, F = Femenino   ");
                    Students[i].sex = Console.ReadLine();
                    if (sex == "M")
                    {
                        Hombre++;
                    }
                    else if (sex == "F")
                    {
                        Mujer++;
                    }
                    else
                    {
                        Console.WriteLine("Debe digitar M o F para introducir el sexo del estudiante");
                    }
                    Console.WriteLine("Digite la edad del estudiante:");
                    Students[i].age = int.Parse(Console.ReadLine());
                    if (age < 18)
                    {
                        menores++;
                    }else if(age > 19 && age < 29 ){
                        jovenes++;
                    }
                    else
                    {
                        adultos++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Desea agregar otro Estudiante 1-Sí 2-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("**********Registro de Estudiantes lleno.**************");
                    r = 2;
                    Console.ReadKey();
                }
            }

        }
        static void ModifyStudents()
        {
            int r = 0;
            while (r != 2)
            {
                Console.Clear();
                if (i < Students.Length)
                {
                    Console.WriteLine("*-* Modificacion de informacion de estudiantes de la UH  *-*");
                    Console.WriteLine();
                    Console.Write("Digite el ID del estudiante:                  ");
                    Students[i].studentid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante a modificar   ");
                    Students[i].studentname = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante a modificar:     ");
                    Students[i].sex = Console.ReadLine();
                    Console.WriteLine("Digite la edad del estudiante a modificar:");
                    Students[i].age = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Desea modificar otro Estudiante 1-Sí 2-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("**********Registro de Estudiantes lleno.**************");
                    r = 2;
                    Console.ReadKey();
                }
            }

        }
        static void EraseStudents()
    {
        int r = 0;
        while (r != 2)
        {
            Console.Clear();
            Console.WriteLine("Xxxxxxx Borrado de informacion de estudiantes de la UH  xxxxxxX");
            Console.WriteLine();
            Console.Write("Digite el ID del estudiante al cual desea borrar de la base de datos:                  ");
            Students[i].studentid = int.Parse(Console.ReadLine());
           
            Console.WriteLine();
            Console.WriteLine("Desea modificar otro Estudiante 1-Sí 2-No");
            r = int.Parse(Console.ReadLine());
        }

    }
        static void SeekStudents()
        {
            
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Censo Estudiantil UH *-*");
                Console.WriteLine("Búsquedad de Estudiantes.           ");
                Console.WriteLine("Digite el ID del estudiante a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (ID == Students[i].studentid)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + Students[i].studentid);
                        Console.WriteLine("Nombre:   " + Students[i].studentname);
                        Console.WriteLine("Sexo:     " + Students[i].sex);
                        Console.WriteLine("Edad:   " + Students[i].age);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void listOfStudents()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("*-* Censo Estudiantil UH  *-*");
            Console.WriteLine("Informe.             ");
            for (i = 0; i < Students.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("======================================");
                Console.WriteLine("          Listado Estudiantil         ");
                Console.WriteLine("======================================");
                Console.WriteLine("Universidad UH                        ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Reg  Codigo Nombre         Sexo   Edad");
                Console.WriteLine(reg);
                Console.WriteLine("ID:       " + Students[i].studentid);
                Console.WriteLine("Nombre:   " + Students[i].studentname);
                Console.WriteLine("Sexo:     " + Students[i].sex);
                Console.WriteLine("Edad:   " + Students[i].age);
                Console.WriteLine("======================================");
                Console.WriteLine("Fin de informe");
            }
            Console.ReadKey();
        }
        static void reportOfStudents()
        {
           
             int Mujer = 0;
            int Hombre = 0;
            int age = 0;
            int menores = 0;
            int jovenes = 0;
            int adultos = 0;
            
            Console.WriteLine("========================================================");
            Console.WriteLine("        Informe clasificacion Estudiantil UH            ");
            Console.WriteLine("========================================================");
            Console.WriteLine("  Clasificacion por edad  ||  Clasificacion por sexo    ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Menores de Edad: "+menores+"||      Hombres "+Hombre     );
            Console.WriteLine("Jovenes: "+jovenes+        "||      Mujeres "+Mujer      );
            Console.WriteLine("Adultos: "+adultos                                       );
            Console.WriteLine("========================================================");
            Console.WriteLine("Fin de informe");
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("*-*  Menu Principal  *-*");
                Console.WriteLine("1. Ingreso de Estudiantes.");
                Console.WriteLine("2. Modificación de Estudiantes.");
                Console.WriteLine("3. Borrado de estudiantes.");
                Console.WriteLine("4. Búsquedad de Estudiantes.");
                Console.WriteLine("5. Listado de Estudiantes.");
                Console.WriteLine("6. Informe clasificacion de estudiantes.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddStudents();
                            break;
                        }
                    case 2:
                        {
                            ModifyStudents();
                            break;
                        }
                    case 3:
                        {
                            EraseStudents();
                            break;
                        }
                    case 4:
                        {
                            SeekStudents();
                            break;
                        }
                    case 5:
                        {
                            listOfStudents();
                            break;
                        }
                    case 6:
                        {
                            reportOfStudents();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}
