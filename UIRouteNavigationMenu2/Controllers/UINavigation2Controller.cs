
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UINavigation2Controller.Models2;

namespace WebApplication1.API
{
    public class UINavigation2Controller : ApiController
    {
        private readonly INavMenuService _navMenuService;

        public UINavigation2Controller(INavMenuService navMenuService)
        {
            _navMenuService = navMenuService;
        }

        public IEnumerable<NavMenuItem> Get()
        {
            return _navMenuService.GetMenuItems();
        }
    }
}