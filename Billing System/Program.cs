//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="ABCCompany">
//     Copyright ABCCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace BillingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #region enums

    /// <summary>
    /// Enum to hold user type values.
    /// </summary>
    public enum UserType : byte
    {
        Employee = 1,
        Affiliate,
        Customer
    }

    #endregion enums

    /// <summary>
    /// Class used to test the billing system.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// To test the billing system.
        /// </summary>
        /// <param name="args">string argument</param>
        public static void Main(string[] args)
        {
            try
            {
                User user = new User();

                // Read the type of the user
                Console.WriteLine("\n----------------");
                Console.WriteLine("User Type:");
                Console.WriteLine("----------------\n");

Console.Write(@"
1 - Employee
2 - Affiliate
3 - Customer

Please select one (1, 2, or 3): ");

                int userType = Int32.Parse(Console.ReadLine());
                while (true)
                {
                    if (userType < 1 || userType > 3)
                    {
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                    }

                    // Perform explicit cast from int to UserType enum type
                    UserType myUserType = (UserType)userType;

                    switch (myUserType)
                    {
                        case UserType.Customer:
                            {
                                // Read membership date of the user
                                Console.Write("Enter Membership Date: ");
                                user.MembershipDate = DateTime.Parse(Console.ReadLine());

                                break;
                            }
                    }

                    // Read Non Grocery Bill of the user
                    Console.Write("Enter Non Grocery Bill: ");
                    user.NonGroceryBill = Double.Parse(Console.ReadLine());

                    // Read Grocery Bill of the user
                    Console.Write("Enter Grocery Bill: ");
                    user.GroceryBill = Double.Parse(Console.ReadLine());

                    Billing billingObj = new Billing();
                    double netPayableAmount = billingObj.GetNetPayableAmount(user, user.NonGroceryBill, user.GroceryBill, myUserType);
                    Console.WriteLine("Net payable amount is: {0}", netPayableAmount);
                    Console.ReadLine();

                    System.Environment.Exit(0);
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.Read();

            }
        }
    }
}
