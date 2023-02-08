using AlphaProjectBudgetApp;
using AlphaProjectBudgetApp.Models;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace TestAlphaProjectBudgetl;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMenuRegisterProgram()
    {
        AlphaProjectBudget projectBudget = new AlphaProjectBudget();
        DateTime startDate = new DateTime(2023, 6, 11);
        DateTime endDate = new DateTime(2023, 12, 11);
        
        Programm programToRegister = new Programm("DEV-01",startDate,endDate);
        bool registered = projectBudget.getMenu().Register(programToRegister);
        Assert.AreEqual(true, registered);
    }
}