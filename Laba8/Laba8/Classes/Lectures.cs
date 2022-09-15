using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using University.Classes;


namespace University.Classes
{
    public class Lectures
    {
        public int Id { get; set; }
        [MaxLength(45)]
        public string Surname { get; set; }
        [MaxLength(45)]
        public string Name { get; set; }
        [MaxLength(45)]
        public string City { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public override string ToString()
        {
            return Surname + " " + Name;
        }
    }
}
