using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_Russell
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the AddQuote form and return to the Main Menu
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input and create Desk object
                int width = int.Parse(txtWidth.Text);
                int depth = int.Parse(txtDepth.Text);
                int drawers = int.Parse(txtDrawers.Text);
                string customerName = txtCustomerName.Text;

                // Get selected surface material from ComboBox
                DesktopMaterial surfaceMaterial = (DesktopMaterial)cmbMaterial.SelectedItem;

                // Get selected rush order days from ComboBox
                int rushDays = int.Parse(cmbRushOrder.SelectedItem.ToString());

                // Create a new Desk object
                Desk desk = new Desk
                {
                    Width = width,
                    Depth = depth,
                    NumberOfDrawers = drawers,
                    SurfaceMaterial = surfaceMaterial
                };

                // Create a new DeskQuote object
                DeskQuote quote = new DeskQuote
                {
                    Desk = desk,
                    CustomerName = customerName,
                    RushDays = rushDays,
                    QuoteDate = DateTime.Now
                };

                // Calculate the total quote price
                quote.CalculateQuoteTotal();

                // Open the DisplayQuote form and pass the quote object
                DisplayQuote displayQuoteForm = new DisplayQuote(quote);
                displayQuoteForm.Show();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show("An error occurred while generating the quote: " + ex.Message);
            }
        }

        // Validate the width input
        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            int width;
            if (!int.TryParse(txtWidth.Text, out width) || width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
            {
                e.Cancel = true; // Cancel the event
                txtWidth.Focus(); // Set focus on the textbox
                errorProvider1.SetError(txtWidth, "Please enter a valid width between 24 and 96 inches.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtWidth, ""); // Clear the error
            }
        }

        // Validate the depth input
        private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent invalid input
                errorProvider1.SetError(txtDepth, "Please enter a valid number for depth.");
            }
            else
            {
                errorProvider1.SetError(txtDepth, ""); // Clear the error
            }
        }

        // Form Load event to populate ComboBoxes
        private void AddQuote_Load(object sender, EventArgs e)
        {
            // Populate material ComboBox with enum values
            cmbMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));

            // Populate rush order ComboBox with predefined options
            List<int> rushOrderOptions = new List<int> { 3, 5, 7 };
            cmbRushOrder.DataSource = rushOrderOptions;
        }
    }
}
