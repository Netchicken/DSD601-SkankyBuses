namespace DSD601_SkankyBusses.DTO
{
    public class TravelCosts
    {
        //  private Single Ash, Tim, Om, Dun, Inv, Discount;
        //  private string FName, LName;
        //  private int Age, lowerAgeDiscount, UpperAgeDiscount;
        //  private bool IsDisabled, isWeekend;


        public double Ash { get; set; } = 17.99;
        public double Tim { get; set; } = 24.77;
        public double Om { get; set; } = 24.44;
        public double Dun { get; set; } = 35.66;
        public double Inv { get; set; } = 46.00;
        public double Discount { get; set; } = 0.20;

        public int Age { get; set; }
        public int lowerAgeDiscount { get; set; } = 12;
        public int UpperAgeDiscount { get; set; } = 64;

        public string FName { get; set; }
        public string LName { get; set; }

        public bool IsDisabled { get; set; } = false;
        public bool IsWeekend { get; set; } = false;

    }
}
