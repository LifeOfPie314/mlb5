(function () {
    'use strict';

    angular
      .module('app')
      .config(config);

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('home',
            {
                url: '/home',
                component: 'home',
                onEnter: function (authFactory, $state) {
                    // Check to make sure user is logged in before letting them access the app
                    authFactory.fillAuthData();
                    var authData = authFactory.authentication;
                    if (!authData.isAuth) {
                        $state.go('login');
                    }
                }
            })
            .state('home.page1',
            {
                url: '/page1',
                component: 'page1'
            })
            .state('home.page2',
            {
                url: '/page2',
                component: 'page2'
            })
            .state('home.page3',
            {
                url: '/page3',
                component: 'page3'
            })
            .state('home.page4',
            {
                url: '/page4',
                component: 'page4'
            })
            .state('home.page5',
            {
                url: '/page5',
                component: 'page5'
            })
            .state('login',
            {
                url: '/login',
                component: 'login'
            })
            .state('logout',
            {
                url: '/logout',
                component: 'logout'
            });

        // Set Default Route
        $urlRouterProvider
            .otherwise('/home');
    }
})();