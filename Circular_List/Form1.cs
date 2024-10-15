using System.Collections.Generic;
using System.Xml.Linq;

namespace Circular_List
{
    public partial class Form1 : Form
    {
        List list = new List();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListNodes()
        {
            lstNodes.Items.Clear();
            var nodes = list.Display();
            foreach (var node in nodes)
            {
                lstNodes.Items.Add(node);
            }
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtValue.Text, out int value))
            {
                list.Add(value);
                MessageBox.Show("Node added successfully!");
                txtValue.Clear();
                UpdateListNodes();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void ibtnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                list.Remove(value);
                txtValue.Clear();
                UpdateListNodes();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void ibtnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The linked list contains " + list.Count() + " node(s)");
        }

        private void ibtnContains_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                MessageBox.Show("Enter a valid value");
            }
            else if (list.Contains(int.Parse(txtValue.Text)))
            {
                MessageBox.Show("Value exists in the linked list");
            }
            else
            {
                MessageBox.Show("Value does not exist in the linked list");
            }


        }

     
    }
}
