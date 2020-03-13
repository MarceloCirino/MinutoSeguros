using MinutoSeguros.TesteMarcelo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguros.TesteMarcelo.Application
{
    public interface IBlogUseCase
    {
       List<Blog> ListarBlog(string feed);
    }
}
