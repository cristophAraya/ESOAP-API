using AutoMapper;
using Cl.Sura.ESoapApi.Helpers.Base;

namespace Cl.Sura.ESoapApi.Controllers.Base
{
    public class BaseController<T> : Microsoft.AspNetCore.Mvc.Controller
    {
        public ILogger<T> logger;
        public IMapper mapper;
        public ISettingsConfig settings { get; set; }
        public IWebHostEnvironment environment { get; set; }
    }
}
