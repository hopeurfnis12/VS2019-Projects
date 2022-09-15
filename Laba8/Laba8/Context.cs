using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using University.Classes;

namespace University
{
    public class Context : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Univ> Univ { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Lectures> Lectures { get; set; }
        public DbSet<Exam_Marks> Exam_Marks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=university_2;user=root;password=root;");
        }
    }
}
