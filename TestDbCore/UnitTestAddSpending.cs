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
    public class UnitTestAddSpending : SqlDatabaseTestClass
    {

        public UnitTestAddSpending()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_AddSpendingTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestAddSpending));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckTransactionStatusCode;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckMessageCode;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckDescription;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCurrency;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckAmount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_AddSpendingTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_AddSpendingTest_PosttestAction;
            this.dbo_AddSpendingTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_AddSpendingTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckTransactionStatusCode = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckMessageCode = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckDescription = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckCurrency = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            CheckAmount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_AddSpendingTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_AddSpendingTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_AddSpendingTest_TestAction
            // 
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckTransactionStatusCode);
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckMessageCode);
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckRowCount);
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckDescription);
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckCurrency);
            dbo_AddSpendingTest_TestAction.Conditions.Add(CheckAmount);
            resources.ApplyResources(dbo_AddSpendingTest_TestAction, "dbo_AddSpendingTest_TestAction");
            // 
            // CheckTransactionStatusCode
            // 
            CheckTransactionStatusCode.ColumnNumber = 2;
            CheckTransactionStatusCode.Enabled = true;
            CheckTransactionStatusCode.ExpectedValue = "1";
            CheckTransactionStatusCode.Name = "CheckTransactionStatusCode";
            CheckTransactionStatusCode.NullExpected = false;
            CheckTransactionStatusCode.ResultSet = 1;
            CheckTransactionStatusCode.RowNumber = 1;
            // 
            // CheckMessageCode
            // 
            CheckMessageCode.ColumnNumber = 4;
            CheckMessageCode.Enabled = true;
            CheckMessageCode.ExpectedValue = "3";
            CheckMessageCode.Name = "CheckMessageCode";
            CheckMessageCode.NullExpected = false;
            CheckMessageCode.ResultSet = 1;
            CheckMessageCode.RowNumber = 1;
            // 
            // CheckRowCount
            // 
            CheckRowCount.Enabled = true;
            CheckRowCount.Name = "CheckRowCount";
            CheckRowCount.ResultSet = 1;
            CheckRowCount.RowCount = 1;
            // 
            // CheckDescription
            // 
            CheckDescription.ColumnNumber = 1;
            CheckDescription.Enabled = true;
            CheckDescription.ExpectedValue = "Test Description";
            CheckDescription.Name = "CheckDescription";
            CheckDescription.NullExpected = false;
            CheckDescription.ResultSet = 2;
            CheckDescription.RowNumber = 1;
            // 
            // CheckCurrency
            // 
            CheckCurrency.ColumnNumber = 2;
            CheckCurrency.Enabled = true;
            CheckCurrency.ExpectedValue = "SGD";
            CheckCurrency.Name = "CheckCurrency";
            CheckCurrency.NullExpected = false;
            CheckCurrency.ResultSet = 2;
            CheckCurrency.RowNumber = 1;
            // 
            // CheckAmount
            // 
            CheckAmount.ColumnNumber = 3;
            CheckAmount.Enabled = true;
            CheckAmount.ExpectedValue = "10.50";
            CheckAmount.Name = "CheckAmount";
            CheckAmount.NullExpected = false;
            CheckAmount.ResultSet = 2;
            CheckAmount.RowNumber = 1;
            // 
            // dbo_AddSpendingTest_PretestAction
            // 
            resources.ApplyResources(dbo_AddSpendingTest_PretestAction, "dbo_AddSpendingTest_PretestAction");
            // 
            // dbo_AddSpendingTest_PosttestAction
            // 
            resources.ApplyResources(dbo_AddSpendingTest_PosttestAction, "dbo_AddSpendingTest_PosttestAction");
            // 
            // dbo_AddSpendingTestData
            // 
            this.dbo_AddSpendingTestData.PosttestAction = dbo_AddSpendingTest_PosttestAction;
            this.dbo_AddSpendingTestData.PretestAction = dbo_AddSpendingTest_PretestAction;
            this.dbo_AddSpendingTestData.TestAction = dbo_AddSpendingTest_TestAction;
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
        public void dbo_AddSpendingTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_AddSpendingTestData;
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
        private SqlDatabaseTestActions dbo_AddSpendingTestData;
    }
}
