using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.Models.ViewModels
{
    public class FriendViewModel
    {
        public Guid Friend1Id { get; private set; }
        public Guid Friend2Id { get; private set; }

        public UserViewModel Friend1 { get; set; }
        public UserViewModel Friend2 { get; set; }
    }
}
