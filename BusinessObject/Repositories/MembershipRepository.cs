using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class MembershipRepository : IMembershipRepository
    {
    private ClubMembershipContext context;
 
            public MembershipRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Membership entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membership> GetAll()
        {
            throw new NotImplementedException();
        }

        public Membership GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Membership entity)
        {
            throw new NotImplementedException();
        }
    }
}