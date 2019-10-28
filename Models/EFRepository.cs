using System.Collections.Generic;
using PartyInvites.Models;

namespace InvitesProject.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IEnumerable<GuestResponse> Responses => context.Invites;
        public void AddResponse(GuestResponse response)
        {
            context.Invites.Add(response);
            context.SaveChanges();
        }
    }
}