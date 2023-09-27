using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var ctx = new ordersEntities1();
            Console.WriteLine($"Creato contesto {ctx}");
            foreach (customer c in ctx.customers)
            {
                Console.WriteLine(c.customer1 + " " +c.country);
            }
            
            foreach (orderitem c in ctx.orderitems)
            {
                Console.WriteLine(c.orderid + " " + c.item + " " + c.qty);
            }
            

            foreach (order c in ctx.orders)
            {
                Console.WriteLine(c.orderid + " " + c.customer + " " + c.orderdate);
            }
            

            foreach (item c in ctx.items)
            {
                Console.WriteLine(c.item1 + " " + c.color);
            }
          

            foreach (utenti c in ctx.utentis)
            {
                Console.WriteLine(c.login + " " + c.password);
            }

            foreach (var cust in ctx.customers)
                if(cust.customer1 == "jack")
                {
                    Console.WriteLine($"aggiorno {cust.customer1}");
                    cust.country = "(m)";
                }
            

            
            //insert
            //var newC = new customer() { customer1 = "nuovo", country = "IT" };
            //ctx.customers.Add(newC);
            //ctx.SaveChanges();

            //delete
            //var newC2 = new customer() { customer1 = "nuovo", country = "IT" };
            //foreach(var cust in ctx.customers)
            //    if(cust.customer1 == "nuovo")
            //        ctx.customers.Remove(cust);
            //ctx.SaveChanges();
            
            Console.WriteLine("Inizio Esercizio");
            Console.WriteLine("1) creazione login");
            Console.WriteLine("2) lista degli ordini");
            Console.WriteLine("3) dettaglio degli ordini");
            Console.WriteLine("4) insert di un ordine");

            string scelta = Console.ReadLine();
            
            switch (scelta)
            {

                case "1":
                    var newU = new utenti() { login = "ciao", password = "123" };
                    ctx.utentis.Add(newU);
                    ctx.SaveChanges();
                    break;
                case "2":
                    Console.WriteLine("Lista degli ordini");
                    foreach (order c in ctx.orders)
                    {
                        Console.WriteLine(c.orderid + " " + c.customer + " " + c.orderdate);
                    }
                    break;
                case "3":
                    Console.WriteLine("Dettaglio degli ordini");
                    foreach (orderitem c in ctx.orderitems)
                    {
                        Console.WriteLine(c.orderid + " " + c.item + " " + c.qty + " " + c.price);
                    }
                    break;
                case "4":
                    Console.WriteLine("Insert di un ordine");
                    var newO = new orderitem() { orderid = 2, item = "IT", qty = 22, price = 33 };
                    ctx.orderitems.Add(newO);
                    ctx.SaveChanges();
                    break;
                default:
                    Console.WriteLine("Inserimento errato");
                    break;

                
            }

            //var newO = new orderitem() { orderid = 2, item = "IT", qty = 22, price = 33 };
            //ctx.orderitems.Add(newO);
            //ctx.SaveChanges();

            






        }
    }
}
