using System;
using System.Collections.Generic;

#nullable disable

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Models
{
    public partial class Board
    {
        public Board()
        {
            BoardMembers = new HashSet<BoardMember>();
        }

        public int Id { get; set; }
        public int? ClubId { get; set; }

        public virtual Club Club { get; set; }
        public virtual ICollection<BoardMember> BoardMembers { get; set; }
    }
}
