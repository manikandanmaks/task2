using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
    sealed class UserInputAndOutput<S>:ClassForSpareParts

    { int choice = 0,temp=0;
        //Constructor for AbstractForSystemAssemble
        public UserInputAndOutput()
        {

        }
        //Destructor for AbstractForSystemAssemble
        ~UserInputAndOutput()
        {

        }
        //User Input's Here
       public void UserInput()
        {

            Console.WriteLine("Welcome To VIVIN COMPUTERS ");
            Console.WriteLine("1-->Set A new Price for Items");
            Console.WriteLine("2-->System Assembly only");
            Console.WriteLine("3-->Spare Parts Only");
            Console.WriteLine("Choose the Option 1 or 2 or 3-->");
            choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                temp = 0;
                if (choice==1)
                {
                    SetPriceOfItems();
                }
                else if (choice == 2)
                {
                    SystemAssembly();
                }
                else if (choice == 3)
                {
                    SpareParts();
                }
                else
                {
                    Console.WriteLine("select the correct option ");
                    temp = 1;
                }
            } while (temp==1);
        }
        public void SystemAssembly()
        {

        }
        public void SpareParts()
        {

        }

        void BillGenerationForSystemAssemble()
        {

        }
        void BillGenerationForSpareParts()
        {

        }
        void SetPriceOfItems()
        {

            Console.WriteLine("Enter the Price of Monitor:");
            Monitor=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Processor:");
            Processor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Ram:");
            Ram = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Drive:");
            Drive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Mouse:");
            Mouse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of KeyBoard:");
            KeyBoard = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Ports:");
            Ports = Convert.ToDouble(Console.ReadLine());
        }
            
    }
}
