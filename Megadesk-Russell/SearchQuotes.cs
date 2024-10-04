using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            PopulateMaterialsComboBox();
        }

        // Populate the ComboBox with available materials
        private void PopulateMaterialsComboBox()
        {
            cmbMaterials.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMaterial = cmbMaterials.SelectedItem.ToString();
                lstSearchResults.Items.Clear(); // Clear previous search results

                string filePath = "quotes.txt"; // Path to the quotes file

                if (File.Exists(filePath))
                {
                    string[] quotes = File.ReadAllLines(filePath);

                    foreach (string quote in quotes)
                    {
                        // Check if the quote contains the selected material
                        if (quote.Contains(selectedMaterial))
                        {
                            lstSearchResults.Items.Add(quote);
                        }
                    }

                    if (lstSearchResults.Items.Count == 0)
                    {
                        MessageBox.Show("No quotes found for the selected material.");
                    }
                }
                else
                {
                    MessageBox.Show("No quotes available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching quotes: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}
