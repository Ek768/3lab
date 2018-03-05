using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Client
    {
        public string Family;
        public string Name;
        public string Middle_name;
        public string products;
        public int ID;
        public int phone;

        public void writeInConsoleClient(string Family, string Name, string Middle_name, string products, int ID, int phone)
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nТовар: {3}\nID: {4}\nТелефон: {5}\n", Family, Name, Middle_name, products, ID, phone);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();
            myClient.Family = "Артемьев";
            myClient.Name = "Георгий";
            myClient.Middle_name = "Васильевич";
            myClient.products = "Гитара";
            myClient.ID = 22;
            myClient.phone = 30242;

           myClient.writeInConsoleClient(myClient.Family, myClient.Name, myClient.Middle_name, myClient.products, myClient.ID, myClient.phone);
            Console.ReadLine();
        }
    }
}









       
