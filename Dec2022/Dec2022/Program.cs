using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//open chrome browser
IWebDriver driver = new ChromeDriver();   //open the browser
driver.Manage().Window.Maximize();

//launch turnUp portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify psw textbox and enther psw
IWebElement pswTextbox = driver.FindElement(By.Id("Password"));
pswTextbox.SendKeys("123123");

//click login button
//  Chrome //*[@id="loginForm"]/form/div[3]/input[1]  
//  Firefox full XPath: /html/body/div[4]/div/div/section/form/div[3]/input[1]

//IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));  //VS adds \ back slash before double quote automatically
driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")).Click();

/*
 * Test
 */
//check if user has logged in successfully
IWebElement helloUser = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
//<a>

if (helloUser.Text == "Hello hari!")
{
    Console.WriteLine("-- logged in successfully, test passed");
}
else
{
    Console.WriteLine("-- login failed");
}