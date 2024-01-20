using System.Net.Mail;

namespace ProyectoFinal.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? CargoEmpleado { get; set; }    
        public int EdadEmpleado { get; set; } 
        public MailAddress? CorreoEmpleado { get; set; }


    }
}
