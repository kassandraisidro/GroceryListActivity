using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace GroceryListActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("shoppinglist.json"))
            {             
                string json = File.ReadAllText("shoppinglist.json");

                List<string> groceries = JsonConvert.DeserializeObject<List<string>>(json);
          
                GroceryListBox.Items.Clear();
                foreach (string item in groceries)
                {
                    GroceryListBox.Items.Add(item);
                }
            }
            else
            {              
                GroceryListBox.Items.Add("No grocery list found.");
            }
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();           
            form2.FormClosed += (s, args) => Form1_Load(null, null);
            form2.Show();
        }
    }
}
