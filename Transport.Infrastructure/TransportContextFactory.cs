﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Transport.Infrastructure
{
    public class TransportContextFactory : IDesignTimeDbContextFactory<TransportContext>
    {
        public TransportContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransportContext>();

            // ⚠️ Заміни рядок підключення на свій
            optionsBuilder.UseSqlite("Data Source=transport.db");

            return new TransportContext(optionsBuilder.Options);
        }
    }
}
