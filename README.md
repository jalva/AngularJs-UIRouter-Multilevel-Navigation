# UIRouterMultilevelNavigation
An AngularJs and UIRouter multilevel navigation menu easily declared on the server-side

An example showing one approach on how to programmatically build a multilevel navigation menu. This approach can be useful when this menu is declared in a database or a json file. It can easily incorporate logic to filter out the menu items that a user is allowed to see based on access rules.

![multilevel navigation menu](https://github.com/jalva/UIRouterMultilevelNavigation/blob/master/multiLevelMenu.PNG)

The above menu shown can be declared using html similar to this:
```
<div class="container">
    <div class="row">
        <div class="col-sm-9 col-md-11">

            <!-- Top Menu -->
            <nav-menu level="1"></nav-menu>

            <!-- Sub Menu -->
            <nav-menu level="2"></nav-menu>

        </div>
    </div>
    <div class="row">
        <div class="col-sm-3 col-md-2">
            <nav class="navbar navbar-default side-nav">

                <!-- Side Menu-->
                <nav-menu level="3"></nav-menu>

            </nav>
        </div>
        <div class="col-sm-9 col-md-10" style="">

            <!-- The Main Content -->
            <ui-view></ui-view>

        </div>
    </div>
</div>
```

Example declaring a nav menu in C#:
```
new NavMenu
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
```
