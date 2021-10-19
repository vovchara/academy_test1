using System;
using System.Collections;
using System.Collections.Generic;

namespace BusStation
{
    class Program
    {
        static void Main()
        {
            var gener = new GenerMeth();
            gener.Main();
            return;
            var account1 = new Account<int, int> { Sum = 5000 };
            var account2 = new Account<string, int> { Sum = 4000 };
            account1.Id = 2;
            account1.Age = 25;
            Account<int, int>.session = 100;

            account2.Id = "sadasd231";
            //account2.Age = "Sorok";
            account2.Age = 40;
            Account<string, int>.session = "dvisti";

            Console.WriteLine($"Acc 1 id = {account1.Id} and sum = {account1.Sum}. Age = {account1.Age}. Session = {Account<int, int>.session}");
            Console.WriteLine($"Acc 2 id = {account2.Id} and sum = {account2.Sum}. Age = {account2.Age}. Session = {Account<string, int>.session}");

            var myList = new List<int>();
            myList.Add(12);

            var arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add("qqq");
            arrayList.Add(2.3f);

            var accList = new List<Account<int, int>>();
            accList.Add(account1);
            //accList.Add(account2);

            //var old1 = new AccountOld();
            //AccountOld.session = 100;
            //var old2 = new AccountOld();
            //AccountOld.session = 200;
            //var old3 = new AccountOld();

        }
    }

    //class AccountOld
    //{
    //    public static int session;
    //    public int Id { get; set; }
    //    public int Sum { get; set; }
    //}

    class Account<Tvalue1, Tvalue2>
    {
        public static Tvalue1 session;

        public Tvalue1 Id { get; set; }
        public int Sum { get; set; }
        public Tvalue2 Age { get; set; }
    }

}
