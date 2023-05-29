using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class PatientListTest
    {
        static void Main(string[] args)
        {
            try
            {
                PatientList objPatientList = new PatientList();
                objPatientList.AcceptDetails();
                objPatientList.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine(" 1. Sort\n 2. Remove\n 3. Reverse\n 4. Search\n 5. Exit");
                    Console.WriteLine("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                objPatientList.objPatientNames.Sort();
                                Console.WriteLine("\n-----After Sorting-----");
                                objPatientList.DisplayDetails();
                                break;
                            }
                        case 2:
                            {
                                if (objPatientList.Remove())
                                {
                                    Console.WriteLine("\n-----After Removing-----");
                                    objPatientList.DisplayDetails();
                                }
                                else
                                {
                                    Console.WriteLine("Patient with this name does not exits");
                                }
                                break;
                            }
                        case 3:
                            {
                                objPatientList.objPatientNames.Reverse();
                                Console.WriteLine("\n-----After Reversing-----");
                                objPatientList.DisplayDetails();
                                break;
                            }
                        case 4:
                            {
                                objPatientList.Search();
                                break;
                            }
                        case 5:
                            {
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Data Entry!");
                                break;
                            }
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objex)
            {
                Console.WriteLine("Error : {0}", objex.Message);
            }
        }
    }
}
