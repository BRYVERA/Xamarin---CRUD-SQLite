using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CRUDSqlite.Models
{
    public class Alumno
    {
        [PrimaryKey,AutoIncrement]
        public int idAlumno { get; set; }
        [MaxLength(30)]
        public string Nombre { get; set; }
        [MaxLength(30)]
        public string ApellidoPaterno { get; set; }
        [MaxLength(30)]
        public string ApellidoMaterno { get; set; }
        
        public int Edad { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
    }
}
