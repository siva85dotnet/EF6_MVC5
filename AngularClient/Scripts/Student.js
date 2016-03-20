/// <reference path="angular.min.js" />
//alert("Hi");
var myApp = angular.module("student", [])
.controller("studentController", function ($scope, $http) {
    //alert("Hi Controller");

    $http.get('http://localhost:64906/api/Student/')
        .success(function (response) {
        alert("Hi Get");
        alert(response.StudentID);

        $scope.result = response;
        })
    .error(function (error) {
        alert(err.message);
        $scope.status = 'Unable to load customer data: ' + error.message
    });
});