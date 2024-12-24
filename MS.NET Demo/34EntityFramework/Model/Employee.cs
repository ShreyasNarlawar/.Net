
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _34EntityFramework.Model
{
        [Table("Employee")]
    public class Employee
    {
        [Key]
        [Column("Eid",TypeName="int")]
        public int Id { get; set; }
        [Column("Ename",TypeName="varchar(20)")]
        public string Name { get; set; }
        [Column("EAddress",TypeName ="varchar(20)")]
        public string Address { get; set; }
    }
}
