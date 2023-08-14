using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IClubRepository
    {
        IEnumerable<Club> GetAll();
        Club GetById(int id);
        void Add(Club entity);
        void Update(Club entity);
        void Delete(int id);
    }
}