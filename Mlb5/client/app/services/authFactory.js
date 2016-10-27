(function () {
    'use strict';

    angular
        .module('app')
        .factory('authFactory', authFactory);

    function authFactory($http, $q, localStorageService, appConfig) {
        var authentication = {
            isAuth: false,
            username: ""
        };

        var serviceBase = appConfig.serviceBase;
        
        var service = {
            login: login,
            logOut: logOut,
            fillAuthData: fillAuthData,
            authentication: authentication
            //saveRegistration: _saveRegistration
        };

        return service;


        function login(loginData) {
            var data = "grant_type=password&username=" + loginData.username + "&password=" + loginData.username;

            var deferred = $q.defer();

            $http.post(serviceBase + 'token',
                    data,
                    { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .success(function (response) {

                    localStorageService.set('authorizationData',
                        { token: response.access_token, username: loginData.username });

                    authentication.isAuth = true;
                    authentication.username = loginData.username;

                    deferred.resolve(response);

                })
                .error(function (err, status) {
                    logOut();
                    deferred.reject(err);
                });

            return deferred.promise;
        }

        function logOut() {

            localStorageService.remove('authorizationData');

            authentication.isAuth = false;
            authentication.username = "";
        };

        function fillAuthData() {

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                authentication.isAuth = true;
                authentication.username = authData.username;
            }
        }

        //function saveRegistration(registration) {

        //    logOut();

        //    return $http.post(serviceBase + 'api/account/register', registration)
        //        .then(function (response) {
        //            return response;
        //        });

        //};

    }
})();