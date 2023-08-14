using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Participant
    {
        public int Id { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public int? MembershipId { get; set; }
        public int? ActivityId { get; set; }
        public string Mission { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Membership Membership { get; set; }
    }
}
