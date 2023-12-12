using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld
{
    internal class Phone
    {
        private string brand;
        private string model;
        private int storage;

        public Phone(string brand, string model, int storage)
        {
            this.brand = brand;
            this.model = model;
            this.storage = storage;
        }

        public void MakeCall(string contact)
        {
            Console.WriteLine($"Calling {contact}...");
        }

        public void SendText(string contact, string message)
        {
            Console.WriteLine($"Sending text to {contact}: {message}");
        }

        public void CheckStorage() // Public method to access storage info
        {
            Console.WriteLine($"Available storage on {brand} {model}: {storage}GB");
        }
    }
}
