using System;
using OdeToFood;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestuarantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestuarantData
    {
        List<Restaurant> restuarants;
        public InMemoryRestaurantData(){
            restuarants=new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="KFC",Location="Bangalore",Cuisine=CuisineType.Italian},
                new Restaurant{Id=1,Name="Haldiram",Location="Chennai",Cuisine=CuisineType.Indian},
                new Restaurant{Id=1,Name="JKOL",Location="Mumbai",Cuisine=CuisineType.None},
                new Restaurant{Id=1,Name="xcoil",Location="Patna",Cuisine=CuisineType.Mexican}

            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restuarants
                orderby r.Name
                select r;
        }
    }
}