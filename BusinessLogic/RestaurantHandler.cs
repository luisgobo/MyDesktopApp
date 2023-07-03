using DataAccess;
using Entities;
using System;

namespace BusinessLogic
{
    public class RestaurantHandler
    {
        public void AddRestaurant(Restaurant restaurant)
        {
            try
            {
                RestaurantAD.AddRestaurant(restaurant);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditRestaurant(Restaurant restaurant)
        {
            RestaurantAD.EditRestaurant(restaurant);
        }

        public void Deleteestaurant(Restaurant restaurant)
        {
            RestaurantAD.DeleteRestaurant(restaurant);
        }

        public Restaurant[] GetRestaurantById(int restaurantId)
        {
            return RestaurantAD.ListRestaurants();
        }

        public Restaurant[] ListRestaurants()
        {
            return RestaurantAD.ListRestaurants();
        }
    }
}