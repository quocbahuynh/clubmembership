using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class BoardMemberRepository : IBoardMemberRepository
    {
    private ClubMembershipContext context;
 
            public BoardMemberRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(BoardMember entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BoardMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public BoardMember GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(BoardMember entity)
        {
            throw new NotImplementedException();
        }
    }
}