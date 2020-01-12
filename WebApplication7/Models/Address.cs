using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Address
    {

        [Key]
        [Required]
        public int Address_id { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public int City_id { get; set; }


        public string Postal_code { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set;  }
        [Required]
        public DateTime Last_update { get; set; }


        /*
         * 
         * Database: Address database from Sakila
         * 
        [address_id] [int] IDENTITY(1,1) NOT NULL,

[address1] [varchar] (50) NOT NULL,

 [address2] [varchar] (50) NULL,
	[district] [varchar] (20) NOT NULL,
 
     [city_id] [int] NOT NULL,
 
     [postal_code] [varchar] (10) NULL,
	[phone] [varchar] (20) NOT NULL,
 
     [last_update] [datetime]
        NOT NULL,
            */
    }
}
