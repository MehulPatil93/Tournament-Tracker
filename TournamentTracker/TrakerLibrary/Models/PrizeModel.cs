using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerLibrary.Models
{
    public    class PrizeModel
    {
        public int Id { get; set; }

        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }


        public PrizeModel()
        {
            
        }
        public PrizeModel(string placeName,string placeNumber,string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            PlaceNumber = Convert.ToInt32( placeNumber);
            PrizeAmount =Convert.ToDecimal( prizeAmount);
            PrizePercentage =Convert.ToDouble( prizePercentage);
        }
    }
}
