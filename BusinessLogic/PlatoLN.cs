using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class PlatoLN
    {
        public void AgregarPlato(Plato Plato)
        {
            try
            {
                PlatoAD.AgregarPlato(Plato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditarPlato(Plato Plato)
        {
            PlatoAD.EditarPlato(Plato);
        }

        public void BorrarPlato(Plato Plato)
        {
            PlatoAD.BorrarPlato(Plato);
        }

        public Plato[] ObtenerPlatoPorId(int PlatoId)
        {
            return PlatoAD.ListarPlatos();
        }

        public Plato[] ListarPlatos()
        {
            
            return PlatoAD.ListarPlatos();
        }

        public List<Plato> ListarPlatosSeleccionados(List<int> listaIdsPlatosSeleccionados)
        {
            return PlatoAD.ListarPlatos().Where(plato => listaIdsPlatosSeleccionados.Contains(plato.Id)).ToList();
        }
    }
}