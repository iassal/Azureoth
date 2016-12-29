
using System;
using System.Collections.Generic;
using Azureoth.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Azureoth.Database.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(AzureothDbContext context) : base(context)
        {
        }
    }
}
