﻿using Presentation.Entities;
using Presentation.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Presentation.DataAccess
{
    public static class RestaurantAD
    {
        static Restaurant[] restaurants = new Restaurant[20];


        public static void AddRestaurant(Restaurant restaurant) {
            
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
            catch(Exception ex) {
                throw ex;
            }
            
            

        }
        public static void EditRestaurant(Restaurant restaurant) {
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
        public static void DeleteRestaurant(Restaurant restaurant) {
            int index = Array.IndexOf(restaurants, restaurant);
            restaurants[index] = null;
            //Restaurant res = restaurants.Where(x => x.Id == restaurant.Id).FirstOrDefault();
        }
        public static Restaurant[] ListRestaurants() {
            
            return restaurants;
        }
        public static Restaurant GetRestaurants(int restaurantId)
        {
            return restaurants.Where(x => x.Id == restaurantId).FirstOrDefault();
        }

    }
}