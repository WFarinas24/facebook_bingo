using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace request
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        async void Getresponse(String url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync();
                            Console.WriteLine(mycontent);
                            label2.Text = mycontent;
                        }
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                MessageBox.Show(e + " ");
               
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getresponse(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
