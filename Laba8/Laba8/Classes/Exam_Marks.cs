using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using University.Classes;


namespace University.Classes
{
    public class Exam_Marks
    {
        public int Id { get; set; }
		public int StudentId { get; set; }
		public virtual Student Student { get; set; }
		public int SubjectId { get; set; }
		public virtual Subject Subject { get; set; }
		public int Mark { get; set; }
		public DateTime Exam_Date { get; set; }
		public override string ToString()
		{
			return Exam_Date.ToString("dd.MM.yyyy");
		}
	}
}
