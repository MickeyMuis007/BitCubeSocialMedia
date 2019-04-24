using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.Models.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Friends = new List<FriendViewModel>();
            NotFriends = new List<FriendViewModel>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<FriendViewModel> Friends { get; set; }
        public IEnumerable<FriendViewModel> NotFriends { get; set; }
    }
}
