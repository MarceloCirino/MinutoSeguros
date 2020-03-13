using MinutoSeguros.TesteMarcelo.Domain;
using MinutoSeguros.TesteMarcelo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguros.TesteMarcelo.Application
{
    public class BlogUseCase : IBlogUseCase
    {

        private readonly IBlogData _blogData;

        public BlogUseCase(IBlogData blogData)
        {
            _blogData = blogData;
        }

        public List<Blog> ListarBlog(string feed)
        {
            return _blogData.ListarBlogRepositorio(feed);
        }

    }
}
