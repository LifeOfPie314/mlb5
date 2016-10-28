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

        vm.sampleData = [];

        vm.sampleData.today = 48;
        vm.sampleData.hits = 18;
        vm.sampleData.knockouts = 39;
        vm.sampleData.tokens = 12;

        vm.$onInit = function() {
            console.log(vm.title);
            $state.go('home.page3');

            // $http.get('/api/sample')
            //     .then(function(response) {
            //     vm.sampleData = response.data;
            // });
        }

    }
})();
