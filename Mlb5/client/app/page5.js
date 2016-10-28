(function() {
    'use strict';

    angular
        .module('app')
        .component('page5',
        {
            templateUrl: 'page5.html',
            controller: page5,
            controllerAs: 'vm'
        });

    function page5(appConfig, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'page5';

        vm.$onInit = function() {
            console.log(vm.title);
        }
    }
})();
