using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Membership
    {
        public Membership()
        {
            BoardMembers = new HashSet<BoardMember>();
            Participants = new HashSet<Participant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? StudentId { get; set; }
        public int? ClubId { get; set; }
        public DateTime? JoinDate { get; set; }
        public string NickName { get; set; }
        public string Code { get; set; }
        public string Bio { get; set; }
        public string Avatar { get; set; }
        public bool IsActive { get; set; }

        public virtual Club Club { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<BoardMember> BoardMembers { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
