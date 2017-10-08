﻿(function () {
    'use strict';

    angular
        .module('TechApp')
        .controller('TechController', TechController);

    TechController.$inject = ['$scope', '$http'];

    function TechController($scope, $http) {
        $scope.title = 'Tech List';

        // Web API의 GET 메서드 호출
        $http.get("/api/techesapi", {}).then(function (res) {
            $scope.teches = res.data;
        });
        // Web API의 POST 메서드 호출
        $scope.add = function () {
            $http.post("/api/techesapi", this.NewTech).then(function (data) {
                $scope.teches.push(data.data);
            });
        };
        
        activate();

        function activate() { }
    }
})();