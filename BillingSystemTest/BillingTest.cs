//-----------------------------------------------------------------------
// <copyright file="BillingTest.cs" company="ABCCompany">
//     Copyright ABCCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace BillingSystemTest
{
    using System;
    using BillingSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
   
    /// <summary>
    /// This is a test class for BillingTest and is intended
    /// to contain all BillingTest Unit Tests
    /// </summary>
    [TestClass()]
    public class BillingTest
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get; set;
        }
                
        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest1()
        {
            Billing target = new Billing();
            User user = new User();

            double nonGroceryBill = 0; 
            double groceryBill = 990; 
            UserType userType = UserType.Employee;
            double expected = 945; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest2()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300; 
            double groceryBill = 0; 
            UserType userType = UserType.Employee;
            double expected = 200; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest3()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 0;
            double groceryBill = 0; 
            UserType userType = UserType.Employee;
            double expected = 0; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest4()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300; 
            double groceryBill = 990; 
            UserType userType = UserType.Employee;
            double expected = 1145;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest5()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 0; 
            double groceryBill = 50; 
            UserType userType = UserType.Employee;
            double expected = 50;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest6()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300; 
            double groceryBill = 50; 
            UserType userType = UserType.Employee;
            double expected = 250; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Employee
        /// Non-Grocery Bill:50
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForEmployeeTest7()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 50; 
            double groceryBill = 50; 
            UserType userType = UserType.Employee;
            double expected = 85; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest1()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 0;
            double groceryBill = 990;
            UserType userType = UserType.Affiliate;
            double expected = 945;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest2()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300;
            double groceryBill = 0;
            UserType userType = UserType.Affiliate;
            double expected = 260;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest3()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 0; 
            double groceryBill = 0; 
            UserType userType = UserType.Affiliate;
            double expected = 0; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest4()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300;
            double groceryBill = 990;
            UserType userType = UserType.Affiliate;
            double expected = 1205;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest5()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 0;
            double groceryBill = 50;
            UserType userType = UserType.Affiliate;
            double expected = 50;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest6()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 300;
            double groceryBill = 50;
            UserType userType = UserType.Affiliate;
            double expected = 310;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Affiliate
        /// Non-Grocery Bill:50
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForAffiliateTest7()
        {
            Billing target = new Billing();
            User user = new User();
            double nonGroceryBill = 50;
            double groceryBill = 50;
            UserType userType = UserType.Affiliate;
            double expected = 95;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Case: Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest1()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");
            
            double nonGroceryBill = 0;
            double groceryBill = 990;
            UserType userType = UserType.Customer;
            double expected = 945;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest2()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 0;
            UserType userType = UserType.Customer;
            double expected = 275;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest3()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 0; 
            double groceryBill = 0; 
            UserType userType = UserType.Customer;
            double expected = 0; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest4()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 990;
            UserType userType = UserType.Customer;
            double expected = 1220;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest5()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 0;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 50;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest6()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 325;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// Old Customer (Greater than 2 years)
        /// Non-Grocery Bill:50
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForOldCustomerTest7()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2010-01-01");

            double nonGroceryBill = 50;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 97.5;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest1()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 0;
            double groceryBill = 990;
            UserType userType = UserType.Customer;
            double expected = 945;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest2()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 0;
            UserType userType = UserType.Customer;
            double expected = 285;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 0
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest3()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 0; 
            double groceryBill = 0; 
            UserType userType = UserType.Customer;
            double expected = 0; 
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 990
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest4()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 990;
            UserType userType = UserType.Customer;
            double expected = 1230;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 0
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest5()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 0;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 50;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill: 300
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest6()
        {
            Billing target = new Billing();
            User user = new User();
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 300;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 335;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GetNetPayableAmount
        /// New Customer (Less than 2 years)
        /// Non-Grocery Bill:50
        /// Grocery Bill: 50
        /// </summary>
        [TestMethod()]
        public void GetNetPayableAmountForNewCustomerTest7()
        {
            Billing target = new Billing();
            User user = new User();    
            user.MembershipDate = Convert.ToDateTime("2012-01-01");

            double nonGroceryBill = 50;
            double groceryBill = 50;
            UserType userType = UserType.Customer;
            double expected = 100;
            double actual;
            actual = target.GetNetPayableAmount(user, nonGroceryBill, groceryBill, userType);
            Assert.AreEqual(expected, actual);
        }
    }
}
