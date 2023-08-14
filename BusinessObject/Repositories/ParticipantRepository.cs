using System;
using System.Collections.Generic;
using System.Linq;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using  ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories;

namespace ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
    private ClubMembershipContext context;
 
            public ParticipantRepository(ClubMembershipContext context)
            {
                this.context = context;
            }
        // TODO: Implement your DbContext and actual logic here
public void Add(Participant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Participant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Participant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Participant entity)
        {
            throw new NotImplementedException();
        }
    }
}