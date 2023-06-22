using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Bot


{
    public partial class Form1 : Form
    {
        IWebDriver driver;


       
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:/Program Files/Google/Chrome");
            driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl("http://facebook.com");
            IWebElement mail = driver.FindElement(By.Id("email"));
            IWebElement password = driver.FindElement(By.Id("pass"));
            IWebElement button = driver.FindElement(By.Name("login"));
            mail.SendKeys(mailText.Text);
            password.SendKeys(textPass.Text);
            button.Click();
            //driver.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}