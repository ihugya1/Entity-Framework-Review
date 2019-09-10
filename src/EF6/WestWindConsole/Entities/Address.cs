using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    
     
        [Table("Addresses", Schema = "dbo")]// dbo is the default
    class Address
    {
            [Key] //  This property/column is a PK in the database
            public int AddressID { get; set; }

            [Required] // Use this for string/varchar columns that are NOT NULL
            [StringLength(60, ErrorMessage = "Address cannot be more than 60 characters long")]
            public string address { get; set; }

            [Required]
            [StringLength(15, ErrorMessage = "City cannot be more than 60 characters long")]
            public string City { get; set; }

            [StringLength(15, ErrorMessage = "Region cannot be more than 15 characters long")]
            public string Region { get; set; }

            [StringLength(10, ErrorMessage = "Postal Code has a maximum of 10 characters")]
            public string PostalCode { get; set; }

            [Required]
            [StringLength(15, ErrorMessage = "Country cannot be more than 15 characters long")]
            public string Country { get; set; }

        // TODO: Introducing Navigation Properties
        // The virutal keyword allows our entity to support
        // "lazy loading".
        // The ICollection<T> is an interface data type.
        // The HashSet<T> is a class that "implements" the
        // ICollection<T> interface.
       // public virtual Address Address { get; set; }

    }
}

