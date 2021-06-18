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
        [Required(ErrorMessage ="Este campo no debe ir vacío.")]
        [DisplayName("Nombres")]
        [StringLength(70, ErrorMessage ="No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage ="Debe tener mas de 3 caracteres.")]
        public string EmpRegistrationNames { get; set; }
        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Este campo no debe ir vacío.")]
        [StringLength(70, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de 3 caracteres.")]
        public string EmpRegistrationLastNames { get; set; }
        [DisplayName("Nickname")]
        [MinLength(8, ErrorMessage = "Debe tener mas de 8 caracteres.")]
        [StringLength(50, ErrorMessage = "No debe tener mas de 70 caracteres.")]
        [Required(ErrorMessage = "Este campo no debe ir vacío.")]
        public string EmpRegistrationNickname { get; set; }
        [DisplayName("Dirección")]
        [MinLength(15, ErrorMessage = "Debe tener mas de 15 caracteres.")]
        [StringLength(150)]
        public string EmpRegistrationDirection { get; set; }
        [DisplayName("Código Postal")]
        [MinLength(5, ErrorMessage = "Debe tener mas de 5 caracteres.")]
        [StringLength(10)]
        [Required(ErrorMessage = "Este campo no debe ir vacío.")]
        public string EmpRegistrationPostalCode { get; set; }
        [DisplayName("Teléfono")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [MinLength(8, ErrorMessage = "Debe tener mas de 8 caracteres.")]
        [StringLength(15)]
        public string EmpRegistrationTelephone { get; set; }
        [DisplayName("Celular")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [MinLength(8, ErrorMessage = "Debe tener mas de 8 caracteres.")]
        [StringLength(15)]
        public string EmpRegistrationCellPhoneNumber { get; set; }
        [DisplayName("Fax")]
        [MinLength(8, ErrorMessage = "Debe tener mas de 8 caracteres.")]
        [StringLength(15)]
        public string EmpRegistrationFax { get; set; }
        [DisplayName("Email")]
        [StringLength(30)]
        [Required(ErrorMessage = "Este campo no debe ir vacío.")]
        public string EmpRegistrationEmail { get; set; }
        [DisplayName("Observaciones")]
        public string EmpRegistrationObservations { get; set; }
    }
}
