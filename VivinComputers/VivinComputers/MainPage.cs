using System;

namespace VivinComputers
{
    class MainPage
    {
        static void Main(string[] args)
        {
            //Object creation for Menu Class
            UserInputAndOutput<Int32> menu = new UserInputAndOutput<Int32>();
            //Call the user iput method
            menu.UserInput();
        }
    }
}