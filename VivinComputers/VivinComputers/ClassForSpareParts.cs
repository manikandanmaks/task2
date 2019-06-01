using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
   class ClassForSpareParts:AbstractForSystemAssemble,IInterfaceForGstCalculation,IInterfaceForDisplayPartsOfBoth
    {
       private double monitorSp = 0, processorSp = 0, ramSp = 0, driveSp = 0, mouseSp = 0, keyBoardSp = 0, portsSp = 0;
        //properties for price of items
        public int option = 0;
        public double Monitor
        {
            get
            {
                return monitorSp;
            }
            set
            {
                monitorSp=value;
            }
        }
        public double Processor
        {
            get
            {
                return processorSp;
            }
            set
            {
                processorSp = value;
            }
        }
        public double Ram
        {
            get
            {
                return ramSp;
            }
            set
            {
                ramSp = value;
            }
        }
        public double Drive
        {
            get
            {
                return  driveSp;
            }
            set
            {
                 driveSp= value;
            }
        }
        public double KeyBoard
        {
            get
            {
                return keyBoardSp;
            }
            set
            {
                keyBoardSp = value;
            }
        }
        public double Ports
        {
            get
            {
                return portsSp;
            }
            set
            {
                portsSp = value;
            }
        }
        public double Mouse
        {
            get
            {
                return mouseSp;
            }
            set
            {
                mouseSp = value;
            }
        }

        //Display parts for System assembling and Spare Parts Sale
        public void  DisplayPartsOfSpareParts()
        {   
            Console.WriteLine("1--Monitor " );
            Console.WriteLine("2--Speed   ");
            Console.WriteLine("3--RAM    ");
            Console.WriteLine("4--DRIVE   ");
            Console.WriteLine("5--Mouse  ");
            Console.WriteLine("6--Keyboard ");
            Console.WriteLine("7--PORTS   ");
        }
        public int SelectOption()
        {

            Console.WriteLine("Select the Option: ");
            option=Convert.ToInt32(Console.ReadLine());
            return option;
        }
        public int SwitchMethod(int opt)
        {

            switch (opt)
            {
                case 1:
                    Console.WriteLine("Select the option for 1 --> 15 Inch  2--> 16 Inch :");

                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 2");
                    break;
                case 4:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    Console.WriteLine("Case 2");
                    break;
                case 6:
                    Console.WriteLine("Case 2");
                    break;
                case 7:
                    Console.WriteLine("Case 2");
                    break;
               
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return 0;
        }
       
    }
}
