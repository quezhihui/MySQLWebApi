using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLWebApi.Models
{
    public class User
    {
        [Key] //主键 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserUID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

    }
}
