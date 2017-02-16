using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseH
{
    class exeh1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");

            string s1 = Console.ReadLine();
            s1=s1.ToUpper();
           

            Console.Write("Enter a word :");

            string s2 = Console.ReadLine();
            s2=s2.ToUpper();

            bool eql = InString(s1, s2);

            if (eql)
            {
                Console.WriteLine("True");
            }
            else
            {

                Console.WriteLine("False");

            }

        }

        public static bool InString(string s1, string s2)
        {
            bool eql = false;



            

            for (int i = 0; i <= s1.Length-s2.Length; i++)
            {
                string a = s1.Substring(i, s2.Length);
                
                
                if (a == s2)
                {
                    eql = true;
                    break;
                }
            }


            return eql;



        }

    }
}
