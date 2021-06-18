using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1U_RegistroEmpleados_CN.Models
{
    public class EmployeeRegistration
    {
        [Key]
        [DisplayName("Codigo")]
        public int EmpRegistrationId { get; set; }
        [DisplayName("Nombres")]
        public string EmpRegistrationNames { get; set; }
        [DisplayName("Apellidos")]
        public string EmpRegistrationLastNames { get; set; }
        [DisplayName("Apodo")]
        public string EmpRegistrationNickname { get; set; }
        [DisplayName("Dirección")]
        public string EmpRegistrationDirection { get; set; }
        [DisplayName("Código Postal")]
        public string EmpRegistrationPostalCode { get; set; }
        [DisplayName("Teléfono")]
        public string EmpRegistrationTelephone { get; set; }
        [DisplayName("Celular")]
        public string EmpRegistrationCellPhoneNumber { get; set; }
        [DisplayName("Fax")]
        public string EmpRegistrationFax { get; set; }
        [DisplayName("Email")]
        public string EmpRegistrationEmail { get; set; }
        [DisplayName("Observaciones")]
        public string EmpRegistrationObservations { get; set; }
    }
}
