//-----------------------------------------------------------------------
// <copyright file="User.cs" company="ABCCompany">
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
    /// Base Class used to define the properties of a user.
    /// </summary>
    public class User
    {
        #region Private Fields

        /// <summary>
        /// Holds the membershipDate of the customer.
        /// </summary>
        private DateTime membershipDate;

        #endregion Private Fields

        #region Properties
        
        /// <summary>
        /// Gets or sets the Grocery Bill of the user object.
        /// </summary>
        public double GroceryBill { get; set; }

        /// <summary>
        /// Gets or sets the Non-Grocery Bill of the user object.
        /// </summary>
        public double NonGroceryBill { get; set; }

        /// <summary>
        /// Gets or sets the membershipDate of the user object of type customer.
        /// </summary>
        public DateTime MembershipDate
        {
            get
            {
                return this.membershipDate;
            }

            set
            {
                if (value <= DateTime.Now.Date)
                {
                    this.membershipDate = value;
                }
                else
                {
                    throw new ArgumentException("Membership Date cannot be later than today", "MembershipDate");
                }
            }
        }

        #endregion Properties
    }
}
