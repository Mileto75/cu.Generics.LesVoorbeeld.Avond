using System;
using System.Collections.Generic;
using System.Linq;
using cu.Generics.Avond.Core.Entities;
using cu.Generics.Avond.Core.Generics;

namespace cu.Generics.Avond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<int> ordersInt = new Order<int>
            {
                Item = 1,
                Quantity = 5,
            };
            Console.WriteLine(ordersInt.Item);
            Order<string> orderString = new Order<string>
            {
                Item = "MyString",
                Quantity = 5
            };
            Console.WriteLine(orderString.Item);
            //complex types
            Order<Television> orderTelevision = new Order<Television>
            {
                Item = new Television { Id = 1,Name="Sony"}
            };
            Console.WriteLine(orderTelevision.Item);
            //generic repositories
            Repository<int> repositoryInt = new Repository<int>();
            Repository<string> repositoryStrings = new Repository<string>();
            //add some stuff
            repositoryInt.Add(1);
            repositoryInt.Add(2);
            repositoryInt.Add(3);
            repositoryStrings.Add("one");
            repositoryStrings.Add("Two");
            repositoryStrings.Add("Three");
            //show output
            foreach (var item in repositoryInt.GetAll())
            {
                Console.WriteLine(item);
            }
            foreach (var item in repositoryStrings.GetAll())
            {
                Console.WriteLine(item);
            }
            //with complex types
            Repository<Television> repositoryTelevisions = new Repository<Television>();
            repositoryTelevisions.Add(new Television { Id = 1, Name = "Sony" });
            repositoryTelevisions.Add(new Television { Id = 2, Name = "LG" });
            repositoryTelevisions.Add(new Television { Id = 3, Name = "Samsung" });
            PrintRepository(repositoryTelevisions);
            PrintRepository(repositoryInt);
            PrintRepository(repositoryStrings);
            foreach (var item in repositoryTelevisions.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintRepository<T>(IRepository<T> repository)
        {
            foreach (var item in repository.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
