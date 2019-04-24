using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.Models.ViewModels
{
    public class FriendViewModel
    {
        public int Id { get; set; }
        public Guid Friend1Id { get; set; }
        public Guid Friend2Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
    }
}
