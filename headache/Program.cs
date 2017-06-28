using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int ageOfPerson = int.Parse(Console.ReadLine());
            if (ageOfPerson >= 0 && ageOfPerson <= 2)
            {
                Console.WriteLine("Still in mama's arms");
            }
            else if (ageOfPerson >= 3 && ageOfPerson <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (ageOfPerson >= 5 && ageOfPerson <= 11)
            {
                Console.WriteLine("Elementery School");
            }
            else if (ageOfPerson >= 12 && ageOfPerson <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (ageOfPerson >= 15 && ageOfPerson <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (ageOfPerson >= 19 && ageOfPerson <= 22)
            {
                Console.WriteLine("College");
            }
            else if (ageOfPerson >= 23 && ageOfPerson <= 65)
            {
                Console.WriteLine("Fucked");
            }
            else if (ageOfPerson >= 66 && ageOfPerson <= 100)
            {
                Console.WriteLine("Dead from drinking to much");
            }
            else Console.WriteLine("This is for HuMaNs!!!");

        }
        }
    }

