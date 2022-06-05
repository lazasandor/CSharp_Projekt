namespace WebApi_XUnitTests
{
    public class WebApi_Jobs_UnitTests
    {
        WebApi_Client_Jobs.MainWindow window = new WebApi_Client_Jobs.MainWindow();
        [Fact]
        public void TestCustomerNameValidation()
        {
            Assert.True(window.CustomerNameValidation("Laza Sandor"));
            Assert.True(window.CustomerNameValidation("Dobos Martin"));
            Assert.False(window.CustomerNameValidation(""));
            Assert.False(window.CustomerNameValidation("Kasza Blanka!"));
            Assert.False(window.CustomerNameValidation("Lakatos Bence?"));
            Assert.False(window.CustomerNameValidation("Toth:Geri"));
            Assert.False(window.CustomerNameValidation(" Toth Eszter"));
 
        }
        public void TestLicensePlateNumberValidation()
        {
            Assert.True(window.LicensePlateNumberValidation("ABC-123", false));
            Assert.False(window.LicensePlateNumberValidation("ABc-123", false));
            Assert.False(window.LicensePlateNumberValidation("ABc-123", false));
            Assert.False(window.LicensePlateNumberValidation("abc-123", false));
            Assert.False(window.LicensePlateNumberValidation("ABc-1c3", false));
            Assert.False(window.LicensePlateNumberValidation("1BC-123", false));
            Assert.False(window.LicensePlateNumberValidation("", false));
            Assert.False(window.LicensePlateNumberValidation("XYZ-1234", false));
            Assert.False(window.LicensePlateNumberValidation("123-ABC", false));
            Assert.False(window.LicensePlateNumberValidation("XYZW-1", false));
            Assert.False(window.LicensePlateNumberValidation("ABc-123?", false));
            Assert.False(window.LicensePlateNumberValidation("ABC- 123", false));
            Assert.False(window.LicensePlateNumberValidation("ABC-123 ", false));
            Assert.False(window.LicensePlateNumberValidation(" ABC-123", false));
        }
    }
}