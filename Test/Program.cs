using System;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Models;
using ClubMemebership_QuocHB_WebRazorPage.Repo.Repositories;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ClubMembershipContext();
            var majorRepository = new MajorRepository(context);

            var newMajor = new Major
            {
                Name = "HIHIHIHII",
                Code = "CS",
                IsActive = true
            };

            majorRepository.Add(newMajor);
        }
    }
}
