using System;

namespace MegaDesk_Russell
{
    public class DeskQuote
    {
        // Desk properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public decimal QuoteTotal { get; set; }

        // Constants for base price and drawer cost
        private const decimal BASE_PRICE = 200;
        private const decimal COST_PER_DRAWER = 50;

        // Calculate the total price of the desk quote
        public decimal CalculateQuoteTotal()
        {
            decimal surfaceArea = Desk.Width * Desk.Depth;
            QuoteTotal = BASE_PRICE;

            // Additional cost for surface area
            if (surfaceArea > 1000)
            {
                QuoteTotal += (surfaceArea - 1000);
            }

            // Cost for drawers
            QuoteTotal += Desk.NumberOfDrawers * COST_PER_DRAWER;

            // Add surface material cost
            switch (Desk.SurfaceMaterial)
            {
                case DesktopMaterial.Laminate:
                    QuoteTotal += 100;
                    break;
                case DesktopMaterial.Oak:
                    QuoteTotal += 200;
                    break;
                case DesktopMaterial.Rosewood:
                    QuoteTotal += 300;
                    break;
                case DesktopMaterial.Veneer:
                    QuoteTotal += 125;
                    break;
                case DesktopMaterial.Pine:
                    QuoteTotal += 50;
                    break;
            }

            // Add rush order cost
            if (RushDays == 3)
            {
                QuoteTotal += 60; // Example cost for rush
            }
            else if (RushDays == 5)
            {
                QuoteTotal += 40;
            }
            else if (RushDays == 7)
            {
                QuoteTotal += 30;
            }

            return QuoteTotal;
        }
    }
}
