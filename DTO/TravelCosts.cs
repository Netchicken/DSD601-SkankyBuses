using System.ComponentModel.DataAnnotations;

namespace DSD601_SkankyBusses.DTO
{
    public class TravelCosts
    {

        [Display(Name = "Ashburton")]
        public double Ash { get; set; } = 17.99;
        [Display(Name = "Timaru")]
        public double Tim { get; set; } = 24.77;
        [Display(Name = "Oamaru")]
        public double Om { get; set; } = 24.44;
        [Display(Name = "Dunedin")]
        public double Dun { get; set; } = 35.66;
        [Display(Name = "Invercargil")]
        public double Inv { get; set; } = 46.00;
        [Display(Name = "Fare Discount")]
        public double Discount { get; set; } = 0.20;
        [Display(Name = "What is your Age?")]
        public int Age { get; set; }


        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Display(Name = "Are you Disabled?")]
        public bool IsDisabled { get; set; } = false;
        [Display(Name = "Is this the Weekend?")]
        public bool IsWeekend { get; set; } = false;


        //Not shown on form

        [Display(Name = "Lower Age Discount")]
        public int lowerAgeDiscount { get; set; } = 12;
        [Display(Name = "Upper Age Discount")]
        public int UpperAgeDiscount { get; set; } = 64;
    }
}
