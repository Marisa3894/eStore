(function () {

    angular.module('StoreApp', ['ngResource', 'ngRoute', 'ui.bootstrap'])
        .constant('PROD_API', '/api/products/')
        .config(function ($routeProvider, $locationProvider) {

            $routeProvider
            // master is homepage
                 .when('/', {
                     templateUrl: '/ngViews/master.html',
                     controller: 'MasterController',
                     controllerAs: 'main'
                 })

                .when('/master', {
                    templateUrl: '/ngViews/master.html',
                    controller: 'MasterController',
                    controllerAs: 'main'
                })

            .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);

        });
})();