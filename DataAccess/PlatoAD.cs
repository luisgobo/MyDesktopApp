using Entities;
using System;
using System.Linq;

namespace DataAccess
{
    public static class PlatoAD
    {
        //static Plato[] Platos = new Plato[20];
        static Plato[] Platos = new Plato[5];

        public static void AgregarPlato(Plato Plato)
        {
            int index = 0;
            bool isFull = true;

            try
            {
                for (int i = 0; i < Platos.Count(); i++)
                {
                    if (Platos[i] == null)
                    {
                        index = i;
                        isFull = false;
                        Plato.Id = i;
                        break;
                    }
                }

                if (!isFull)
                    Platos[index] = Plato;
                else
                    throw new Exception("La lista esta llena, elimine un registro para guardar uno nuevo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EditarPlato(Plato Plato)
        {
            //Plato res= Platos.Where(x => x.Id == Plato.Id).FirstOrDefault();
            int index = Array.IndexOf(Platos, Plato);
            try
            {
                Platos[index] = Plato;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void BorrarPlato(Plato Plato)
        {
            int index = Array.IndexOf(Platos, Plato);
            Platos[index] = null;
            //Plato res = Platos.Where(x => x.Id == Plato.Id).FirstOrDefault();
        }

        public static Plato[] ListarPlatos()
        {
            Platos[0] = new Plato(1, "Arroz con pollo", 2500.00);
            Platos[1] = new Plato(2, "Arroz con camarones", 3000.00);
            Platos[2] = new Plato(3, "Lengua en salsa", 10000.00);
            Platos[3] = new Plato(4, "Pollo al horno", 4000.00);
            Platos[4] = new Plato(5, "Chuileta de cerdo", 6000.00);
            return Platos;
            //return Platos;
        }

        public static Plato GetPlatos(int PlatoId)
        {
            return Platos.Where(x => x.Id == PlatoId).FirstOrDefault();
        }
    }
}