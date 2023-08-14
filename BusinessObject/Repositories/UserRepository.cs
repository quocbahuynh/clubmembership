using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class UserRepository : IUserRepository
    {
    private ClubMembershipContext context;
 
            public UserRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}