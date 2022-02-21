using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    internal class Program
    {
     static Random rnd = new Random();

        static void Main(string[] args)
        {
            int guess;
            int minNumber = 0;
            int maxNumber = 100;
            int number = rnd.Next(minNumber, maxNumber);


            for (int i = 5; i >= 0; i--)
            {
               
                    if (i==0)
                    {
                        Console.WriteLine("Kaybettiniz. Doğru cevap : {0}", number);
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("{0}. HAK : {1} ile {2} arasında bir sayı giriniz :",i, minNumber, maxNumber);
                    guess = Convert.ToInt32(Console.ReadLine());

                if (guess <= minNumber || guess >= maxNumber)
                {
                    Console.WriteLine("Belirtilen aralıklarda sayı girişi yapınız");
                    i++;
                }
                else
                {

                    if (guess > number)
                    { maxNumber = guess; }
                    else if (guess < number)
                    { minNumber = guess; }
                    else
                    {
                        Console.WriteLine("Tebrikler doğru cevap");
                        Console.ReadLine();
                        break;
                    }
                }

            }

        }

    }
}
