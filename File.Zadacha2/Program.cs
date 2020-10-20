using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace File.Zadacha
{

    class Client
    {

        public int Id;
        public string Passnum;
        public double Payment;


        public Client(int id, string passnum, double payment)
        {
            Id = id;
            Passnum = passnum;
            Payment = payment;
        }





        public string Getinfo()
        {
            return ($"\n\tID  : {Id} \tPassport : {Passnum} \t  Payment : {Payment}");
        }



        public string ChangePayment()
        {
            Console.WriteLine("New Payment: ");
            double a = double.Parse(Console.ReadLine());

            return ($"ID Number : {Id} Number of Passport: {Passnum} New Payment: {a}");
        }



        public string ChangePass()
        {
            Console.WriteLine("New Number of Passport: ");
            string a = Console.ReadLine();

            return ($"ID Number : {Id} Number of Passport: {a} New Payment: {Payment}");
        }



        public string ChangeID()
        {
            Console.WriteLine("New ID: ");
            int a = int.Parse(Console.ReadLine());

            return ($"ID Number : {a} Number of Passport: {Passnum} New Payment: {Payment}");
        }


    }



    class Program
    {


        static void Main(string[] args)
        {
            Client client = new Client(100, "AZE000055", 500);
            Client client1 = new Client(101, "AZE000066", 600);
            Client client2 = new Client(102, "AZE000077", 700);
            Client client3 = new Client(103, "AZE000088", 800);

            Console.WriteLine("\t\t\tInformation about Users");
            Console.WriteLine(client.Getinfo());
            Console.WriteLine(client1.Getinfo());
            Console.WriteLine(client2.Getinfo());
            Console.WriteLine(client3.Getinfo());



            // создаем П А П К У  для файла
            string path = @"C:\Araz1";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();

            }

            
            //  Создаем Ф А Й Л 
            string path1 = @"C:\Araz1\Example.txt";
            FileInfo fileInfo1 = new FileInfo(path1);

            if (!fileInfo1.Exists)
            {

                try
                {
                    using (StreamWriter sw = new StreamWriter(path1, false, System.Text.Encoding.Default))
                    {                                                                                               // Вызываем М Е Т О Д из  Класса 

                        sw.WriteLine(client.Getinfo());
                        sw.WriteLine(client1.Getinfo());
                        sw.WriteLine(client2.Getinfo());
                        sw.WriteLine(client3.Getinfo());
                        sw.Close();

                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }







            // Создаем измененные Ф А Й Л Ы 
            int a = 0;
            do
            {

                string path2 = @"C:\Araz1\Example_ChangePayment.txt";
                FileInfo fileInfo2 = new FileInfo(path2);
                try
                {



                    Console.WriteLine("\nWhat do You want to change \t\n1: ID \t\n2: Number of Passport \t\n3: Payment ");
                    int select = int.Parse(Console.ReadLine());
                    // Создаем измененные Ф А Й Л Ы


                    switch (select)

                    {
                        case 1:
                            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(client.ChangeID());
                                sw.WriteLine(client1.ChangeID());
                                sw.WriteLine(client2.ChangeID());
                                sw.WriteLine(client3.ChangeID());
                                break;
                            }

                        case 2:
                            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(client.ChangePass());
                                sw.WriteLine(client1.ChangePass());
                                sw.WriteLine(client2.ChangePass());
                                sw.WriteLine(client3.ChangePass());
                                break;
                            }

                        case 3:
                            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(client.ChangePayment());
                                sw.WriteLine(client1.ChangePayment());
                                sw.WriteLine(client2.ChangePayment());
                                sw.WriteLine(client3.ChangePayment());
                                break;
                            }

                        default:
                            Console.WriteLine("Good bye");
                            break;

                    }

                    

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


                
                Console.WriteLine("\n\t\t Any other button for change another column ");
                Console.WriteLine("\n\t\tClick 5 to exit");
                a = int.Parse(Console.ReadLine());

                if (a == 5)
                {
                    break;
                }

            }

            while (a!=5);


        }
    }

}


