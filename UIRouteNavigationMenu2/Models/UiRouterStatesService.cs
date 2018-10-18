using System.Collections.Generic;
using UIRouteNavigationMenu.Models;

namespace UINavigationController.Models
{
    public interface IUiRouterStatesService
    {
        IEnumerable<UiRouterState> GetUiRouteStates();
    }

    public class UiRouterStatesService : IUiRouterStatesService
    {

        void getList(List<NavMenu> menuLevelItems, List<UiRouterState> statesList, string urlParentSegments)
        {

            foreach (var m in menuLevelItems)
            {
                var dot = !string.IsNullOrWhiteSpace(urlParentSegments) ? "." : "";

                statesList.Add(new UiRouterState {
                    Name = $"{urlParentSegments}{dot}{m.Name}",
                    Url = $"/{m.UrlSegment}",
                    TemplateUrl = m.TemplateUrl,
                    Controller = m.Controller,
                    Component = m.Component,
                    Behavior = m.Behavior != NavItemBehavior.None ? m.Behavior.ToString() : "" });
            }

            foreach (var m in menuLevelItems)
            {
                var dot = !string.IsNullOrWhiteSpace(urlParentSegments) ? "." : "";

                getList(m.Children, statesList, $"{urlParentSegments}{dot}{m.Name}");
            }
        }

        public IEnumerable<UiRouterState> GetUiRouteStates()
        {
            var states = new List<UiRouterState>();
            getList(NavMenuService.Menu.Children, states, "");
            return states;


            return new List<UiRouterState>
            {
                new UiRouterState { Name="item 1", Url="/item1", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 2", Url="/item2", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 3", Url="/item3", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 1.item 1_1", Url="/item1_1", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 1.item 1_2", Url="/item1_2", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 1.item 1_3", Url="/item1_3", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 2.item 2_1", Url="/item2_1", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 2.item 2_2", Url="/item2_2", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 2.item 2_3", Url="/item2_3", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 3.item 3_1", Url="/item3_1", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 3.item 3_2", Url="/item3_2", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 3.item 3_3", Url="/item3_3", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr" },
                new UiRouterState { Name="item 1.item 1_1.item 1_1_1", Url="/item1_1_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_1.item 1_1_2", Url="/item1_1_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_1.item 1_1_3", Url="/item1_1_3?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_1.item 1_1_4", Url="/item1_1_4?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_2.item 1_2_1", Url="/item1_2_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_2.item 1_2_2", Url="/item1_2_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_2.item 1_2_3", Url="/item1_2_3?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_2.item 1_2_4", Url="/item1_2_4?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_3.item 1_3_1", Url="/item1_3_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_3.item 1_3_2", Url="/item1_3_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_3.item 1_3_3", Url="/item1_3_3?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 1.item 1_3.item 1_3_4", Url="/item1_3_4?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_1.item 2_1_1", Url="/item2_1_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_1.item 2_1_2", Url="/item2_1_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_1.item 2_1_3", Url="/item2_1_3?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_1.item 2_1_4", Url="/item2_1_4?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_2.item 2_2_1", Url="/item2_2_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_2.item 2_2_2", Url="/item2_2_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_3.item 2_3_1", Url="/item2_3_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 2.item 2_3.item 2_3_2", Url="/item2_3_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_1.item 3_1_1", Url="/item3_1_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_1.item 3_1_2", Url="/item3_1_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_2.item 3_2_1", Url="/item3_2_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_2.item 3_2_2", Url="/item3_2_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_3.item 3_3_1", Url="/item3_3_1?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" },
                new UiRouterState { Name="item 3.item 3_3.item 3_3_2", Url="/item3_3_2?itemId", TemplateUrl="/app/contentTemplate.html", Controller="cntrlr", Behavior="newWindow" }
            };
        }
    }
}
