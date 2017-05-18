/// <reference path="C:\Users\parminder.pal\Documents\Visual Studio 2013\Projects\OOPS\Angular\Scripts/angular.min.js" />
/// <reference path="C:\Users\parminder.pal\Documents\Visual Studio 2013\Projects\OOPS\Angular\Scripts/angular-route.js" />
var MyApp = angular.module("MyApp", ["ngRoute"]);
debugger;
MyApp.config(function ($routeProvider) {
    $routeProvider.when("/", {
        templateUrl: "/index.html"
    }).when("/Success", {
        templateUrl: "home.html"
    }).when("/Failed", {
        templateUrl: "failed.html"
    });
});
