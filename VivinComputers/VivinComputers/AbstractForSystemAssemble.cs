using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
  public abstract class AbstractForSystemAssemble:IinterfaceForProfitCalculation,IInterfaceForGstCalculation,IInterfaceForDisplayPartsOfBoth
    {
       public int monitor = 0, speed = 0, ram = 0, drive = 0, mouse = 0, keyBoard = 0, ports = 0;

       public double gst,profit;
        //Constructor for AbstractForSystemAssemble
        public AbstractForSystemAssemble()
        {

        }
        //Destructor for AbstractForSystemAssemble
        ~AbstractForSystemAssemble()
        {

        }
        //Display parts for System assembling and Spare Parts Sale
         public void DisplayPartsOfSystemAssemble()
        {

        }
        public void DisplayPartsOfSpareParts()
        {

        }
        public double GstCalculation(double amount, double gst)
        {
           
            this.gst= gst;
            amount =amount +(amount * (gst/100));
            return amount;
        }
        public double ProfitCalculation(double amount, double profit)
        {
            this.profit = profit;
            amount = amount + (amount *(profit/100));

            return amount;
        }


    }
}
