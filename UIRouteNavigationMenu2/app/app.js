var app = angular.module('navBarDemoBasicUsage', ['ui.router']);

app.controller('cntrlr', function cntrlr($state, $scope) {
    $scope.$state = $state;
});

function cntrlr() {
    this.greeting = 'hello';

    this.toggleGreeting = function () {
        this.greeting = (this.greeting == 'hello') ? 'whats up' : 'hello'
    }
}

app.component('comp1', {
    template: '<h3>{{$ctrl.greeting}} comp1</h3>' +
    '<button ng-click="$ctrl.toggleGreeting()">toggle greeting</button>',

    controller: cntrlr
});

app.component('comp2', {
    template: '<h3>{{$ctrl.greeting}} comp2</h3>' +
    '<button ng-click="$ctrl.toggleGreeting()">toggle greeting</button>',

    controller: cntrlr
})

app.config(function ($stateProvider, $locationProvider, uiStates) {

    // method that will open a new  browser window (used for the side menu commands)
    function newWindow($stateParams, $state, $window) {
        // popups path (temp, just for testing)
        var toUrl = "/app/popups.html#" + $state.transition.to().url + '=' + $stateParams.itemId;
        $window.open(toUrl, "_blank");
        return false;
    }


    /* Register the ui-router states */
    uiStates.forEach(function (s) {
        switch (s.behavior) {
            case 'newWindow':
                s.onEnter = newWindow;
        }
        $stateProvider.state(s);
    })

});

