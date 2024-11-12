using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OOP_FINALS_DEMO
{
    public partial class Form5 : Form
    {
        
        public Form5(int selectedIndex1, int selectedIndex2, ComboBox.ObjectCollection items1, ComboBox.ObjectCollection items2)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(items1.Cast<object>().ToArray());
            comboBox2.Items.AddRange(items2.Cast<object>().ToArray());

            comboBox1.SelectedIndex = selectedIndex1;
            comboBox2.SelectedIndex = selectedIndex2;
        }

        
        public Form5(ListView.ListViewItemCollection itemsFromForm3)
        {
            InitializeComponent();
            PopulateListView(itemsFromForm3);
        }

        private void PopulateListView(ListView.ListViewItemCollection items)
        {
            listView1.Items.Clear();  
            foreach (ListViewItem item in items)
            {
                listView1.Items.Add((ListViewItem)item.Clone());  
            }
        }

        private void Button1_Click01(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string firstColumn = selectedItem.SubItems[0].Text;
                string secondColumn = selectedItem.SubItems[1].Text;

                Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

                if (form2 != null)
                {
           
                    Form6 form6 = new Form6(firstColumn, secondColumn);

                    form6.TopLevel = false;  
                    form6.Dock = DockStyle.Fill;  

                    form2.panel2.Controls.Add(form6);
                    form6.Show();

                    this.Hide();

                    form6.FormClosed += (s, args) => this.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
