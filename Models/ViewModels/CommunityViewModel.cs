using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class CommunityViewModel
    {
        public IEnumerable<CommunityMembership> CommunityMemberships { get; set; }
        public IEnumerable<Community> Communities { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
