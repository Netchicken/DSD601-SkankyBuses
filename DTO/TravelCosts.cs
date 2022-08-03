namespace DSD601_SkankyBusses.DTO
{
    public class TravelCosts
    {
        //  private Single Ash, Tim, Om, Dun, Inv, Discount;
        //  private string FName, LName;
        //  private int Age, lowerAgeDiscount, UpperAgeDiscount;
        //  private bool IsDisabled, isWeekend;


        public Single Ash { get; set; }
        public Single Tim { get; set; }
        public Single Om { get; set; }
        public Single Dun { get; set; }
        public Single Inv { get; set; }
        public Single Discount { get; set; }

        public int Age { get; set; }
        public int lowerAgeDiscount { get; set; }
        public int UpperAgeDiscount { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }

        public bool IsDisabled { get; set; }
        public bool IsWeekend { get; set; }

    }
}
