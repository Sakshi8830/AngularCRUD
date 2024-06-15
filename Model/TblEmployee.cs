using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppiCoreCrudProject.Model
{
    public class TblEmployee
    {
        [Key]//for primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generated id
        public int Id { get; set; }

        [StringLength(150)]//for varchar length
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Doj { get; set; }

        [StringLength(30)]
        public string Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationId { get; set; }

        [NotMapped]//we would not like to insert this coloumn in database
        public string Designation { get; set; }

    }
}
