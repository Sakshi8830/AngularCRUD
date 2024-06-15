using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppiCoreCrudProject.Model
{
    public class TblDesignation
    {
        [Key]//for primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generated id
        public int Id { get; set; }
        public string Designation { get; set; }

    }
}
