using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazor.Data
{
    //also generated
    public class Backend
    {
        public Guest GetGuest()
        {
            return new Guest
            {
                GuestId = Guid.NewGuid(),
                FirstName = "Brad"
            };
        }
    }
}
