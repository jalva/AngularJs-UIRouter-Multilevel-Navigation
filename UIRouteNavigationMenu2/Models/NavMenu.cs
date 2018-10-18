using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIRouteNavigationMenu.Models
{
    public class NavMenu
    {
        public NavMenu()
        {
            Children = new List<NavMenu>();
        }

        public string UrlSegment { get; set; }
        public string TemplateUrl { get; set; }
        public string Controller { get; set; }
        public string Component { get; set; }
        public NavItemBehavior Behavior { get; set; }
        public List<NavMenu> Children { get; set; }

        private string _name;
        public string Name {
            set
            {
                _name = value;
            }
            get
            {
                if (!string.IsNullOrEmpty(_name))
                    return _name;
                return UrlSegment;
            }
        }
    }

    public enum NavItemBehavior
    {
        None,
        newWindow
    }
}