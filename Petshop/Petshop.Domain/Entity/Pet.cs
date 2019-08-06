using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Petshop.Domain.Entity
{
    [Table("Pet")]
    public class Pet : Base.Entity
    {
        public string Name { get; set; }
        public  int Year { get; set; }

        public DateTime BirdthDate { get; set; }


    }
}
