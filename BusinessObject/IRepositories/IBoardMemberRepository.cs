using System.Collections.Generic;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;

 namespace ClubMemebership_QuocHB_WebRazorPage.Repo.IRepositories
{
    public interface IBoardMemberRepository
    {
        IEnumerable<BoardMember> GetAll();
        BoardMember GetById(int id);
        void Add(BoardMember entity);
        void Update(BoardMember entity);
        void Delete(int id);
    }
}