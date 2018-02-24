
describe('Nav menu component', function () {
    beforeEach(module('navBarDemoBasicUsage'));

    var element, scope;
    beforeEach(inject(function ($rootScope, $compile) {
        scope = $rootScope.$new();
        element = angular.element('<nav-menu level={{level}}></nav-menu>');
        element = $compile(element)(scope);
        scope.level = 1;
        $scope.$apply();

        it('should render 3 top level items', function () {
            var list = element.find('ul.nav');
            expect(list.find('li').length).toBe(3);
        });
    }));
})