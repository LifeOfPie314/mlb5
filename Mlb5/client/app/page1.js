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
        vm.games = [];

        //vm.selectedDate = {}

        vm.setting1 = appConfig.setting1;
        vm.loadPicks = loadPicks;

        vm.$onInit = function() {
            console.log(vm.title);

            $http.get('/datetime')
                .then(function (response) {
                    var datestring = response.data.date;
                    vm.selectedDate = moment(datestring.substring(0, 10), "YYYY-MM-DD");

                    return loadPicks(vm.selectedDate);

                });
        }

        function loadPicks(date) {
            $http.get('api/picks/' + date.year() + '/' + date.format('MM') + '/' + date.format('DD'))
                .then(function(response) {
                    vm.games = response.data;
                });
        }
    }
})();
