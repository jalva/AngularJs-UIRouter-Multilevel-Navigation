// item picker controller (just for testing)
app.controller('itemSelectorController', function ($scope, $rootScope) {
    $scope.clickItem = function (id) {
        $rootScope.$broadcast('itemSelected', id);
        $scope.selectedItemId = id;
    }
});