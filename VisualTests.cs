using NUnit.Framework;

namespace ApplitoolsEye
{
    [TestFixture]
    public class VisualTests : TestBase
    {

        [Test]
        public void SetBaselineUsingAppName()
        {
            GoToPricingPage();
            Eyes.Open(Driver, AppName, TestName, Resolution1080p);
            Eyes.CheckWindow();
        }
    }
}