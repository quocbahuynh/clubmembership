using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class BoardMember
    {
        public int Id { get; set; }
        public int? BoardId { get; set; }
        public int? MembershipId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }

        public virtual Board Board { get; set; }
        public virtual Membership Membership { get; set; }
    }
}
