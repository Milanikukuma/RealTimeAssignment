using System.Numerics;

namespace RealWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Phone myPhone = new Phone("Apple", "iPhone 13", 256);

        
            myPhone.MakeCall("John");

            
            myPhone.SendText("Sarah", "Hello!");

          
            myPhone.CheckStorage();
        }
    }
}
