using Entities;
using System;
using System.Linq;

namespace DataAccess
{
    public static class RestauranteAD
    {
        static Restaurant[] restaurants = new Restaurant[20];

        public static void AddRestaurant(Restaurant restaurant)
        {
            int index = 0;
            bool isFull = true;

            try
            {
                for (int i = 0; i < restaurants.Count(); i++)
                {
                    if (restaurants[i] == null)
                    {
                        index = i;
                        isFull = false;
                        restaurant.Id = i;
                        break;
                    }
                }

                if (!isFull)
                    restaurants[index] = restaurant;
                else
                    throw new Exception("La lista esta llena, elimine un registro para guardar uno nuevo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EditRestaurant(Restaurant restaurant)
        {
            //Restaurant res= restaurants.Where(x => x.Id == restaurant.Id).FirstOrDefault();
            int index = Array.IndexOf(restaurants, restaurant);
            try
            {
                restaurants[index] = restaurant;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteRestaurant(Restaurant restaurant)
        {
            int index = Array.IndexOf(restaurants, restaurant);
            restaurants[index] = null;
            //Restaurant res = restaurants.Where(x => x.Id == restaurant.Id).FirstOrDefault();
        }

        public static Restaurant[] ListRestaurants()
        {
            Restaurant[] restaurante = new Restaurant[2];
            restaurante[0] = new Restaurant(1, "Restaurante Entre nubes", "El restaurante mas lindo del mundo", true) ;
            restaurante[1] = new Restaurant(2,"Restaurante como en casa", "Mejor que la comida de la abuela", true);
            return restaurante;
            //return restaurants;
        }

        public static Restaurant GetRestaurants(int restaurantId)
        {
            return restaurants.Where(x => x.Id == restaurantId).FirstOrDefault();
        }
    }
}