using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Goodwin
{
    class DeskQuote : Desk
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int RushDays { get; set; }
        public DateTime Date { get; set; }
        public decimal QuoteTotal {get; set; }
        public decimal MaterialPrice { get; set; }
        
       
        public const double BASE_COST = 200;
        public const double DRAWER_COST = 50;
        public const double Ship_Cost = 0;
        public const int ThreeDayRush = 3;
        public const int FiveDayRush = 5;
        public const int SevenDayRush = 7;

        



        public double DeskCost()

        {
            double surfaceArea = DeskWidth * DeskDepth;

            if (surfaceArea < 1000 && Ship_Cost == 0)
                {
                    surfaceArea = Math.Pow(surfaceArea, 2);
                }
            try
            {
                switch (Material)
                {
                    case SurfaceMaterial.Oak:
                        MaterialPrice += 200;
                        break;

                    case SurfaceMaterial.Laminate:
                        MaterialPrice += 100;
                        break;

                    case SurfaceMaterial.Pine:
                        MaterialPrice += 50;
                        break;
                    case SurfaceMaterial.Rosewood:
                        MaterialPrice += 300;
                        break;

                    case SurfaceMaterial.Veneer:
                        MaterialPrice += 125;
                        break;
                    default:
                        throw new Exception("Please select a material.");
                }


            }
            catch (Exception)
            {
                return 50;
            }
            return surfaceArea + BASE_COST + (DRAWER_COST * NumOfDrawers);
                                                   
        }

        public double RushShipping()
        {
            int shipCost = 0;
            double surfaceArea = DeskWidth * DeskDepth;

            // 3 day rush
            if (surfaceArea < 1000 && RushDays == ThreeDayRush)
            {
                shipCost = 60;
            }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000 && RushDays == ThreeDayRush)
            {
                shipCost = 70;
            }
            else if (surfaceArea > 2000 && RushDays == ThreeDayRush)
            {
                shipCost = 80;
            }
            // 5 day rush shipping
            else if (surfaceArea < 1000 && RushDays == FiveDayRush)
            {
                shipCost = 40;
            }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000 && RushDays ==FiveDayRush)
            {
                shipCost = 50;
            }
            else if (surfaceArea < 2000 && RushDays == FiveDayRush)
            {
                shipCost = 60;
            }
            // 7 day rush shipping
            else if (surfaceArea < 1000 && RushDays == SevenDayRush)
            {
                shipCost = 30;
            }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000 && RushDays == SevenDayRush)
            {
                shipCost = 35;
            }
            else if (surfaceArea > 1000 && RushDays == SevenDayRush)
            {
                shipCost = 40;
            }
            return shipCost;
           
        }

        

    }
}
