using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IMajorRepository
    {
        IEnumerable<Major> GetAll();
        Major GetById(int id);
        void Add(Major entity);
        void Update(Major entity);
        void Delete(int id);
    }
}