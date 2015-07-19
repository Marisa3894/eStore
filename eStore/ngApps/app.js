(function () {

    angular.module('StoreApp', ['ngResource', 'ngRoute', 'ui.bootstrap', 'angularVideoBg'])
        .constant('PROD_API', '/api/products')
        .config(function ($routeProvider, $locationProvider) {

            $routeProvider
            // homepage
                 .when('/', {
                     templateUrl: '/ngViews/home.html',
                     controller: 'HomeController',
                     controllerAs: 'homeC'
                 })

                .when('/home', {
                    templateUrl: '/ngViews/home.html',
                    controller: 'HomeController',
                    controllerAs: 'homeC'
                })

                .when('/list', {
                    templateUrl: '/ngViews/list.html',
                    controller: 'ListController',
                    controllerAs: 'listC'
                })

                .when('/add', {
                    templateUrl: '/ngViews/add.html',
                    controller: 'AddController',
                    controllerAs: 'addC'
                })

                .when('/details/:id', {
                    templateUrl: '/ngViews/details.html',
                    controller: 'DetailsController',
                    controllerAs: 'detailsC'
                })

                .when('/edit/:id', {
                    templateUrl: '/ngViews/edit.html',
                    controller: 'EditController',
                    controllerAs: 'editC'
                })

                .when('/delete/:id', {
                    templateUrl: '/ngViews/delete.html',
                    controller: 'DeleteController',
                    controllerAs: 'deleteC'
                })

                .when('/login', {
                    templateUrl: '/ngViews/login.html',
                    controller: 'LoginController',
                    controllerAs: 'loginC'
                })

                .when('/register', {
                    templateUrl: '/ngViews/register.html',
                    controller: 'RegisterController',
                    controllerAs: 'registerC'
                })

                .when('/userList', {
                    templateUrl: '/ngViews/Admin/userList.html',
                    controller: 'UserListController',
                    controllerAs: 'userListC'
                })


            .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);

        });
})();