using System.Security.Cryptography.X509Certificates;

namespace PB305Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kvadrati: " + Kvadrat(b));
            

            //2
            
            int[] a = new int[5];
            Arr(1,2,3,4,5);
            

            //3 
            
            string name = " Hikmet  Abbasov ";
            RemoveSpace(name);
            

            //4
            
            int[] a = { 3, 4, 5 };
            AddNum(a);
            

            //5.1
            
            int a = Convert.ToInt32(Console.ReadLine());
            Num(a);
            

            //5.2
            
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            TekEded(n, m);
            

            //5.3
            
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            TekEdedCem(n, m);
            

            //5.4
            
            int n = Convert.ToInt32(Console.ReadLine());
            SadeMurekkeb(n);
            

            //5.5.
            
            Console.WriteLine(Arr(4,6,5,7,2,9,6,4,12));
            
        }

        //1.Verilmiş ədədi kvadratına yüksəldən metod.
        //(Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
        
        public static int Kvadrat(int a)
        {
            int sum = a * a;
            return sum;
        }
        

        //2.Verilmiş ədədlər siyahısını
        //içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod

         public static void Arr(params int[] arr)
         {

             for (int i = 0; i < arr.Length; i++)
             {
                 arr[i] = arr[i] * arr[i];
             }
             Console.WriteLine("Kvadrat array: ");
             foreach (var item in arr)
             {
                 Console.WriteLine(item);
             }

         }
        

        //3.Parametr olaraq 1 string dəyər qəbul edən və həmin string
        //dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal
        //olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız
        //varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər
        //"HikmətAbbasov" olmalıdır.
        public static void RemoveSpace (string name) {

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] != ' ')
            {
                Console.Write(name[i]);

            }
        }
        }
        

        //4.Parameter olaraq integer array variable-i ve bir integer value
        //qebul eden ve hemin integer value-nu integer array-e yeni element kimi
        //elave eden metod. Misal üçün int[] nums = {1,5,7} deyə bir variable-mız
        //var.yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums
        //arrayının dəyəri  {1,5,7,3} olmalıdır.
        public static void AddNum(int[] a)
        {
            int b = 6;

            int[] c = new int[a.Length + 1];

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            c[c.Length - 1] = b;

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
       


        //5.1. Verilmiş n ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        public static void Num(int a)
        {
            if (a % 3 == 0 && a % 7 == 0)
            {
                Console.WriteLine("3 ve 7-ye bolunur");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("3-e bolunur");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("7-e bolunur");
            }
            else
            {
                Console.WriteLine("Heç birinə bölünmür");
            }

        }
      

        //5.2. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

        public static void TekEded(int n, int m)
        {
            int count = 0; 
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Tek ededlerin sayi: " + count);
        }
   

        //5.3. Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin
        public static void TekEdedCem(int n, int m)
        {
            int count = 0;
            int cem = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                    cem += i;

                }
            }
            Console.WriteLine("Tek ededlerin cemi: " + cem);
        }
       

        //5.4. Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
        public static void SadeMurekkeb(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("Sade ve ya murekkeb deyil");
            }
            else if ( n%2==0 || n %3==0 || n%5==0 || n%7==0 )
            {
                Console.WriteLine("Murekkeb ededdir");
            }
            else
            {
                Console.WriteLine("Sade ededdir");
            }
        }
      

        //5.5. Verilmish arrayin icindeki cut ededlerin cemini tapin.
        public static int Arr( params int[] n)
        {
            int cem = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    cem += n[i];
                }
            }
            return cem;
        }
  
    }
}




