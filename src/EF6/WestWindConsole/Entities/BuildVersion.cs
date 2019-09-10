using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
   
        [Table("BuildVersion", Schema = "dbo")]// dbo is the default
        public class BuildVersion
        {
            [Key] //  This property/column is a PK in the database
            public int Id { get; set; }

            [Required] // Use this for string/varchar columns that are NOT NULL
            
            public int Major { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public int Minor { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public int Build { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        public DateTime ReleaseDate { get; set; }

       

            // TODO: Introducing Navigation Properties
            // The virutal keyword allows our entity to support
            // "lazy loading".
            // The ICollection<T> is an interface data type.
            // The HashSet<T> is a class that "implements" the
            // ICollection<T> interface.
            public virtual ICollection<BuildVersion> BuildVersions { get; set; } =
                new HashSet<BuildVersion>();
        }
    }

