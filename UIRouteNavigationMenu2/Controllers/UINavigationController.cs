
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UINavigationController.Models;

namespace WebApplication1.API
{
    public class UINavigationController : ApiController
    {
        private readonly INavMenuService _navMenuService;

        public UINavigationController(INavMenuService navMenuService)
        {
            _navMenuService = navMenuService;
        }

        public IEnumerable<NavMenuItem> Get()
        {
            return _navMenuService.GetMenuItems();
        }
    }
}