using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UINavigationController.Models
{
    public class UiRouterState
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string TemplateUrl { get; set; }
        public string Controller { get; set; }
        public string Behavior { get; set; }
        public string Component { get; set; }
        public string Resolver { get; set; }
    }
}
