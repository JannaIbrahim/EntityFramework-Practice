using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFcoreP1.Entities
{
    class Employee
    {
        [Key]
        [Required]
        public int EmpID { get; set; }

        [Required]
        [Column(TypeName= "varchar")]
        [MaxLength(50)]
        public string Name  { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Range(18,50)]
        public int? Age { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual Department Department { get; set; }
    }
}
