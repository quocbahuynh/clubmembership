using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class BoardRepository : IBoardRepository
    {
    private ClubMembershipContext context;
 
            public BoardRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Board entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> GetAll()
        {
            throw new NotImplementedException();
        }

        public Board GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Board entity)
        {
            throw new NotImplementedException();
        }
    }
}