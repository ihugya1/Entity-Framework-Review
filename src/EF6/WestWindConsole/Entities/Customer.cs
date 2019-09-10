using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Customers", Schema = "dbo")]// dbo is the default
    class Customer
    {
        [Key] //  This property/column is a PK in the database
        public int CustomerId { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL

        public string CompanyName { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public string ContactName { get; set; }

        
        public string ContactTitle { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public string ContactEmail { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public int AddressId { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public string Phone { get; set; }

        public string Fax { get; set; }





        // TODO: Introducing Navigation Properties
        // The virutal keyword allows our entity to support
        // "lazy loading".
        // The ICollection<T> is an interface data type.
        // The HashSet<T> is a class that "implements" the
        // ICollection<T> interface.
        public virtual ICollection<Customer> Customers { get; set; } =
            new HashSet<Customer>();
    }
}
