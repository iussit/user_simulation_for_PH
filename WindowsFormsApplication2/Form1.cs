using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.IO;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public List<String> ip = new List<String>();
        IWebDriver Browser;
        string salt = "money";





        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            foreach (var pr in ip)
            {
                for (; ; )
                {
                    try
                    {
                        OpenQA.Selenium.Chrome.ChromeOptions options = new OpenQA.Selenium.Chrome.ChromeOptions();
                        Proxy proxy = new Proxy();
                        proxy.Kind = ProxyKind.Manual;
                        proxy.IsAutoDetect = false;
                        proxy.HttpProxy =
                        proxy.SslProxy = pr.ToString();
                        options.Proxy = proxy;
                        options.AddArgument("ignore-certificate-errors");
                        Browser = new OpenQA.Selenium.Chrome.ChromeDriver(options);

                        Browser.Navigate().GoToUrl("https://www.pornhub.com/signup");

                        try
                        {
                            IWebElement check_captcha = Browser.FindElement(By.ClassName("security"));
                            Browser.Quit();
                            break;
                            //IWebElement captcha = Browser.FindElement(By.ClassName("recaptcha-checkbox-checkmark"));
                            //captcha.Click();
                            //auth(Browser);

                            //break;
                        }
                        catch (Exception ex)
                        {

                            TimeSpan time;
                            IWebElement email = Browser.FindElement(By.Id("email"));
                            IWebElement password = Browser.FindElement(By.Id("password"));
                            IWebElement login = Browser.FindElement(By.Id("username"));
                            IWebElement submit = Browser.FindElement(By.Id("submit_buttom"));

                            String randomchar = "";
                            Random rand = new Random();
                            for (int i = 0; i < 7; i++)
                            {
                                randomchar += (char)rand.Next(97, 122);
                            }

                            email.SendKeys(randomchar + "@mailertop.ru");
                            password.SendKeys(randomchar + salt);
                            login.SendKeys(randomchar);

                            TimeSpan time1;
                            DateTime initial_time = DateTime.Now;
                            for (; ; )
                            {
                                DateTime current_time = DateTime.Now;
                                time1 = current_time - initial_time;
                                //textBox1.Text = time1.Seconds.ToString();
                                if (time1.Seconds > 3) break;
                            }


                            submit.Click();

                            DateTime initial_time5 = DateTime.Now;
                            for (; ; )
                            {
                                DateTime current_time = DateTime.Now;
                                time1 = current_time - initial_time5;
                                //textBox1.Text = time1.Seconds.ToString();
                                if (time1.Seconds > 3) break;
                            }


                            Browser.Navigate().GoToUrl("https://web12.beget.email/?_task=mail&_mbox=INBOX");
                            IWebElement name = Browser.FindElement(By.Id("rcmloginuser"));
                            IWebElement pas = Browser.FindElement(By.Id("rcmloginpwd"));
                            IWebElement sub = Browser.FindElement(By.Id("rcmloginsubmit"));
                            name.SendKeys("admin@mailertop.ru");
                            pas.SendKeys("qwe123asd");
                            sub.Click();

                            IWebElement view = Browser.FindElement(By.Id("messagessearchfilter"));
                            view.Click();


                            List<IWebElement> options_message = Browser.FindElements(By.CssSelector("#messagessearchfilter option")).ToList();
                            foreach (IWebElement op_ms in options_message)
                            {
                                if (op_ms.GetAttribute("value") == "UNSEEN")
                                {
                                    op_ms.Click();
                                    break;
                                }
                            }


                            DateTime initial = DateTime.Now;
                            for (; ; )
                            {
                                DateTime current_time = DateTime.Now;
                                time = current_time - initial;
                                //textBox1.Text = time1.Seconds.ToString();
                                if (time.Seconds > 6) break;
                            }

                            //IWebElement dont_read = view.FindElement(By.LinkText("Непрочитанные"));
                            //dont_read.Click();



                            IWebElement message = Browser.FindElement(By.ClassName("rcmContactAddress"));
                            message.Click();
                            message.Click();
                            IWebElement check_url_mail = Browser.FindElement(By.ClassName("rcmBody"));
                            IWebElement check_url_mail_atr = check_url_mail.FindElement(By.TagName("a"));
                            check_url_mail_atr.Click();



                            DateTime initial_time3 = DateTime.Now;
                            for (; ; )
                            {
                                DateTime current_time = DateTime.Now;
                                time = current_time - initial_time3;
                                //textBox1.Text = time1.Seconds.ToString();
                                if (time.Seconds > 3) break;
                            }


                            // fill profile
                            IWebElement avatar = Browser.FindElement(By.ClassName("smallAvatar"));
                            avatar.Click();
                            IWebElement my_profile_sub = Browser.FindElement(By.ClassName("profile"));
                            my_profile_sub.Click();
                            IWebElement edit_profile = Browser.FindElement(By.ClassName("greyButton usersInteractionBtn"));
                            edit_profile.Click();

                            //profile photo
                            //Random rand = new Random();
                            string photo_name = "_" + rand.Next(1, 383);
                            string photo_file = WindowsFormsApplication2.Properties.Resources.ResourceManager.GetObject(photo_name).ToString();

                            IWebElement edit_profile_picture = Browser.FindElement(By.ClassName("spriteProfileEdit profilePictures"));
                            edit_profile_picture.Click();
                            IWebElement edit_profile_picture_button = Browser.FindElement(By.ClassName("spriteProfileIcons orangeButton float-left editProfileBtn editSprite avatarModalTrigger"));
                            edit_profile_picture_button.Click();
                            IWebElement input_picture = Browser.FindElement(By.ClassName("avtrUploadFile"));
                            input_picture.SendKeys(photo_file);

                        }

                        Browser.Quit();
                    }
                    catch (Exception ex)
                    {
                        Browser.Quit();
                        break;
                    }
                }
            }


        }

        public void auth(IWebDriver Browser)
        {

            IWebElement email = Browser.FindElement(By.Id("email"));
            IWebElement password = Browser.FindElement(By.Id("password"));
            IWebElement login = Browser.FindElement(By.Id("username"));
            IWebElement submit = Browser.FindElement(By.Id("submit_buttom"));

            String randomchar = "";
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                randomchar += (char)rand.Next(97, 122);
            }

            email.SendKeys(randomchar + "@mailertop.ru");
            password.SendKeys(randomchar + salt);
            login.SendKeys(randomchar);

            TimeSpan time1;
            DateTime initial_time = DateTime.Now;
            for (; ; )
            {
                DateTime current_time = DateTime.Now;
                time1 = current_time - initial_time;
                //textBox1.Text = time1.Seconds.ToString();
                if (time1.Seconds > 3) break;
            }
            submit.Click();

            TimeSpan time;
            DateTime initial_time1 = DateTime.Now;
            for (; ; )
            {
                DateTime current_time = DateTime.Now;
                time = current_time - initial_time1;
                //textBox1.Text = time1.Seconds.ToString();
                if (time.Seconds > 4) break;
            }

            //check mail
            Browser.Navigate().GoToUrl("https://web12.beget.email/?_task=mail&_mbox=INBOX");
            IWebElement name = Browser.FindElement(By.Id("rcmloginuser"));
            IWebElement pas = Browser.FindElement(By.Id("rcmloginpwd"));
            IWebElement sub = Browser.FindElement(By.Id("rcmloginsubmit"));
            name.SendKeys("admin@mailertop.ru");
            pas.SendKeys("qwe123asd");
            sub.Click();
            IWebElement message = Browser.FindElement(By.ClassName("rcmContactAddress"));
            message.Click();
            message.Click();
            IWebElement check_url_mail = Browser.FindElement(By.ClassName("rcmBody"));
            IWebElement check_url_mail_atr = check_url_mail.FindElement(By.TagName("a"));
            check_url_mail_atr.Click();
            DateTime initial_time2 = DateTime.Now;
            for (; ; )
            {
                DateTime current_time = DateTime.Now;
                time = current_time - initial_time2;
                //textBox1.Text = time1.Seconds.ToString();
                if (time.Seconds > 40) break;
            }
            //Browser.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog1.FileName;
                //textBox1.Text=path;
                StreamReader file = new StreamReader(path);

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    //user.Add(user.);
                    ip.Add(line);
                    //textBox1.Text += ip;
                }
                file.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       




    }
}
