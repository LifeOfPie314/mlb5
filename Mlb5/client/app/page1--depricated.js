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

        vm.awayIsActive = awayIsActive;
        vm.homeIsActive = homeIsActive;
        vm.dateSelected = dateSelected;
        vm.makePick = makePick;

        vm.$onInit = function() {
            console.log(vm.title);

            $http.get('/datetime')
                .then(function (response) {
                    var datestring = response.data.date;
                    vm.selectedDate = moment(datestring.substring(0, 10), "YYYY-MM-DD");

                    return loadPicks(vm.selectedDate);

                });
        }

        function dateSelected() {
            var selecteDateString = String(vm.selectedDate).split(' ');
            var datestring = selecteDateString[1] + ' ' + selecteDateString[2] + ', ' + selecteDateString[3];

            var newDate = moment(datestring, "MMM DD, YYYY");
            loadPicks(newDate);
        }

        function loadPicks(date) {
            $http.get('api/picks/' + date.year() + '/' + date.format('MM') + '/' + date.format('DD'))
                .then(function(response) {
                    vm.games = response.data;
                });
        }

        function awayIsActive(game) {
            return true;
        }

        function homeIsActive(game) {
            return false;
        }

        function makePick(game, teamCode) {
            var data =
            {
                id: game.id,
                teamCode: teamCode
            }
            $http.post('api/picks/make', data)
                .then(function(response) {
                    if (response.data != 0) {
                        game.picked = true;
                        game.pickedId = response.data;
                        if (game.awayTeam.code == teamCode) {
                            game.awayTeam.picked = true;
                        } else {
                            game.homeTeam.picked = true;
                        }
                    }
                });
        }
    }
})();
