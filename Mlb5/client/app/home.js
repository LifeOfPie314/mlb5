(function() {
    'use strict';

    angular
        .module('app')
        .component('home',
        {
            templateUrl: 'home.html',
            controller: home,
            controllerAs: 'vm'
        });

    function home(appConfig, $state) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'home layout';

        vm.$onInit = function() {
            console.log(vm.title);
            $state.go('home.page1');
        }
    }
})();
