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

                .when('/list', {
                    templateUrl: '/ngViews/list.html',
                    controller: 'ListController',
                    controllerAs: 'main'
                })

                .when('/add', {
                    templateUrl: '/ngViews/add.html',
                    controller: 'AddController',
                    controllerAs: 'main'
                })

                .when('/details/:id', {
                    templateUrl: '/ngViews/details.html',
                    controller: 'DetailsController',
                    controllerAs: 'main'
                })

                .when('/edit/:id', {
                    templateUrl: '/ngViews/edit.html',
                    controller: 'EditController',
                    controllerAs: 'main'
                })

                .when('/delete/:id', {
                    templateUrl: '/ngViews/delete.html',
                    controller: 'DeleteController',
                    controllerAs: 'main'
                })


            .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);

        });
})();