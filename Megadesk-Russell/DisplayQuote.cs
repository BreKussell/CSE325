using System;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    public partial class DisplayQuote : Form
    {
        // Constructor to accept the DeskQuote object from AddQuote form
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();

            // Display the quote details
            lblCustomerName.Text = quote.CustomerName;
            lblDate.Text = quote.QuoteDate.ToShortDateString();
            lblDeskDimensions.Text = $"{quote.Desk.Width} in x {quote.Desk.Depth} in";
            lblDrawers.Text = quote.Desk.NumberOfDrawers.ToString();
            lblSurfaceMaterial.Text = quote.Desk.SurfaceMaterial.ToString();
            lblRushOrder.Text = $"{quote.RushDays} days";
            lblTotalPrice.Text = $"${quote.QuoteTotal.ToString("0.00")}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form when done
        }
    }
}
