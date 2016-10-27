(function () {
    'use strict';

    angular
        .module('app')
        .component('login',
        {
            templateUrl: 'login.html',
            controller: login,
            controllerAs: 'vm'
        });

    function login(appConfig, authFactory, $state) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'login';

        vm.loginForm = {};

        vm.$onInit = function () {
            console.log(vm.title);
        }

        vm.submit = submit;

        function submit() {
            if (vm.loginForm.$invalid) {
                return;
            }

            var loginData = {
                username: vm.username,
                password: vm.username
            }

            return authFactory.login(loginData)
                   .then(function (response) {
                           $state.go('home.page1');
                   },
            function (err) {
                console.log(err);
                alert('Login Error');
            });
        }
    }
})();


