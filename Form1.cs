using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using static _4.Form1;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4
{
    public partial class Form1 : Form
    {
        string fileName = "D:\\МПУ\\2 курс\\4 семестр\\БД\\4\\4\\my.json";
        public Form1()
        {
            InitializeComponent();
            UpdateTextBoxes();
        }

        public class Person
        {
            
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
        }
        
        public class People
        {
            public List<Person> people { get; set; }
        }

        public void UpdateTextBoxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            string json = File.ReadAllText(fileName);

            var peoplee = JsonConvert.DeserializeObject<People>(json);
            foreach (var person in peoplee.people)
            {
                listBox1.Items.Add(person.firstName);
                listBox2.Items.Add(person.lastName);
                listBox3.Items.Add(person.age);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void dobavlenie_Click(object sender, EventArgs e)
        {
            string fn = textBox1.Text;
            string ln = textBox2.Text;
            int ag = Convert.ToInt32(textBox3.Text);
            var newPerson = new JObject
                {
                    {"firstname", fn},
                    {"lastname", ln},
                    {"age", ag}
                };
            var json = File.ReadAllText(fileName);
            var jObject = JObject.Parse(json);
            var peopleArray = (JArray)jObject["people"];
            peopleArray.Add(newPerson);
            File.WriteAllText(fileName, jObject.ToString());
            UpdateTextBoxes();
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            string str = "{" + "\"people\":" + "[ ]" +
            "}";
            File.WriteAllText(fileName, str);
            UpdateTextBoxes();
        }

        private void exittheprog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
