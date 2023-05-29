using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Suppliers
    {
        public Dictionary<int, string> objSupplierDetails = new Dictionary<int, string>();
        public void AcceptDetails()
        {
            int id;
            string name;
            char choice = 'A';
            try
            {
                do
                {
                    Console.WriteLine("Enter the supplier ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the name: ");
                    name = Console.ReadLine();
                    objSupplierDetails.Add(id, name);
                    Console.WriteLine("Do you want to add more records? [Y/N]: ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
        public void DisplayDetails()
        {
            ICollection objCollection = objSupplierDetails.Keys;
            Console.WriteLine("\nDetails of Suppliers: ");
            Console.WriteLine("Supplier ID \t Name:");
            foreach (int details in objCollection)
            {
                Console.WriteLine(details + " \t\t " + objSupplierDetails[details]);
            }
            Console.WriteLine("Total number of suppliers: " + objSupplierDetails.Count);
        }
        public bool Modify()
        {
            int id;
            string name;
            Console.WriteLine("Enter the supplier ID to change the name: ");
            id = Convert.ToInt32(Console.ReadLine());
            if (id > 0 && objSupplierDetails.ContainsKey(id))
            {
                Console.WriteLine("Enter new name of the supplier:");
                name = Console.ReadLine();
                objSupplierDetails[id] = name;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remove()
        {
            int input;
            Console.WriteLine("Enter the supplier ID: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && objSupplierDetails.ContainsKey(input))
            {
                objSupplierDetails.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Search()
        {
            int choice;
            Console.WriteLine("Enter the supplier ID: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0)
            {
                if (objSupplierDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Supplier ID: {0}", choice);
                    Console.WriteLine("Name:{0}", objSupplierDetails[choice]);
                }
                else
                {
                    Console.WriteLine("Record Not Found!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
