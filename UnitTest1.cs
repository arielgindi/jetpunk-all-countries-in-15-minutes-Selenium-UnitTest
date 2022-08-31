using System.Diagnostics;
using System.Diagnostics.Metrics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumApplication2;

public class Tests
{
    string[] AllCountries = { "Albania", "Ukraine", "Andorra", "Austria", "Belarus", "Belgium", "Bosnia and Herzegovina", "Bulgaria", "Croatia", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Iceland", "Ireland", "Italy", "Kosovo", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Malta", "Moldova", "Monaco", "Montenegro", "Netherlands", "North Macedonia", "Norway", "Poland", "Portugal", "Romania", "Russia", "San Marino", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Switzerland", "Ukraine", "United Kingdom", "Vatican City", "Afghanistan", "Armenia", "Azerbaijan", "Bahrain", "Bangladesh", "Bhutan", "Brunei", "Cambodia", "China", "Cyprus", "East Timor", "Georgia", "India", "Indonesia", "Iran", "Iraq", "Israel", "Japan", "Jordan", "Kazakhstan", "Kuwait", "Kyrgyzstan", "Laos", "Lebanon", "Malaysia", "Maldives", "Mongolia", "Myanmar", "Nepal", "North Korea", "Oman", "Pakistan", "Philippines", "Qatar", "Saudi Arabia", "Singapore", "South Korea", "Sri Lanka", "Syria", "Taiwan", "Tajikistan", "Thailand", "Turkey", "Turkmenistan", "United Arab Emirates", "Uzbekistan", "Vietnam", "Yemen", "Algeria", "Angola", "Benin", "Botswana", "Burkina Faso", "Burundi", "Cameroon", "Cape Verde", "Central African Republic", "Chad", "Comoros", "Democratic Republic of the Congo", "Djibouti", "Egypt", "Equatorial Guinea", "Eritrea", "Eswatini", "Ethiopia", "Gabon", "Gambia", "Ghana", "Guinea", "Guinea-Bissau", "Ivory Coast", "Kenya", "Lesotho", "Liberia", "Libya", "Madagascar", "Malawi", "Mali", "Mauritania", "Mauritius", "Morocco", "Mozambique", "Namibia", "Niger", "Nigeria", "Republic of the Congo", "Rwanda", "São Tomé and Príncipe", "Senegal", "Seychelles", "Sierra Leone", "Somalia", "South Africa", "South Sudan", "Sudan", "Tanzania", "Togo", "Tunisia", "Uganda", "Zambia", "Zimbabwe", "Antigua and Barbuda", "Bahamas", "Barbados", "Belize", "Canada", "Costa Rica", "Cuba", "Dominica", "Dominican Republic", "El Salvador", "Grenada", "Guatemala", "Haiti", "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Trinidad and Tobago", "United States", "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela", "Australia", "Federated States of Micronesia", "Fiji", "Kiribati", "Marshall Islands", "Nauru", "New Zealand", "Palau", "Papua New Guinea", "Samoa", "Solomon Islands", "Tonga", "Tuvalu", "Vanuatu", };
    private ChromeDriver driver;
    private Stopwatch stopwatch = new Stopwatch();

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver(@"C:\Users\ariel\source\repos\SeleniumApplication2\Drivers");
    }

    //[Test]
    //public void ValidateTheMessageIsDisplayed()
    //{
    //    driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/simple-form-demo");
    //    driver.FindElement(By.Id("user-message")).SendKeys("LambdaTest rules");
    //    driver.FindElement(By.Id("showInput")).Click();
    //    Assert.IsTrue(driver.FindElement(By.Id("message")).Text.Equals("LambdaTest rules"), "The expected message was not displayed.");
    //}
    [Test]
    public void AllWorldDisplay1()
    {
        stopwatch.Start();
        Console.Error.WriteLine("Started Test 1");
        driver.Navigate().GoToUrl("https://www.jetpunk.com/quizzes/how-many-countries-can-you-name");
        Console.Error.WriteLine($"Time elapsed until page loadup: {stopwatch.Elapsed}");
        driver.FindElement(By.Id("start-button")).Click();
        IWebElement v = driver.FindElement(By.Id("txt-answer-box"));
        foreach (string Country in AllCountries)
        {
            v.SendKeys(Country);
            v.Clear();
        }
        stopwatch.Stop();
        driver.Quit();
        Console.Error.WriteLine($"Time elapsed untill finish: {stopwatch.Elapsed}");
    }
    [Test]


    [TearDown]
    public void TearDown() => driver.Quit();
}