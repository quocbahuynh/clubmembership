using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class GradeRepository : IGradeRepository
    {
    private ClubMembershipContext context;
 
            public GradeRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Grade entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grade> GetAll()
        {
            throw new NotImplementedException();
        }

        public Grade GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Grade entity)
        {
            throw new NotImplementedException();
        }
    }
}