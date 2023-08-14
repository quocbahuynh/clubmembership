using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IGradeRepository
    {
        IEnumerable<Grade> GetAll();
        Grade GetById(int id);
        void Add(Grade entity);
        void Update(Grade entity);
        void Delete(int id);
    }
}