using System;

namespace iflab5_6
{
    class Program
    {
        public struct customer
        {
            public string first;
            public string last;
            public int age;
            public bool member;

        }



        static void Main(string[] args)
        {


            customer cus1 = new customer();

            customer cus2 = new customer();
            customer cus3 = new customer();

            cus1.age = 12;
            cus1.first = "tom";
            cus1.last = "tipi";
            cus1.member = false;

            cus2.age = 22;
            cus2.first = "patty";
            cus2.last = "pat";
            cus2.member = false;

            cus3.age = 50;
            cus3.first = "mr.";
            cus3.last = "sandman";
            cus3.member = true;

            customer[] cusray = { cus1, cus2, cus3 };
            for (int i = 0; i< cusray.Length; i++)
            {
                if (cusray[i].age < 21)
                {
                    Console.WriteLine("DENIED");
                }

               else
                {
                    Console.WriteLine("WELCOME" + cusray[i].first + "PAYMENT REQUIRED");
                }

                if (cusray[i].member == true)
                {
                    Console.WriteLine(cusray[i].first+"YOU QUALIFY FOR FREE BOTTLE! THANK YOU FOR BEING APART OF THE WORLD OF BEER FAMILY");

                }

                else
                {
                    Console.WriteLine("HELLO" + cusray[i].first);
                }

            }








            
              


            Console.WriteLine("Hello World!");
        }
    }
}
