using DataAccess;
using Entities;
using System;

namespace BusinessLogic
{
    public class RestauranteLN
    {
        public void AddRestaurant(Restaurant restaurant)
        {
            try
            {
                RestauranteAD.AddRestaurant(restaurant);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditRestaurant(Restaurant restaurant)
        {
            RestauranteAD.EditRestaurant(restaurant);
        }

        public void Deleteestaurant(Restaurant restaurant)
        {
            RestauranteAD.DeleteRestaurant(restaurant);
        }

        public Restaurant[] GetRestaurantById(int restaurantId)
        {
            return RestauranteAD.ListRestaurants();
        }

        public Restaurant[] ListRestaurants()
        {
            return RestauranteAD.ListRestaurants();
        }
    }
}