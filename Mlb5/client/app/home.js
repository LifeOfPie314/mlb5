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

    function home(appConfig, $state, countData) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'home layout';

        vm.sampleData = [];

        vm.counts = countData.data;

        //vm.sampleData.today = countData.getRuns();
        //vm.sampleData.hits = countData.getHomeruns();
        //vm.sampleData.knockouts = countData.getStrikeouts();
        //vm.sampleData.tokens = countData.getCoins();

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
