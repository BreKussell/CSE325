using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            LoadQuotes();
        }

        private void LoadQuotes()
        {
            try
            {
                // You can replace this with reading from a file in the next iterations
                string filePath = "quotes.txt"; // Path to the quotes storage file

                // Example of reading quotes from a file (quotes.txt)
                if (File.Exists(filePath))
                {
                    string[] quotes = File.ReadAllLines(filePath);

                    // Add each quote line to the ListBox (or other display component)
                    foreach (string quote in quotes)
                    {
                        lstQuotes.Items.Add(quote);
                    }
                }
                else
                {
                    MessageBox.Show("No quotes available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quotes: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}
