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
    public partial class Form2 : Form
    {
        List<string> groceryList = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string item = ItemTextBox.Text.Trim();            
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please enter a grocery item.");
                return;
            }          
            if (groceryList.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items only.");
                return;
            }            
            groceryList.Add(item);
            PreviewListBox.Items.Add(item);          
            ItemTextBox.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (groceryList.Count == 0)
            {
                MessageBox.Show("No items to save.");
                return;
            }
           
            string json = JsonConvert.SerializeObject(groceryList, Formatting.Indented);        
            File.WriteAllText("shoppinglist.json", json);
            MessageBox.Show("Grocery list saved successfully!");          
            this.Close();
        }
    }
}
