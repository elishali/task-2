namespace ConsoleApptask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ci sual
            //verilmish 4 reqemli ededin reqemlerinin cemini tap

            /*Console.WriteLine("4 reqemli eded daxil edin:");
             
             int n;
             int sum;
             int k;
             n=
                int.Parse(Console.ReadLine());

             sum = 0;

             while (n > 0)
             {
                k = n % 10;

                n = n / 10;

                 sum = sum + k;
             }
             Console.WriteLine(sum);*/

            //2 ci sual
            //verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap:

            /*Console.WriteLine("6 reqemli eded daxil edin:");
             
             int n;

             int sum;

             int k;

             n  = int.Parse(Console.ReadLine());

             n = n / 1000;

             sum = 0;

             while (n > 0)
             {
                 k = n % 10;

                 n = n / 10;

                 sum = sum + k;              
             }
             Console.WriteLine(sum);*/

            //3 cu sual
            // verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi

            /* Console.WriteLine("9 reqemli eded daxil edin:");
             * 
             int n;

              int sum;

              int k;

              n = int.Parse(Console.ReadLine());

              n = (n / 1000)%1000;

              sum = 0;

             while (n > 0)
              {
                  k = n % 10;

                  n = n / 10;

                  sum = sum + k;
              }
             Console.WriteLine(sum);*/

            //4 cu sual
            //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati

            /* Console.WriteLine("5 reqemli eded daxil edin:");
             * 
             int n, a,b,c,d;

             n = int.Parse(Console.ReadLine());

             a = n % 10;
             b = n / 10000;
             c = (a + b);
             d = c * c;

             Console.WriteLine(d);*/

            //5 ci sual
            // verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.

            /*Console.WriteLine("6 reqemi eded daxil edin");
            
            int n, a, b;
         
            n = int.Parse(Console.ReadLine());

            a = n / 100000;

            b = (n * 10) + a;

            Console.WriteLine(b);*/

            //6 ci sual
            // verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et

            /*Console.WriteLine("8 reqemli eded daxil edin:");

            int n,a,b;

            n = int.Parse(Console.ReadLine());

            a = (n / 10)%1000000 ;

            Console.WriteLine(a);*/


            //7 ci sual
            /* Console.WriteLine("verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir");
             Console.WriteLine("4 reqemli eded daxil edin:");

             int n;

             n = int.Parse(Console.ReadLine());

             int a;

             int newn = 0;

             int n2;

             while (n > 0)
             {
                 a = n % 10;

                 newn = newn * 10 + a;

                 n = n / 10;

             }
             Console.WriteLine(newn);

             n2 = newn;

             n2 = (n2 * 10) + 800008;

             Console.WriteLine(n2);*/


            //8 ci sual
            //Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap

            /* Console.WriteLine("Istenilen ededi daxil edin:");

             long num;

             num = long.Parse(Console.ReadLine());

             long a, b, c;

             Console.WriteLine(num);

             a = (num / 100) % 10;

             b = (num % 10);

             c = (a + b);

             Console.WriteLine($"{a} + {b} = {c}");*/


            //9 cu sual
            // 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439

            /* Console.WriteLine("9 reqemli eded daxil edin:");

             int n;
             n = int.Parse(Console.ReadLine());
             int nson = 0;
             int nters = 0;

             while (n > 0)
             {
                 nson = n % 10;
                 nters = nters * 10 + nson;
                 n = n / 10;
             }
             Console.WriteLine(nters);
             int nterstek = 0;
             int nnew = 0;
             while (nters > 0)
             {
                 nterstek = nters % 10;
                 nters = nters / 100;
                 nnew = nnew * 10 + nterstek;
             }
             Console.WriteLine(nnew);*/

            //10 cu sual
            /*9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            sonra cut yerde dayanlarinda bir eded duzlet,
            sonra onlari topla*/
            Console.WriteLine("9 reqemli eded daxil edin:");
            int n;
            n = int.Parse(Console.ReadLine());
            int nson = 0;
            int nters = 0;

            while (n > 0)
            {
                nson = n % 10;
                nters = nters * 10 + nson;
                n = n / 10;
            }
            Console.WriteLine(nters);
            int nterstek = 0;
            int nterscut = 0;
            int nnewtek = 0;
            int nnewcut = 0;
            while (nters > 0)
            {
                nterstek = nters % 10;
                nterscut = (nters / 10) % 10;
                nters = nters / 100;
                nnewtek = (nnewtek * 10) + nterstek;
                nnewcut = (nnewcut * 10) + nterscut;
            }
            int sum = nnewcut + nnewtek;
            Console.WriteLine(nnewtek);
            Console.WriteLine(nnewcut);
            Console.WriteLine($"{sum}");
        }
    }
}