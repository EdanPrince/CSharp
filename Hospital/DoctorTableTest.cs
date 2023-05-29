using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DoctorTableTest
    {
        static void Main(string[] args)
        {
            try
            {
                DoctorTable objDoctorsTable = new DoctorTable();
                objDoctorsTable.AcceptDetails();
                objDoctorsTable.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSeclect one of the following options: ");
                    Console.WriteLine(" 1. Remove\n 2. Remove All\n 3. Serach\n 4. Exit");
                    Console.WriteLine("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                if (objDoctorsTable.Remove())
                                {
                                    Console.WriteLine("\n-----After Removing-----");
                                    objDoctorsTable.DisplayDetails();
                                }
                                else
                                {
                                    Console.WriteLine("Doctor with this name does not exist");
                                }
                                break;

                            }
                        case 2:
                            {
                                objDoctorsTable.objDoctorDetails.Clear();
                                Console.WriteLine("\n-----After removing all the doctors-----");
                                Console.WriteLine("Total number of doctors: " + objDoctorsTable.objDoctorDetails.Count);
                                return;
                            }
                        case 3:
                            {
                                objDoctorsTable.Search();
                                break;
                            }
                        case 4:
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
