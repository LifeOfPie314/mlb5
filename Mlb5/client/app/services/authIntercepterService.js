(function () {
    'use strict';

    angular
        .module('app')
        .factory('authInterceptorService', authInterceptorService);

    function authInterceptorService($q, $state, localStorageService) {
        var service = {
            request: request,
            responseError: responseError
        };

        return service;

        function request(config) {

            config.headers = config.headers || {};

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                config.headers.Authorization = 'Bearer ' + authData.token;
            }

            return config;
        }

        function responseError(rejection) {
            if (rejection.status === 401) {
                $state.go('login');
            }
            return $q.reject(rejection);
        }
    }
})();