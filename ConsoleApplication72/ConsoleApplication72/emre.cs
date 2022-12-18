using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication72
{
    class emre
    {
        private const int ADET = 3;
        private int[] notlar = new int[ADET];
        private string[] isimler = new string[ADET];
        private void bilgi_al()
         {
             for (int i = 0; i < ADET; i++)
             {
                 Console.WriteLine("Lütfen {0} nıncı öğrencinin adını giriniz:", i + 1);
                 isimler[i] = Console.ReadLine();
                 Console.WriteLine("Lütfen {0} nıncı öğrencinin notunu giriniz:", i + 1);
                 notlar[i] = Convert.ToInt32( Console.ReadLine());
             }     

         }
        public void islem()
        {
            bilgi_al();
            int eb1 = -1, eb2 = -2;
            string sb1 = null, sb2 = null;
            for (int i = 0; i < ADET; i++)
            {
                if (notlar[i] > eb1)
                {
                    eb2 = eb1;
                    sb2 = sb1;
                    eb1 = notlar[i];
                    sb1 = isimler[i];
                }
                else if (notlar[i] > eb2)
                {
                    eb2 = notlar[i];
                    sb2 = isimler[i];
                }
                    
            }//for sonu

            Console.WriteLine("{0} notu ile {1} isimli öğrenci 1. dir",eb1,sb1);
            Console.WriteLine("{0} notu ile {1} isimli öğrenci 2. dir", eb2, sb2);

            Console.ReadKey();
        }
        

    }
}
