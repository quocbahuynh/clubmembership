using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Student
    {
        public Student()
        {
            Memberships = new HashSet<Membership>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MajorId { get; set; }
        public int? GradeId { get; set; }
        public bool IsActive { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Major Major { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
