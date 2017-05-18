/// <reference path="../app.js" />
(function () {
    MyApp.controller("ParentController", ["$scope", function ($scope) {
        $scope.Login = function () {
            if ($scope.LoginVM.Username == "admin" && $scope.LoginVM.Password == "123456")
                alert("successfully logged in ");
            else
                alert("")
        };
    }]);

})();