/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function () {
    'use strict';

    angular
        .module('vjetecommerce.common')
        .factory('apiService', apiService);

    apiService.$inject = ['$http'];

    function apiService($http) {
        var service = {
            get: get
        };

        return service;

        function get(url, params, success, failure) {
            $http.get(url, { params: params }).then(success, failure);
        }
    }
})();
