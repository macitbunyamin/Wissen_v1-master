using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wissen.Model;

namespace Wissen.Data.Builders
{
    public class PostBuilder
    {
        public PostBuilder(EntityTypeConfiguration<Post> entity)
        {
            entity.Property(p => p.Title).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Description).HasMaxLength(2000);
            entity.HasOptional(p =>p.Category).WithMany(c =>c.Posts).HasForeignKey(p => p.CategoryId);
        }
    }
}
