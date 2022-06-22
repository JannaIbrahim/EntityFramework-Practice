using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFcoreP1.Entities
{
    class Department
    {
        [Key]
        [Required]
        public int DeptID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }


        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; } = new HashSet<Employee>();


       

    }
}
