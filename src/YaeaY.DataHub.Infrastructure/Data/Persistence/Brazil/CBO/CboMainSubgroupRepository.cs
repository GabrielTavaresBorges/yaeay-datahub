using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YaeaY.DataHub.Infrastructure.Data.Context;

namespace YaeaY.DataHub.Infrastructure.Data.Persistence.Brazil.CBO;

public sealed class CboMainSubgroupRepository : ICboMainSubgroupRepository
{
    private readonly AppDbContext _context;

    public CboMainSubgroupRepository(AppDbContext context)
    {
        _context = context;
    }
}
