using Companies.Domain.Aggregates.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Infra.Configurations
{
    internal class CompanyHistoryConfig : IEntityTypeConfiguration<CompanyHistory>
    {
        public void Configure(EntityTypeBuilder<CompanyHistory> builder)
        {
            builder.HasKey(ch => ch.HistoryId);
        }
    }
}
