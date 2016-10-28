(function() {
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

        vm.setting1 = appConfig.setting1;
        vm.sampleData = [];

        

        vm.$onInit = function() {
            console.log(vm.title);

            // $http.get('/api/sample')
            //     .then(function(response) {
            //         vm.sampleData = response.data;
            //     });
        }
    }
})();
