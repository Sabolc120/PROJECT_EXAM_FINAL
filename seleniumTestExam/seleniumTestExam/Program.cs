using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using IJavaScriptExecutor = OpenQA.Selenium.IJavaScriptExecutor;
class Program
{
    static void Main(string[] args)
    {
        // Set the path to the ChromeDriver executable
        ChromeOptions options = new ChromeOptions();
        using (IWebDriver driver = new ChromeDriver(@"E:\Opera_letöltések\chromedriver_win32\chromedriver.exe"))
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            //Elmegy a föoldalra
            driver.Navigate().GoToUrl("http://localhost:4200/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Rá kattint a menübuttonre
            IWebElement menuButton = driver.FindElement(By.Id("menu-btn"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("menu-btn")));
            menuButton.Click();

            //Menüböl rákattint a regisztrációs buttönre
            IWebElement regLink = driver.FindElement(By.Id("reg"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("reg")));
            regLink.Click();


            //Bezárja a menüt
            IWebElement menuButton2 = driver.FindElement(By.Id("menu-btn"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("menu-btn")));
            menuButton2.Click();


            //Regisztrál egy elöre megadott felhasználót
            IWebElement userNameField = driver.FindElement(By.Id("userName"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userName")));
            userNameField.SendKeys("TestingUser22");
            IWebElement userPasswordField = driver.FindElement(By.Id("userPassword"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userPassword")));
            userPasswordField.SendKeys("dfdsdf");

            IWebElement regButton = driver.FindElement(By.Id("regBtn"));
            Thread.Sleep(2000);
            regButton.Click();


            //Elnavigál a login oldalra
            driver.Navigate().GoToUrl("http://localhost:4200/loginPage");


            //Beloginolja a regisztrált felhasználót
            IWebElement userNameFieldLog = driver.FindElement(By.Id("userName"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userName")));
            userNameFieldLog.SendKeys("TestingUser22");


            IWebElement userPasswordFieldLog = driver.FindElement(By.Id("userPassword"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userPassword")));
            userPasswordFieldLog.SendKeys("dfdsdf");

            IWebElement logButton = driver.FindElement(By.Id("logBtn"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("logBtn")));
            Thread.Sleep(2000);
            logButton.Click();


            //Visszamegy a föoldalra
            driver.Navigate().GoToUrl("http://localhost:4200/");
            IWebElement menuButton3 = driver.FindElement(By.Id("menu-btn"));



            //Lehúzza menüt majd kijelentkezik
            menuButton3.Click();
            Thread.Sleep(5000);

            IWebElement logOutBtn = driver.FindElement(By.Id("logout"));
            logOutBtn.Click();

            menuButton3.Click();
            Thread.Sleep(2000);


            //Lehúzza a menüt majd elmegy a bejelentkezési fülre
            menuButton3.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("loginPage")));
            IWebElement loginPage = driver.FindElement(By.Id("loginPage"));
            loginPage.Click();
            Thread.Sleep(3000);


            //Bejelentkezik megint
            menuButton3.Click();
            IWebElement userNameFieldLog1 = driver.FindElement(By.Id("userName"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userName")));
            userNameFieldLog1.SendKeys("TestingUser22");


            IWebElement userPasswordFieldLog1 = driver.FindElement(By.Id("userPassword"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userPassword")));
            userPasswordFieldLog1.SendKeys("dfdsdf");

            IWebElement logButton1 = driver.FindElement(By.Id("logBtn"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("logBtn")));
            Thread.Sleep(2000);
            logButton1.Click();

            //Visszamegy a föoldalra
            driver.Navigate().GoToUrl("http://localhost:4200/");
            Thread.Sleep(2000);

            //Kiválaszt egy tortát és kosárba rakja
            IWebElement cake1 = driver.FindElement(By.Id("1"));
            cake1.Click();
            Thread.Sleep(2000);

            IWebElement candle = driver.FindElement(By.Id("candle"));
            candle.SendKeys("5");
            Thread.Sleep(1000);

            IWebElement basketBtn = driver.FindElement(By.Id("mybutton"));
            basketBtn.Click();

            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            //Visszamegy a föoldalra
            driver.Navigate().GoToUrl("http://localhost:4200/");
            Thread.Sleep(2000);

            //Kiválaszt egy második tortát is és a kosárba rakja.
            IWebElement cake2 = driver.FindElement(By.Id("5"));
            cake2.Click();
            Thread.Sleep(2000);

            IWebElement candle1 = driver.FindElement(By.Id("candle"));
            candle1.SendKeys("5");
            Thread.Sleep(1000);

            IWebElement basketBtn1 = driver.FindElement(By.Id("mybutton"));
            basketBtn1.Click();

            Thread.Sleep(2000);


            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine("No alert was present.");
            }


            IWebElement menuButton4 = driver.FindElement(By.Id("menu-btn"));
            menuButton4.Click();
            Thread.Sleep(2000);

            //Elmegy a kosárhoz
            IWebElement myBasket = driver.FindElement(By.Id("mybasketBtn"));
            myBasket.Click();
            Thread.Sleep(2000);
            menuButton4.Click();
            Thread.Sleep(2000);

            //Form kitöltése

            IWebElement firstName = driver.FindElement(By.Id("firstName"));
            IWebElement lastName = driver.FindElement(By.Id("lastName"));
            IWebElement phoneNumber = driver.FindElement(By.Id("customerPhoneNumber"));
            IWebElement address = driver.FindElement(By.Id("address"));
            IWebElement email = driver.FindElement(By.Id("customerEmail"));
            IWebElement saveDataBtn = driver.FindElement(By.Id("mybutton"));

            firstName.SendKeys("Mr. TestBotGigaChad");
            lastName.SendKeys("ChadBot");
            phoneNumber.SendKeys("4205656420");
            address.SendKeys("Chad Street 6/66");
            email.SendKeys("gigachad@gmail.com");
            Thread.Sleep(2000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mybutton")));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", saveDataBtn);
            Thread.Sleep(2000);


            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine("No alert was present.");
            }


            Thread.Sleep(4000);
            executor.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(1000);


            //Rendelés leadása
            IWebElement order = driver.FindElement(By.Id("nextBtn"));
            order.Click();
            executor.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(10000);
        }
    }
}
