using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNCRodigues.Entidad
{
    public class Orden
    {
            
        [StringLength(50, ErrorMessage = "El campo Vehiculo no puede tener más de 50 caracteres.")]
        public string Vehiculo { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "El campo Dominio es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Dominio no puede tener más de 50 caracteres.")]
        public string Dominio { get; set; }
        public DateTime Fecha { get; set; }
        public int Telefono { get; set; }
        public bool Nafta { get; set; }
        public bool CortaCorriente { get; set; }
        public string Detalles { get; set; }
        public string Falla { get; set; }
        public int Presupuesto { get; set; }
        public bool ConfirmoCliente { get; set; }
        public string TrabajoRealizado { get; set; }
        public bool AvisadoParaRetirar { get; set; }
        public string Total { get; set; }


    }
}
