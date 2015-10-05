var app = angular.module('SRS', ['ngMaterial', 'ngMessages']);

app.controller('MainCtrl', ['$scope', '$mdSidenav', function ($scope, $mdSidenav) {
    $scope.toggleSidenav = function (menuId) {
        $mdSidenav(menuId).toggle();
    };
}]);

app.controller('IndexCtrl', function ($scope, $http, $mdToast, $mdDialog) {
    var self = this;
    
    self.title = "hello and welcome to the only korean srs i know of"
})

app.controller('WordAddCtrl', function ($scope, $http, $mdToast, $mdDialog) {
    var self = this;

    self.querySearch = function (text) {
        return $http({
            method: 'post',
            data: {
                text: text
            },
            url: '/word/forms'
        });
    };
});