
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIRouteNavigationMenu.Models;

namespace UINavigationController.Models
{
    /// <summary>
    /// Builds the json used by the navigation menu angular component.
    /// This is where the navigation menu items get filtered by their security permissions.
    /// </summary>
    public interface INavMenuService
    {
        List<NavMenuItem> GetMenuItems();
    }

    public class NavMenuService : INavMenuService
    {
        static NavMenu _menu;
        public static NavMenu Menu
        {
            get
            {
                if (_menu == null)
                {
                    _menu = new NavMenu
                    {
                        UrlSegment = "", // root, leave blank

                        #region Level 1 menu items
                        Children = new List<NavMenu>
                        {
                            new NavMenu
                            {
                                UrlSegment = "level-1_1",
                                TemplateUrl = "/app/contentTemplate.html",
                                Controller = "cntrlr",

                                #region Level 2 menu items, children of level 1 item 1
                                Children = new List<NavMenu>
                                {
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_1",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",

                                        #region Level 3 menu items, children of level 2 item 1
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                Name = "level-3_1",
                                                UrlSegment = "level-3_1?itemId",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                            new NavMenu
                                            {
                                                Name = "level-3_2",
                                                UrlSegment = "level-3_2?itemId",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                        }
                                        #endregion
                                    },
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_2",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",

                                        #region Level 3 menu items, children of level 2 item 2
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_3"
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_4"
                                            },
                                        }
                                        #endregion
                                    },
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_3",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",

                                        #region Level 3 menu items, children of level 2 item 3
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_5"
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_6"
                                            },
                                        }
                                        #endregion
                                    }
                                }
                                #endregion level 2, children of level 1 item 1
                            },
                            new NavMenu
                            {
                                UrlSegment = "level-1_2",
                                TemplateUrl = "/app/contentTemplate.html",
                                Controller = "cntrlr",

                                #region Level 2 menu items, children of level 1 item 2
                                Children = new List<NavMenu>
                                {
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_4",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",

                                        #region Level 3 menu items, children of level 2 item 2
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_7",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_8",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                        }
                                        #endregion
                                    },
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_5",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",

                                        #region Level 3 menu items, children of level 2 item 3
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_9",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_10",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                        }
                                        #endregion
                                    }
                                }
                                #endregion
                            },
                            new NavMenu
                            {
                                UrlSegment = "level-1_3",
                                TemplateUrl = "/app/contentTemplate.html",
                                Controller = "cntrlr",

                                #region Level 2 menu items, children of level 1 item 3
                                Children = new List<NavMenu>
                                {
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_6",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_11",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_12",
                                                Behavior = NavItemBehavior.newWindow
                                            },
                                        }
                                    },
                                    new NavMenu
                                    {
                                        UrlSegment = "level-2_7",
                                        TemplateUrl = "/app/contentTemplate.html",
                                        Controller = "cntrlr",
                                        Children = new List<NavMenu>
                                        {
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_13"
                                            },
                                            new NavMenu
                                            {
                                                UrlSegment = "level-3_14"
                                            },
                                        }
                                    }
                                }
                                #endregion
                            }
                        }
                        #endregion level 1
                    };
                }

                return _menu;

            }
        }
        


        void getList(List<NavMenu> menuLevelItems, List<NavMenuItem> statesList, int level, string urlParentSegments)
        {

            foreach (var m in menuLevelItems)
            {
                var dot = !string.IsNullOrWhiteSpace(urlParentSegments) ? "." : "";

                statesList.Add(new NavMenuItem {
                    Name = m.Name,
                    Level = level,
                    State = $"{urlParentSegments}{dot}{m.Name}" });
            }

            foreach (var m in menuLevelItems)
            {
                var dot = !string.IsNullOrWhiteSpace(urlParentSegments) ? "." : "";

                getList(m.Children, statesList, level + 1, $"{urlParentSegments}{dot}{m.Name}");
            }
        }


        public List<NavMenuItem> GetMenuItems()
        {
            var states = new List<NavMenuItem>();
            getList(_menu.Children, states, 1, "");
            return states;


            // this here is just for illustrative purposes to show what the list will look like
            /*return new List<NavMenuItem>
            {
                new NavMenuItem {Name="item 1", Level=1, State="item 1" },
                new NavMenuItem {Name="item 2", Level=1, State="item 2" },
                new NavMenuItem {Name="item 3", Level=1, State="item 3.item 3_1" },
                new NavMenuItem {Name="item 1_1", Level=2, State="item 1.item 1_1" },
                new NavMenuItem {Name="item 1_2", Level=2, State="item 1.item 1_2" },
                new NavMenuItem {Name="item 1_3", Level=2, State="item 1.item 1_3" },
                new NavMenuItem {Name="item 2_1", Level=2, State="item 2.item 2_1" },
                new NavMenuItem {Name="item 2_2", Level=2, State="item 2.item 2_2" },
                new NavMenuItem {Name="item 2_3", Level=2, State="item 2.item 2_3" },
                new NavMenuItem {Name="item 3_1", Level=2, State="item 3.item 3_1" },
                new NavMenuItem {Name="item 3_2", Level=2, State="item 3.item 3_2" },
                new NavMenuItem {Name="item 3_3", Level=2, State="item 3.item 3_3" },
                new NavMenuItem {Name="item 1_1_1", Level=3, State="item 1.item 1_1.item 1_1_1" },
                new NavMenuItem {Name="item 1_1_2", Level=3, State="item 1.item 1_1.item 1_1_2" },
                new NavMenuItem {Name="item 1_1_3", Level=3, State="item 1.item 1_1.item 1_1_3" },
                new NavMenuItem {Name="item 1_1_4", Level=3, State="item 1.item 1_1.item 1_1_4" },
                new NavMenuItem {Name="item 1_2_1", Level=3, State="item 1.item 1_2.item 1_2_1" },
                new NavMenuItem {Name="item 1_2_2", Level=3, State="item 1.item 1_2.item 1_2_2" },
                new NavMenuItem {Name="item 1_2_3", Level=3, State="item 1.item 1_2.item 1_2_3" },
                new NavMenuItem {Name="item 1_2_4", Level=3, State="item 1.item 1_2.item 1_2_4" },
                new NavMenuItem {Name="item 1_3_1", Level=3, State="item 1.item 1_3.item 1_3_1" },
                new NavMenuItem {Name="item 1_3_2", Level=3, State="item 1.item 1_3.item 1_3_2" },
                new NavMenuItem {Name="item 1_3_3", Level=3, State="item 1.item 1_3.item 1_3_3" },
                new NavMenuItem {Name="item 1_3_4", Level=3, State="item 1.item 1_3.item 1_3_4" },
                new NavMenuItem {Name="item 2_1_1", Level=3, State="item 2.item 2_1.item 2_1_1" },
                new NavMenuItem {Name="item 2_1_2", Level=3, State="item 2.item 2_1.item 2_1_2" },
                new NavMenuItem {Name="item 2_1_3", Level=3, State="item 2.item 2_1.item 2_1_3" },
                new NavMenuItem {Name="item 2_1_4", Level=3, State="item 2.item 2_1.item 2_1_4" },
                new NavMenuItem {Name="item 2_2_1", Level=3, State="item 2.item 2_2.item 2_2_1" },
                new NavMenuItem {Name="item 2_2_2", Level=3, State="item 2.item 2_2.item 2_2_2" },
                new NavMenuItem {Name="item 2_3_1", Level=3, State="item 2.item 2_3.item 2_3_1" },
                new NavMenuItem {Name="item 2_3_2", Level=3, State="item 2.item 2_3.item 2_3_2" },
                new NavMenuItem {Name="item 3_1_1", Level=3, State="item 3.item 3_1.item 3_1_1" },
                new NavMenuItem {Name="item 3_1_2", Level=3, State="item 3.item 3_1.item 3_1_2" },
                new NavMenuItem {Name="item 3_2_1", Level=3, State="item 3.item 3_2.item 3_2_1" },
                new NavMenuItem {Name="item 3_2_2", Level=3, State="item 3.item 3_2.item 3_2_2" },
                new NavMenuItem {Name="item 3_3_1", Level=3, State="item 3.item 3_3.item 3_3_1" },
                new NavMenuItem {Name="item 3_3_2", Level=3, State="item 3.item 3_3.item 3_3_2" },
            };*/
        }
        
    }
}
