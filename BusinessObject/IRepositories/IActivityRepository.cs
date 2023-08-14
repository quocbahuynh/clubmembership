using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IActivityRepository
    {
        IEnumerable<Activity> GetAll();
        Activity GetById(int id);
        void Add(Activity entity);
        void Update(Activity entity);
        void Delete(int id);
    }
}