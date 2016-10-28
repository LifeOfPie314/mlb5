﻿(function() {
    'use strict';

    angular
        .module('app')
        .component('page1',
        {
            templateUrl: 'page1.html',
            controller: page1,
            controllerAs: 'vm'
        });

    function page1(appConfig, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'page1';

        vm.$onInit = function() {
            console.log(vm.title);
        }
    }
})();
