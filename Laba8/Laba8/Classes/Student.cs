using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using University.Classes;


namespace University.Classes
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(45)]
        public string Surname { get; set; }
        [MaxLength(45)]
        public string Name { get; set; }
        public int Stipend { get; set; }
        public int Kurs { get; set; }
        [MaxLength(45)]
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int UnivId { get; set; }
        public virtual Univ Univ { get; set; }
        public override string ToString()
        {
            return Surname + " " + Name;
        }
    }
}
