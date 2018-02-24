// nav menu component
// one component can be used for any number of menu levels (nested menus), just pass the 'level' property for each instance
// the component knows how to figure out the parent/child relationships based on the actual ui-router states used by the application
// the component knows how to hydrate any query string parameters in the urls of its menu options
// the opening of dialogs/popups/windows is defined in the ui-router states initialization (see example in the app.js of the example app)

(function (app) {
    'use strict';


    // define the navMenu component
    app.component('navMenu', {
        templateUrl: '/app/navMenuTemplate.html',
        bindings: {
            level: '@',
        },
        controller: ['navService', '$filter', '$rootScope', '$state', '$transitions', function (navService, $filter, $rootScope, $state, $transitions) {
            var self = this;
            var selectedItem;
            var levelItems;
            var allItems;

            // used to initialize the query strings in the state urls
            this.routeParams = {
            };

            // nav menu item click callback
            this.click = function (item) {
                $state.go(item.state, self.routeParams);
            }

            // get the nav data json and initialize the items for this menu level instance
            navService.getNavItems(this.level)
                .then(function (data) {
                    allItems = data;
                    levelItems = $filter('filter')(data, { level: self.level });
                    stateChanged();
                });

            // the menu populates itself during state changes (every level instance knows how to check the parent selected item based on the current url and display the 
            // corresponding children)
            $transitions.onSuccess({}, stateChanged)

            function stateChanged() {
                if (!levelItems) return;

                var states = $state.current.name.split('.');

                if (selectedItem)
                    selectedItem.selected = false;

                if (self.level == 1)
                    self.items = levelItems; // no need to filter top level items
                else {
                    // need to filter the items for this menu level instance by using the selected parent item
                    var parentItemSelected = $filter('filter')(allItems, { state: states.slice(0, self.level - 1).join('.'), level: self.level - 1 });
                    if (parentItemSelected) {
                        var parentState = parentItemSelected[0].state.split('.').slice(0, parentItemSelected[0].level).join('.');
                        self.items = $filter('filter')(levelItems, function (item) {
                            return item.state.substring(0, parentState.length) === parentState;
                        });
                    }
                }

                var levelSegments = states.slice(0, self.level);
                var selectedItem_ = $filter('filter')(levelItems, { state: levelSegments.join('.') });

                // set the selected menu item (items that open popups will be excluded since they will not pass the if check below)
                if (selectedItem_ && levelSegments.length == self.level) {
                    selectedItem = selectedItem_[0];
                    selectedItem.selected = true;
                }

                // disable items that open popups when no item has been selected
                updateDisabledStatus();
            }

            // listen for when a item is selected (event emitted by some external item picker component)
            $rootScope.$on('itemSelected', function (ev, id) {
                self.routeParams.itemId = id;
                updateDisabledStatus();
            });

            function updateDisabledStatus() {
                self.items.forEach(function (item) {
                    item.disabled = false;
                });
                var states = $state.current.name.split('.');
                var levelSegments = states.slice(0, self.level);
                if (levelSegments.length < self.level) {
                    self.items.forEach(function (item) {
                        item.disabled = angular.equals({}, self.routeParams);
                    });
                }
            }

        }],
    });

})(app);
