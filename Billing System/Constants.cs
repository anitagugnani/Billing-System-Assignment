//-----------------------------------------------------------------------
// <copyright file="Constants.cs" company="ABCCompany">
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
    /// Class used to define the constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Holds the employee discount.
        /// </summary>
        public const int EmployeeDiscount = 30;

        /// <summary>
        /// Holds the affiliate discount.
        /// </summary>
        public const int AffiliateDiscount = 10;

        /// <summary>
        /// Holds the customer discount.
        /// </summary>
        public const int CustomerDiscount = 5;

        /// <summary>
        /// Holds the discount each hundred dollars.
        /// </summary>
        public const int DiscountEachHundredDollars = 5;
    }
}
