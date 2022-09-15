using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using University.Classes;


namespace University.Classes
{
    public class Univ
    {
        public int Id { get; set; }
        [MaxLength(45)]
        public string Univ_Name { get; set; }
        public float Rating { get; set; }
        [MaxLength(45)]
        public string City { get; set; }
        public override string ToString()
        {
            return Univ_Name;
        }
    }
}
