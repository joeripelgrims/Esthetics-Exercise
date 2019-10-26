using System;
using System.Collections.Generic;
using Parlor_Library;

namespace Parlor_program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inMainMenu = true;
            while (inMainMenu)
            {
                Console.Clear();
                Console.WriteLine("1. Customer menu\n2. Appointments \n3. Product menu \n4. Exit program");
                int choiceMM = Convert.ToInt32(Console.ReadLine());
                switch (choiceMM)
                {
                    case 1:
                        bool inCustomerMenu = true;
                        while (inCustomerMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Show customer list\n2. Add new customer\n3. Remove a customer\n4. Exit menu");
                            int choiceM1 = Convert.ToInt32(Console.ReadLine());
                            switch (choiceM1)
                            {
                                case 1:
                                    Customer.showCustomerList();
                                    Console.WriteLine("Press Space to continue...");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Customer.addCustomer();
                                    break;
                                case 3:
                                    Customer.removeCustomer();
                                    break;
                                case 4:
                                    Console.WriteLine("Exit program.");
                                    inCustomerMenu = false;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input probably.");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        bool inAppointmentsMenu = true;
                        while (inAppointmentsMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Show appointments list\n2. Add new appointment\n3. Remove an appointment\n4. Exit menu");
                            int choiceM2 = Convert.ToInt32(Console.ReadLine());
                            switch (choiceM2)
                            {
                                case 1:
                                    Appointments.showAppointmentsList();
                                    Console.WriteLine("Press Space to continue...");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Appointments.addAppointment();
                                    break;
                                case 3:
                                    Appointments.removeAppointment();
                                    break;
                                case 4:
                                    Console.WriteLine("Exit menu.");
                                    inAppointmentsMenu = false;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input probably.");
                                    break;
                            }

                        }
                        break;
                    case 3:
                        bool inProductMenu = true;
                        while (inProductMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Show product/price list\n2. Stock new product\n3. Remove a product\n4. Exit menu");
                            int choiceM3 = Convert.ToInt32(Console.ReadLine());
                            switch (choiceM3)
                            {
                                case 1:
                                    Product.showProducts();
                                    Console.WriteLine("Press Space to continue...");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Product.stockProduct();
                                    break;
                                case 3:
                                    Product.showProducts();
                                    Product.sellProduct();
                                    break;
                                case 4:
                                    Console.WriteLine("Exit menu.");
                                    inProductMenu = false;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input probably.");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit program.");
                        inMainMenu = false;
                        break;
                    default:
                        break;
                }
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



    }
}
