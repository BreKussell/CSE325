using System;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Event handler for the Add Quote button
        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(); // Create a new instance of the AddQuote form
            addQuoteForm.Show(); // Show the AddQuote form
        }

        // Event handler for the View All Quotes button
        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes(); // Create a new instance of the ViewAllQuotes form
            viewAllQuotesForm.Show(); // Show the ViewAllQuotes form
        }

        // Event handler for the Search Quotes button
        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes(); // Create a new instance of the SearchQuotes form
            searchQuotesForm.Show(); // Show the SearchQuotes form
        }

        // Event handler for the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
