using aspnet_core_dotnet_core.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    
namespace aspnet_core_dotnet_core.UnitTests
{
    [TestClass]
    public class SampleUnitTests
    {
        [TestMethod]
        public void IndexPageTest()
        {
            IndexModel model = new IndexModel();
            Assert.AreEqual("Index", actual: model.DoTest());
        }
        [TestMethod]
        public void ContactPageTest()
        {
            ContactModel model = new ContactModel();
            Assert.AreEqual("Contact",actual: model.DoTest());
        }
        [TestMethod]
        public void PrivacyPageTest()
        {
            PrivacyModel model = new PrivacyModel();
            Assert.AreEqual("Privacy", actual: model.DoTest());
        }
    }
}
