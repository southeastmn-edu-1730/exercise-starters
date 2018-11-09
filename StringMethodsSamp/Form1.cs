using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethodsSamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ---------------- p271 ------------------
            string chars = textBox1.Text;
            char a = chars[0];
            char b = chars[1];
            textBox2.Text = a.ToString();
            textBox3.Text = b.ToString();
            bool startsWithAbc = chars.StartsWith("abc");
            textBox4.Text = startsWithAbc.ToString();
            bool endsWithAbc = chars.EndsWith("abc");
            textBox5.Text = endsWithAbc.ToString();
            string companyName = textBox6.Text;
            textBox7.Text = companyName.IndexOf(" ").ToString();
            textBox8.Text = companyName.IndexOf(' ').ToString();
            textBox9.Text = companyName.IndexOf("Inc.").ToString();
            textBox10.Text = companyName.LastIndexOf(" ").ToString();
            int index1 = companyName.IndexOf(" ");
            companyName = companyName.Remove(0, index1 + 1);
            textBox11.Text = companyName;
            companyName = companyName.Insert(companyName.Length, " Tech");
            textBox12.Text = companyName;
            companyName = companyName.Replace("College", "University");
            textBox13.Text = companyName;
            string firstName = textBox14.Text;
            string firstLetter = firstName.Substring(0, 1).ToUpper();
            string otherLetters = firstName.Substring(1).ToLower();
            firstName = firstLetter + otherLetters;
            textBox15.Text = firstName;
            string s1 = textBox17.Text;
            string s2 = s1;
            s2 = "def";
            textBox16.Text = s1;
            textBox18.Text = textBox19.Text;
            TextBox textBox18b = textBox18;
            textBox18b.Text = "def";

            // ---------------- p273 ------------------
            // IndexOf(), SubString()
            string fullName = textBox20.Text;
            fullName = fullName.Trim();
            int firstSpace = fullName.IndexOf(" ");
            firstName = "";
            if (firstSpace == -1)
                firstName = fullName;
            else
                firstName = fullName.Substring(0, firstSpace);
            textBox21.Text = firstName;

            // IndexOf(), SubString()
            string address = textBox22.Text;
            address = address.Trim(); if (address.StartsWith("|"))
                address = address.Remove(0, 1); if (address.EndsWith("|"))
                address = address.Remove(address.Length - 1, 1);
            int cityIndex = address.IndexOf("|") + 1;
            int stateIndex = address.IndexOf("|", cityIndex) + 1;
            int zipIndex = address.IndexOf("|", stateIndex) + 1;
            textBox23.Text = address.Substring(0, cityIndex - 1);
            textBox24.Text = address.Substring(cityIndex, stateIndex - cityIndex - 1);
            textBox25.Text = address.Substring(stateIndex, zipIndex - stateIndex - 1);
            textBox26.Text = address.Substring(zipIndex);

            // Split()
            string[] names = fullName.Split(' ');
            textBox27.Text = names[0];

            // Split()
            string[] columns = address.Split('|');
            textBox28.Text = columns[0];
            textBox29.Text = columns[1];
            textBox30.Text = columns[2];
            textBox31.Text = columns[3];

            // Insert()
            string phoneNumber = textBox32.Text;
            phoneNumber = phoneNumber.Insert(3, "-");
            phoneNumber = phoneNumber.Insert(7, "-");
            textBox33.Text = phoneNumber;

            // Replace()
            string date = textBox34.Text;
            textBox35.Text = date.Replace("-", "/");

            // StringBuilder
            StringBuilder phoneNumBuilder = new StringBuilder(10);
            phoneNumBuilder.Append(textBox36.Text);
            phoneNumBuilder.Insert(3, ".");
            phoneNumBuilder.Insert(7, ".");
            phoneNumBuilder.Remove(0, 4);
            phoneNumBuilder.Replace(".", "-");
            textBox37.Text = phoneNumber.ToString();
        }
    }
}
