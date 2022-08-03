using DSD601_SkankyBusses.DTO;
using DSD601_SkankyBusses.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSD601_SkankyBusses.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public TravelCosts travelCosts = new TravelCosts();
        public List<string> CityFares = new List<string>();



        public void OnPost(TravelCosts travelCosts)
        {
            CityFares.AddRange(CalculateDiscount(travelCosts));
        }



        private List<string> CalculateDiscount(TravelCosts _travelCosts)
        { // if person is disabled, or <12 or >64 gets discount 20%
          //calculate criteria for discount price

            //otherwise they pay the full price

            if (_travelCosts.IsWeekend == true || _travelCosts.IsDisabled == true || _travelCosts.Age <= _travelCosts.lowerAgeDiscount || _travelCosts.Age >= _travelCosts.UpperAgeDiscount)
            {
                _travelCosts.Ash = DiscountFormula(_travelCosts.Ash, _travelCosts.Discount);
                _travelCosts.Tim = DiscountFormula(_travelCosts.Tim, _travelCosts.Discount);
                _travelCosts.Om = DiscountFormula(_travelCosts.Om, _travelCosts.Discount);
                _travelCosts.Dun = DiscountFormula(_travelCosts.Dun, _travelCosts.Discount);
                _travelCosts.Inv = DiscountFormula(_travelCosts.Inv, _travelCosts.Discount);
            }

            // Display output
            StaticList.StaticCityFares.Add(_travelCosts.FName + " " + _travelCosts.LName + " Ash=" + _travelCosts.Ash + " Tim=" + _travelCosts.Tim + " Om=" + _travelCosts.Om + " Dun=" + _travelCosts.Dun + " Inv=" + _travelCosts.Inv);

            return StaticList.StaticCityFares;
        }

        public double DiscountFormula(double City, double Discount)
        {
            double answer = City - (City * Discount);
            return Math.Round(answer, 2);
        }




        //DRY = Don't Repeat Yourself 










    }
}