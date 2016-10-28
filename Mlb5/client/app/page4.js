(function() {
    'use strict';

    angular
        .module('app')
        .component('page4',
        {
            templateUrl: 'page4.html',
            controller: page4,
            controllerAs: 'vm'
        });

    function page4(appConfig, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'page4';

        vm.$onInit = function() {
            console.log(vm.title);
        }
    }
})();
