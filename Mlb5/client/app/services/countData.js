(function () {
    'use strict';

    angular
        .module('app')
        .factory('countData', countData);

    function countData() {
        var data = {
            coins: 0,
         runs: 0,
         homeruns:0,
         strikeouts: 0
    }

        var service = {
            data: {
                coins: 0,
                runs: 0,
                homeruns: 0,
                strikeouts: 0
            },
            update: function(counts) {
                this.data.coins = counts.coins;
                this.data.runs = counts.runs;
                this.data.homeruns = counts.homeruns;
                this.data.strikeouts = counts.strikeouts;
            }
            //getCoins: function () { return data.coins },
            //setCoins: function(value) { data.coins = value; },
            //getRuns: function () { return data.runs },
            //setRuns: function(value) { data.runs = value; },
            //getHomeruns: function () { return data.homeruns },
            //setHomeruns: function(value) { data.homeruns = value; },
            //getStrikeouts: function () { return data.strikeouts },
            //setStrikeouts: function(value) { data.strikeouts = value; }
        };

        return service;
    }
})();