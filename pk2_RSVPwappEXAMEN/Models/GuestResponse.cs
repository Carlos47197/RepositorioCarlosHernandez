using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pk2_RSVPwapp.Models;
using System.ComponentModel.DataAnnotations;

namespace pk2_RSVPwapp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Por favor ingrese su nombre.")]
        public string Name { get; set; }

        [Required(ErrorMessage="Por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Por favor ingrese un correo valido")]
        public string Email { get; set; }

        [Required(ErrorMessage="Por favor ingrese su telefono.")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Por favor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }
    
    }

}