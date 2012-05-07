//-----------------------------------------------------------------------
// <copyright file="Billing.cs" company="ABCCompany">
//     Copyright ABCCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace BillingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class used to calculate the net payable amount for a given bill.
    /// </summary>
    public class Billing
    {
        /// <summary>
        /// Holds the discounted Non-Grocery Bill of the user.
        /// </summary>
        private double discountedNonGroceryBill;
                       
        /// <summary>
        /// Holds the discounted Grocery Bill of the user.
        /// </summary>
        private double discountedGroceryBill;

        /// <summary>
        /// Holds the netPayableAmount of the user.
        /// </summary>
        private double netPayableAmount;

        /// <summary>
        /// Gets the net payable amount for the user.
        /// </summary>
        /// <param name="user">User object</param>
        /// <param name="nonGroceryBill">Non-grocery bill before discount</param>
        /// <param name="GroceryBill">Grocery bill before discount</param>
        /// <param name="userType">Type of user</param>
        /// <returns>Net payable amount</returns>
        public double GetNetPayableAmount(User user, double nonGroceryBill, double groceryBill, UserType userType)
        {
            try
            {
                switch (userType)
                {
                    case UserType.Employee:
                        {
                            // If user is an Employee
                            //Employee employee = (Employee)user;

                            // If purchased items are non-groceries, then calculate payable amount based on both Percentage and 
                            // cash discount of $5 discount per 100$ 
                            if (nonGroceryBill > 0)
                            {
                                this.discountedNonGroceryBill = this.GetPercentageBasedPayableAmount(nonGroceryBill, Constants.EmployeeDiscount);
                                this.discountedNonGroceryBill = this.GetCashBasedPayableAmount(this.discountedNonGroceryBill);
                            }
                            
                            // If purchased items are groceries, then calculate payable amount based on 
                            // cash discount of $5 discount per 100$ 
                            if (groceryBill > 0)
                            {
                                this.discountedGroceryBill = this.GetCashBasedPayableAmount(groceryBill);
                            }

                            // Net Payable Amount is sum of discountedNonGroceryBill and discountedGroceryBill
                            this.netPayableAmount = this.discountedNonGroceryBill + this.discountedGroceryBill;

                            break;
                         }

                    case UserType.Affiliate:
                        {
                            // If user is an Affliate
                            //Affiliate affiliate = (Affiliate)user;

                            // If purchased items are non-groceries, then calculate payable amount based on both Percentage and 
                            // cash discount of $5 discount per 100$ 
                            if (nonGroceryBill > 0)
                            {
                                this.discountedNonGroceryBill = this.GetPercentageBasedPayableAmount(nonGroceryBill, Constants.AffiliateDiscount);
                                this.discountedNonGroceryBill = this.GetCashBasedPayableAmount(this.discountedNonGroceryBill);
                            }

                            // If purchased items are groceries, then calculate payable amount based on 
                            // cash discount of $5 discount per 100$ 
                            if (groceryBill > 0)
                            {
                                this.discountedGroceryBill = this.GetCashBasedPayableAmount(groceryBill);
                            }

                            // Net Payable Amount is sum of discountedNonGroceryBill and discountedGroceryBill
                            this.netPayableAmount = this.discountedNonGroceryBill + this.discountedGroceryBill;

                            break;
                        }

                    case UserType.Customer:
                        {
                            // If user is a general Customer
                            //Customer customer = (Customer)user;

                            // Check the span of customer membership
                            TimeSpan span = DateTime.Now.Subtract(user.MembershipDate);
                            double years = span.Days / 365.25; // leap years included    

                            // If purchased items are non-groceries, then calculate payable amount based on Percentage else 
                            // calculate amount based on $5 discount per 100$
                            if (years >= 2)
                            {
                                // If purchased items are non-groceries, then calculate payable amount based on both Percentage and 
                                // cash discount of $5 discount per 100$ 
                                if (nonGroceryBill > 0)
                                {
                                    this.discountedNonGroceryBill = this.GetPercentageBasedPayableAmount(nonGroceryBill, Constants.CustomerDiscount);
                                    this.discountedNonGroceryBill = this.GetCashBasedPayableAmount(this.discountedNonGroceryBill);
                                }

                                // If purchased items are groceries, then calculate payable amount based on 
                                // cash discount of $5 discount per 100$ 
                                if (groceryBill > 0)
                                {
                                    this.discountedGroceryBill = this.GetCashBasedPayableAmount(groceryBill);
                                }

                                // Net Payable Amount is sum of discountedNonGroceryBill and discountedGroceryBill
                                this.netPayableAmount = this.discountedNonGroceryBill + this.discountedGroceryBill;
                            }
                            else
                            {
                                // If purchased items are non-groceries, then calculate payable amount based on both Percentage and 
                                // cash discount of $5 discount per 100$ 
                                if (nonGroceryBill > 0)
                                {
                                    this.discountedNonGroceryBill = this.GetCashBasedPayableAmount(nonGroceryBill);
                                }

                                // If purchased items are groceries, then calculate payable amount based on 
                                // cash discount of $5 discount per 100$ 
                                if (groceryBill > 0)
                                {
                                    this.discountedGroceryBill = this.GetCashBasedPayableAmount(groceryBill);
                                }

                                // Net Payable Amount is sum of discountedNonGroceryBill and discountedGroceryBill
                                this.netPayableAmount = this.discountedNonGroceryBill + this.discountedGroceryBill;

                                break;
                            }

                            break;
                        }

                    default:
                        {
                            if (nonGroceryBill + groceryBill > 0)
                            {
                                this.netPayableAmount = this.GetCashBasedPayableAmount(nonGroceryBill + groceryBill);
                            }

                            break;
                        }
                }

                return this.netPayableAmount;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return 0;
            }
        }

        /// <summary>
        /// Gets Payable Amount Based on Percentage Discount
        /// <param name="totalBill">Total Bill before discount</param>
        /// <param name="discount">Discount</param>
        /// <returns>Net payable amount</returns>
        /// </summary>
        private double GetPercentageBasedPayableAmount(double totalBill, double discount)
        {
            return totalBill * ((100 - discount) / 100);
        }

        /// <summary>
        /// Gets Payable Amount Based on 5$ per 100$
        /// <param name="totalBill">Total Bill before discount</param>
        /// <returns>Net payable amount</returns>
        /// </summary>
        private double GetCashBasedPayableAmount(double totalBill)
        {
            return totalBill - (System.Math.Floor((totalBill / 100)) * Constants.DiscountEachHundredDollars);
        }
    }
}
