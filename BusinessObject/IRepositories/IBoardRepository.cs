using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IBoardRepository
    {
        IEnumerable<Board> GetAll();
        Board GetById(int id);
        void Add(Board entity);
        void Update(Board entity);
        void Delete(int id);
    }
}