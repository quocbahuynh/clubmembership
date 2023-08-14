using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IParticipantRepository
    {
        IEnumerable<Participant> GetAll();
        Participant GetById(int id);
        void Add(Participant entity);
        void Update(Participant entity);
        void Delete(int id);
    }
}