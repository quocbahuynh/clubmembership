using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class ClubRepository : IClubRepository
    {
    private ClubMembershipContext context;
 
            public ClubRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Club entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Club> GetAll()
        {
            throw new NotImplementedException();
        }

        public Club GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Club entity)
        {
            throw new NotImplementedException();
        }
    }
}