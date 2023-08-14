using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Club
    {
        public Club()
        {
            Activities = new HashSet<Activity>();
            Boards = new HashSet<Board>();
            Memberships = new HashSet<Membership>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsActive { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Board> Boards { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
