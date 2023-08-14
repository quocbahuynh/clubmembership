using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        void Add(Role entity);
        void Update(Role entity);
        void Delete(int id);
    }
}