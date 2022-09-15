using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using University.Classes;


namespace University.Classes
{
    public class Subject
    {
        public int Id { get; set; }
        [MaxLength(45)]
        public string Subj_Name { get; set; }
        public int Hour { get; set; }
        public int Semestr { get; set; }
        public override string ToString()
        {
            return Subj_Name;
        }
    }
}
