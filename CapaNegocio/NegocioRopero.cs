using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class NegocioRopero
    {
        DatoRopero dato = new DatoRopero();
        public bool AgregarPrenda(string nombre, string tipoPrenda, string talla, string estado, string codigoPrenda,
                                  string codigoBombero, string materialPrincipal, bool resistenciaAlCalor,
                                  DateTime fechaAdquisicion, string marca, string modelo)
        {
            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipoPrenda))
            {
                throw new ArgumentException("El nombre y tipo de prenda son obligatorios.");
            }

            // Llamada a la capa de datos para guardar la prenda
            return dato.AgregarPrenda(nombre, tipoPrenda, talla, estado, codigoPrenda, codigoBombero, materialPrincipal, resistenciaAlCalor, fechaAdquisicion, marca, modelo);
        }
        public DataTable ObtenerPendas()
        {
            return dato.ObtenerPrendas();
        }

        public DataTable BuscarPrendas(string nombre, string tipoPrenda, string codigoPrenda, string talla, string estado, string codigoBombero,
                                     string materialPrincipal, bool? resistenciaAlCalor, DateTime? fechaAdquisicion, string marca, string modelo)
        {
            return dato.BuscarPrendas(nombre, tipoPrenda, codigoPrenda, talla, estado, codigoBombero, materialPrincipal, resistenciaAlCalor, fechaAdquisicion, marca, modelo);
        }
    }
}
