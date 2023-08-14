using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
