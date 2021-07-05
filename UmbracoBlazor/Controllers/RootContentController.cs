using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.Implement;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.Routing;
using Umbraco.Cms.Web.Common.UmbracoContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UmbracoBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //public class ValuesController : UmbracoApiController
     public class RootContentController : ControllerBase
    {
        public IContentService ContentService { get; set; }

        public UmbracoHelper Helper;
        public RootContentController(UmbracoHelper _helper, IContentService _contentService)
        {
            Helper = _helper;
            ContentService = _contentService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<IContent> Get()
        {
            var aa = ContentService.GetRootContent();
            yield return aa.FirstOrDefault();
        }
    }
}
