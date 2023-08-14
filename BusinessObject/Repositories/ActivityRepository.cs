using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        protected readonly ClubMembershipContext _context;

      

        // TODO: Implement your DbContext and actual logic here
        public void Add(Activity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Activity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Activity entity)
        {
            throw new NotImplementedException();
        }
    }
}