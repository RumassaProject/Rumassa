using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.Abstractions
{
    public interface IRumassaDbContext
    {

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
