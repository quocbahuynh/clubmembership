using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class MajorRepository : IMajorRepository
    {

        protected readonly ClubMembershipContext db;

        public MajorRepository(ClubMembershipContext _context)
        {
            db = _context;
        }


        // TODO: Implement your DbContext and actual logic here
        public void Add(Major entity)
        {
            db.Majors.Add(entity);
            db.SaveChanges();           
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Major> GetAll()
        {
            throw new NotImplementedException();
        }

        public Major GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Major entity)
        {
            throw new NotImplementedException();
        }
    }
}