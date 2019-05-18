using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
namespace Selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenQA.Selenium.Chrome.ChromeDriver driver;
        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtAranacakKelime.Text))
                {
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.google.com/search?q=" + txtAranacakKelime.Text);
                    //Sonuçları döndür
                    int toplam = driver.FindElements(By.TagName("cite")).Count;
                    for (int i = 0; i < toplam; i++)
                    {
                        ReadOnlyCollection<IWebElement> Liste = driver.FindElements(By.XPath("//*[@id='rso']/div/div/div[" + i + "]/div/div/div[1]/a[1]"));
                        foreach (IWebElement result in Liste)
                        {
                            string link = result.GetAttribute("href");
                            lstSonuclar.Items.Add(link);
                        }
                    }
                }
                else MessageBox.Show("Lütfen aranacak bir kelime giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
