using System;

namespace Problem_1._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double priceWithoutTaxes = 0;
            double taxes = 0;
            double totalPrice = 0;
            double specialPrice = 0;
            while (command!= "special" && command!= "regular")
            {
                double input = double.Parse(command);
                if (input == 0)
                {
                    Console.WriteLine("Invalid order!");
                    input = 0;
                }
                if (input < 0 )
                {
                    Console.WriteLine("Invalid price!");
                    input = 0;
                }
                

                priceWithoutTaxes += input;

                command = Console.ReadLine();
            }

            taxes = (priceWithoutTaxes / 100) * 20;
            totalPrice = priceWithoutTaxes + taxes;
            if (command == "special")
            {
                double discount = (totalPrice / 100) * 10;
                specialPrice = totalPrice - discount;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {specialPrice:F2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice}$");
            }
           
        }
    }
}
