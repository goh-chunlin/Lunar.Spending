﻿using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
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
    public class UnitTestSelectSpendings : SqlDatabaseTestClass
    {

        public UnitTestSelectSpendings()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_SelectSpendingsTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTestSelectSpendings));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition CheckRowCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_SelectSpendingsTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_SelectSpendingsTest_PosttestAction;
            this.dbo_SelectSpendingsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_SelectSpendingsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dbo_SelectSpendingsTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_SelectSpendingsTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_SelectSpendingsTest_TestAction
            // 
            dbo_SelectSpendingsTest_TestAction.Conditions.Add(CheckRowCount);
            resources.ApplyResources(dbo_SelectSpendingsTest_TestAction, "dbo_SelectSpendingsTest_TestAction");
            // 
            // CheckRowCount
            // 
            CheckRowCount.Enabled = true;
            CheckRowCount.Name = "CheckRowCount";
            CheckRowCount.ResultSet = 1;
            CheckRowCount.RowCount = 1;
            // 
            // dbo_SelectSpendingsTest_PretestAction
            // 
            resources.ApplyResources(dbo_SelectSpendingsTest_PretestAction, "dbo_SelectSpendingsTest_PretestAction");
            // 
            // dbo_SelectSpendingsTest_PosttestAction
            // 
            resources.ApplyResources(dbo_SelectSpendingsTest_PosttestAction, "dbo_SelectSpendingsTest_PosttestAction");
            // 
            // dbo_SelectSpendingsTestData
            // 
            this.dbo_SelectSpendingsTestData.PosttestAction = dbo_SelectSpendingsTest_PosttestAction;
            this.dbo_SelectSpendingsTestData.PretestAction = dbo_SelectSpendingsTest_PretestAction;
            this.dbo_SelectSpendingsTestData.TestAction = dbo_SelectSpendingsTest_TestAction;
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
        public void dbo_SelectSpendingsTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_SelectSpendingsTestData;
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
        private SqlDatabaseTestActions dbo_SelectSpendingsTestData;
    }
}
