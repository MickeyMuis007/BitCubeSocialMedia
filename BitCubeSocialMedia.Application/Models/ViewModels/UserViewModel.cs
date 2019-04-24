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
            Friends = new List<UserViewModel>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<UserViewModel> Friends { get; set; }
    }
}
