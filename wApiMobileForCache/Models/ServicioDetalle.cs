using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wApiMobileForCache.Models
{
    public class ServicioDetalle : Servicio
    {
        [Key]
        public decimal HabSalida { get; set; }
        public decimal HabLlegada { get; set; }
        public decimal HabFinal { get; set; }
        public decimal HabCancelacion { get; set; }
        public String FecIncidente { get; set; }
        public String NroAfiliado { get; set; }
        public String Aviso { get; set; }
        public String Partido { get; set; }
        public String EntreCalle1 { get; set; }
        public String EntreCalle2 { get; set; }
        public String Referencia { get; set; }
        public String Sintomas { get; set; }
        public String Paciente { get; set; }
        public String PlanId { get; set; }
        public decimal CoPago { get; set; }
        public String Observaciones { get; set; }
    }
}