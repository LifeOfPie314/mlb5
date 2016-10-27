(function() {
    'use strict';

    angular
        .module('app')
        .component('page2',
        {
            templateUrl: 'page2.html',
            controller: page2,
            controllerAs: 'vm'
        });

    function page2(appConfig, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'page2';

        vm.$onInit = function() {
            console.log(vm.title);
        }
    }
})();
