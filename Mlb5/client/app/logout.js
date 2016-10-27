(function() {
    'use strict';

    angular
        .module('app')
        .component('logout',
        {
            //templateUrl: 'logout.html',
            controller: logout,
            controllerAs: 'vm'
        });

    function logout(authFactory, $state) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'logout';

        vm.$onInit = function() {
            authFactory.logOut();
            $state.go('login');
        }
    }
})();
