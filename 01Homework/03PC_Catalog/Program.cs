using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Component ram = new Component("RAM 32GB", 65.5m, "Good for programmers");
            Component hdd = new Component("HDD 850GB", 50.5m, "You can store a lot of data");
            Component motherboard = new Component("Thunderboard 15304", 120m, "Good motherboard");
            Component[] assembly = { ram, hdd, motherboard };


            Component ram1 = new Component("RAM 16GB", 20.5m, "Good for programmers too");
            Component hdd1 = new Component("HDD 500GB", 40.5m, "Enough is enough");
            Component motherboard1 = new Component("Thunderboard 11301", 85m, "Intermediate motherboard");
            Component[] assembly1 = { ram1, hdd1, motherboard1 };


            Component ram2 = new Component("RAM 8GB", 10.5m, "A little bit of ram pls");
            Component hdd2 = new Component("HDD 100GB", 20.5m, "You call this HDD?");
            Component motherboard2 = new Component("Thunderboard 10301", 45m, "Lousy Motherboard");
            Component[] assembly2 = { ram2, hdd2, motherboard2 };

            Computer computer = new Computer("Lightning computer", assembly);
            Computer computer1 = new Computer("Lightning computer", assembly1);
            Computer computer2 = new Computer("Lightning computer", assembly2);

            List<Computer> computers = new List<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer);

            List<Computer> sortedList = computers.OrderBy(o => o.Price).ToList();
            foreach (var item in sortedList)
            {
                item.PrintComp();
            }
        }
        
    }
}
