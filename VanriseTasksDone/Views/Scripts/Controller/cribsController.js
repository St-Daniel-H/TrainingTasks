angular.module("ngCribs").controller("cribsController", [
    "$scope",
    "cribsFactory",
    function ($scope, cribsFactory) {
        $scope.searchValue = "";
        cribsFactory.getDevices().then(function (devices) {
            $scope.devices = devices;
            $scope.$apply();
        }).catch(function (error) {
            console.error("Error fetching devices:", error);
        });
    },
]);
angular.module("ngCribs").filter("searchFilter", function () {
    return function (listings, searchValue) {
        var filtered = [];
        angular.forEach(listings, function (x) {
            if (x.name.toLowerCase().includes(searchValue.toLowerCase())) filtered.push(x);
        })
        return filtered;
    }
})