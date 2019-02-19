using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wissen.Data;
using Wissen.Model;

namespace Wissen.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> repository;
        public PostService(IRepository<Post> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            var DonationtoDelete = repository.Find(id);
            if (DonationtoDelete != null)
            {
                repository.Delete(DonationtoDelete);
            }
        }

        public Post Find(int id)
        {
            return repository.Find(id);
        }

        public Post Find(Expression<Func<Post, bool>> Where)
        {
            return repository.Find(Where);
        }

        public IEnumerable<Post> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> Where)
        {
            return repository.GetAll(Where);
        }

        public void Insert(Post post)
        {
            repository.Insert(post);
        }

        public void Update(Post post)
        {
            repository.Update(post);
        }
    }
}
