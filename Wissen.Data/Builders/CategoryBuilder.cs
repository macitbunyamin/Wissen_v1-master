using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissen.Model;

namespace Wissen.Data.Builders
{
    public class CategoryBuilder
    {
        public CategoryBuilder(EntityTypeConfiguration<Category> entity)
        {
            entity.Property(c => c.Name).IsRequired().HasMaxLength(200);
            entity.Property(c => c.Description).HasMaxLength(2000);
        }
    }
}
