using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MD2._0ffline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<SOD_InboundDirectiveHeader> SOD_InboundDirectiveHeader { get; set; }
        public DbSet<SOD_InboundDirectiveLine> SOD_InboundDirectiveLine { get; set; }
    }
}
