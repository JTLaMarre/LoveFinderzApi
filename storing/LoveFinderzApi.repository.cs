using System.Collections.Generic;
using System.Linq;
using LoveFinderz.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveFinderz.Storing
{
    public class LoveFinderzRepository
    {
        private LoveFinderzContext _ctx;

        public LoveFinderzRepository(LoveFinderzContext context)
        {
            _ctx = context;
        }
        

    }
}