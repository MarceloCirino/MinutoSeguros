using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using MinutoSeguros.TesteMarcelo.Application;
using MinutoSeguros.TesteMarcelo.Domain;

namespace MinutoSeguros.TesteMarcelo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IBlogUseCase _blogUseCase;

        public ValuesController(IBlogUseCase blogUseCase)
        {
            _blogUseCase = blogUseCase;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Blog>> Get()
        {
            WebClient wclient = new WebClient();
            string RSSData = wclient.DownloadString("http://www.minutoseguros.com.br/blog/feed/");

            return _blogUseCase.ListarBlog(RSSData);
           
        }

    }
}
