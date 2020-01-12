using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Actor
    {

        [Key]
        public int Actor_Id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public DateTime Last_update { get; set; }

        /*
         * 
         * From Actor table
        [actor_id] [int] IDENTITY(1,1) NOT NULL,

        [first_name] [varchar] (45) NOT NULL,

         [last_name] [varchar] (45) NOT NULL,

         [last_update] [datetime]
        NOT NULL,

        */

    }
}
