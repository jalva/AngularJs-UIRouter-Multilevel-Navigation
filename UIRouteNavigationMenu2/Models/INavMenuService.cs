
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<NavMenuItem> GetMenuItems()
        {
            // To do: get this from the database and apply security permissions filtering

            return new List<NavMenuItem>
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
            };
        }
    }
}
