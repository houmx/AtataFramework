using Atata;
using AtataFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataFramework
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().
                UseChrome().
                UseBaseUrl("https://atata-framework.github.io/atata-sample-app/#!/").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                AddScreenshotFileSaving().
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }

        
        public UsersPage Login()
        {
            return Go.To<SignInPage>().
                     Email.Set("admin@mail.com").
                     Password.Set("abc123").
                     SignIn.ClickAndGo();
        }

    }
}
