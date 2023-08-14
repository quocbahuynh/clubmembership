using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
    private ClubMembershipContext context;
 
            public StudentRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}