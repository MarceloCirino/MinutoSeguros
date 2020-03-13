using MinutoSeguros.TesteMarcelo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinutoSeguros.TesteMarcelo.Domain
{
    public interface IBlogData
    {
        List<Blog> ListarBlogRepositorio(string feed);
    }
}
