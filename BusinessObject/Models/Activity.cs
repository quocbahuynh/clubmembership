using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Activity
    {
        public Activity()
        {
            Participants = new HashSet<Participant>();
        }

        public int Id { get; set; }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string CoverImage { get; set; }

        public virtual Club Club { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
