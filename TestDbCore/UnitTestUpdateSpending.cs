using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace TestDbCore
{
    [TestClass()]
    public class UnitTestUpdateSpending : SqlDatabaseTestClass
    {

        public UnitTestUpdateSpending()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_UpdateSpendingTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestUpdateSpending));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCurrency;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_UpdateSpendingTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_UpdateSpendingTest_PosttestAction;
            this.dbo_UpdateSpendingTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_UpdateSpendingTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckCurrency = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_UpdateSpendingTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_UpdateSpendingTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_UpdateSpendingTest_TestAction
            // 
            dbo_UpdateSpendingTest_TestAction.Conditions.Add(CheckCurrency);
            resources.ApplyResources(dbo_UpdateSpendingTest_TestAction, "dbo_UpdateSpendingTest_TestAction");
            // 
            // CheckCurrency
            // 
            CheckCurrency.ColumnNumber = 2;
            CheckCurrency.Enabled = true;
            CheckCurrency.ExpectedValue = "MYR";
            CheckCurrency.Name = "CheckCurrency";
            CheckCurrency.NullExpected = false;
            CheckCurrency.ResultSet = 2;
            CheckCurrency.RowNumber = 1;
            // 
            // dbo_UpdateSpendingTest_PretestAction
            // 
            resources.ApplyResources(dbo_UpdateSpendingTest_PretestAction, "dbo_UpdateSpendingTest_PretestAction");
            // 
            // dbo_UpdateSpendingTest_PosttestAction
            // 
            resources.ApplyResources(dbo_UpdateSpendingTest_PosttestAction, "dbo_UpdateSpendingTest_PosttestAction");
            // 
            // dbo_UpdateSpendingTestData
            // 
            this.dbo_UpdateSpendingTestData.PosttestAction = dbo_UpdateSpendingTest_PosttestAction;
            this.dbo_UpdateSpendingTestData.PretestAction = dbo_UpdateSpendingTest_PretestAction;
            this.dbo_UpdateSpendingTestData.TestAction = dbo_UpdateSpendingTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_UpdateSpendingTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_UpdateSpendingTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_UpdateSpendingTestData;
    }
}
