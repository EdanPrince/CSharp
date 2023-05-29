using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class MedicineList
    {
        public SortedList objMedicineDetails = new SortedList();
        public void AcceptDetails()
        {
            string name;
            double price;
            char choice = 'Y';
            try
            {
                do
                {
                    Console.WriteLine("Enter the medicine name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the price: ");
                    price = Convert.ToDouble(Console.ReadLine());
                    objMedicineDetails.Add(name, price);
                    Console.WriteLine("Do you want to add more names? [Y/N]: ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }catch(Exception objEx)
            {
                Console.WriteLine("Error : {0}",objEx.Message); 
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Details of Medcines: ");
            Console.WriteLine("Medicine Name \t Price");
            for(int i = 0; i < objMedicineDetails.Count; i++)
            {
                Console.WriteLine("{0}\t\t {1:c2}",objMedicineDetails.GetKey(i),objMedicineDetails.GetByIndex(i));
            }
            Console.WriteLine("Total number of medicines: " + objMedicineDetails.Count);
        }
        public bool Modify()
        {
            string name;
            double price;
            Console.WriteLine("Enter the name of the medicine to change its price: ");
            name = Console.ReadLine();
            if(objMedicineDetails.Contains(name))
            {
                Console.WriteLine("Enter new price: ");
                price = Convert.ToDouble(Console.ReadLine());
                int index = objMedicineDetails.IndexOfKey(name);    
                objMedicineDetails.SetByIndex(index, price);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remove()
        {
            string choice;
            Console.WriteLine("Enter the name of the medicine: ");
            choice = Console.ReadLine();
            if (objMedicineDetails.Contains(choice))
            {
                objMedicineDetails.Remove(choice);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Search()
        {
            string choice;
            Console.WriteLine("Enter the name of the medicine: ");
            choice = Console.ReadLine();
            if(choice != "")
            {
                if(objMedicineDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Medidcine Name : {0}",choice);
                    Console.WriteLine("Price:{0:C2}", objMedicineDetails[choice]);
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
