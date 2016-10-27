(function () {
    'use strict';

    angular
      .module('app')
      .config(configInterceptors);

    function configInterceptors($httpProvider) {
        // Register authIntercepterService
        $httpProvider.interceptors.push('authInterceptorService');
    }
})();