(function () {
    'use strict';

    angular
        .module('app')
        .component('page3',
        {
            templateUrl: 'page3.html',
            controller: page3,
            controllerAs: 'vm'
        });

    function page3(appConfig, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'page3';
        vm.games = [];

        //vm.selectedDate = {}

        vm.setting1 = appConfig.setting1;

        vm.awayIsActive = awayIsActive;
        vm.homeIsActive = homeIsActive;
        vm.dateSelected = dateSelected;
        vm.pick = pick;


        vm.$onInit = function() {
            console.log(vm.title);

            $http.get('/datetime')
                .then(function(response) {
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
            if (game.status === 0 && !game.homeTeam.picked) {
                return true;
            }
            return false;
        }

        function homeIsActive(game) {
            if (game.status === 0 && !game.awayTeam.picked) {
                return true;
            }
            return false;
        }

        function pick(game, teamCode) {
            if (game.status === 0) {
                if (game.awayTeam.picked && game.awayTeam.code == teamCode) {
                    $http.get('api/picks/remove/' + game.pickId)
                        .then(function(response) {
                            game.picked = false;
                            game.awayTeam.picked = false;
                            return;
                        });
                } else if (game.homeTeam.picked && game.homeTeam.code == teamCode) {
                    $http.get('api/picks/remove/' + game.pickId)
                        .then(function(response) {
                            game.picked = false;
                            game.homeTeam.picked = false;
                            return;
                        });
                } else {
                    $http.get('api/picks/make/' + game.id + '/' + teamCode)
                    .then(function (response) {
                        if (response.data != 0) {
                            game.picked = true;
                            game.pickId = response.data;
                            if (game.awayTeam.code == teamCode) {
                                game.awayTeam.picked = true;
                                game.homeTeam.picked = false;
                            } else {
                                game.homeTeam.picked = true;
                                game.awayTeam.picked = false;
                            }
                        }
                    });
                }
            }
        }
    }
})();
