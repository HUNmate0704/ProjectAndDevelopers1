﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAndDevelopers1
{

    //     Project
    //      o Id: int (automatikusan növelt)
    //      o ProjectName: string
    //      o Customer: string
    //      o Cost: int
    //      o Developers: Developer lista(LazyLoading)

    internal class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string ProjectName { get; set; }
        [StringLength(100)]
        public string Customer { get; set; }
        public int Cost { get; set; }
        [NotMapped]
        public virtual ICollection<Developer> Developers { get; set; }

    }
}
