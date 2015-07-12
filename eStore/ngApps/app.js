(function () {

    angular.module('StoreApp', ['ngResource', 'ngRoute', 'ui.bootstrap'])
        .constant('PROD_API', '/api/products/')
        .config(function ($routeProvider, $locationProvider) {

            $routeProvider
            // homepage
                 .when('/', {
                     templateUrl: '/ngViews/home.html',
                     controller: 'HomeController',
                     controllerAs: 'main'
                 })

                .when('/home', {
                    templateUrl: '/ngViews/home.html',
                    controller: 'HomeController',
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

                .when('/login', {
                    templateUrl: '/ngViews/login.html',
                    controller: 'LoginController',
                    controllerAs: 'main'
                })

                .when('/register', {
                    templateUrl: '/ngViews/register.html',
                    controller: 'RegisterController',
                    controllerAs: 'main'
                })


            .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);

        });
})();