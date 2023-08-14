using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IMembershipRepository
    {
        IEnumerable<Membership> GetAll();
        Membership GetById(int id);
        void Add(Membership entity);
        void Update(Membership entity);
        void Delete(int id);
    }
}