using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Restaurant
    {
        [Required]
        
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public bool Estado { get; set; }

        private string fullInfo;
        public string FullInfo { 
            get {
                return $"{Id}-{Nombre}-{Direccion}";
            } 
        }

        public Restaurant(int id, string name, string direccion, bool status = true)
        {
            Id = id;
            Nombre = name;
            Direccion = direccion;
            Estado = status;
        }        
    }
}