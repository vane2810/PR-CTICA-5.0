using System;
using System.Collections;

namespace PRÁCTICA_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repit = true;
            do
            {
                int numberStudents;
                string firstname, lastname;
                double grade1, grade2, grade3;
                ArrayList list = new ArrayList();

                Console.WriteLine("Ingrese el número de estudiantes: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < numberStudents; i++)
                {
                    Console.Write("Nombre: ");
                    firstname = Console.ReadLine();
                    Console.Write("Apellido: ");
                    lastname = Console.ReadLine();
                    Console.Write("Primer nota : ");
                    grade1 = double.Parse(Console.ReadLine());
                    Console.Write("Segunda nota : ");
                    grade2 = double.Parse(Console.ReadLine());
                    Console.Write("Tercera nota : ");
                    grade3 = double.Parse(Console.ReadLine());

                    list.Add(new Students(firstname, lastname, grade1, grade2, grade3));
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("");
                }

                foreach (Students st in list)
                {
                    Console.WriteLine("  " + st.ReturnInfo());
                    double prom = st.ReturnGrades();
                    Console.WriteLine("Su promedio de notas es : {0}", prom);
                    Console.WriteLine(prom >= 6.0 ? "Aprobado" : "Reprobado");
                }
                Console.WriteLine();

                bool question;
                do
                {
                    Console.WriteLine("Si desea finalizar el programa escriba 'S' de lo contrario escriba 'N' ");
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "S":
                        case "s":
                            repit = false;
                            question = false;
                            break;
                        case "N":
                        case "n":
                            repit = true;
                            question = false;
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            question = true;
                            break;
                    }
                }
                while (question);

            }
            while (repit);
            Console.WriteLine("Programa finalizado");
        }
    }
  
}
