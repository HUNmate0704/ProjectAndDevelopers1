using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAndDevelopers1
{
//     Developer
//      o Id: int (automatikusan növelt)
//      o Name: string
//      o IsStudent: bool
//      o ProjectId: int (idegen kulcs)
//      o Project: Project(LazyLoading)


    internal class Developer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStudent { get; set; }
        public int ProjectId { get; set; }
        [NotMapped]
        public virtual Project Project { get; set; }

    }
}
