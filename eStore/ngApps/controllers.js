(function () {
    //HOME CONTROLLER
    angular.module('StoreApp').controller('HomeController', function ($location, $http, $modal) {
        var self = this;

        self.isAdmin = function () {
            return sessionStorage.getItem('isAdmin')
        }

        //LoginController for login modal
        self.loginshowLoginModal = function () {
            $modal.open({
                animation: true,
                templateUrl: '/ngViews/modal.html',
                controller: 'LoginController',
                controllerAs: 'loginC',
            })
        };

    });

    //USER LOGIN & CLAIMS CONTROLLER
    angular.module('StoreApp').controller('LoginController', function ($location, $http, $modalInstance ) {
        var self = this;

        //cancel modal
        self.template = '/ngViews/login.html'
        self.cancel = function () {
            $modalInstance.close('close');
        };
        //end cancel modal

        self.login = function () {
            var data = "grant_type=password&username=" + self.loginEmail + "&password=" + self.loginPassword;

            $http.post('/Token', data,
            {
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (result) {
                sessionStorage.setItem('userToken', result.access_token);
                $http.defaults.headers.common['Authorization'] = 'bearer ' + result.access_token;
                $http.get('/api/account/getisadmin').success(function (isAdmin) {
                    if (isAdmin) {
                        sessionStorage.setItem('isAdmin', 'true')
                    }
                })
                $location.path('/');
            })
            .then(function () {
                $modalInstance.dismiss('cancel')
            });
        }
    });

    //USER REGISTER CONTROLLER
    angular.module('StoreApp').controller('RegisterController', function ($http, $location) {
        var self = this;

        self.register = function () {
            $http.post('/api/account/register', self.newUser).success(function () {
                $location.path('/');
            });
        };
    });

    //USER LIST CONTROLLER - needs work
    angular.module('StoreApp').controller('UserListController', function ($location, $http) {
        var self = this;

    });


    //MENU CONTROLLER FOR NAVIGATION BAR
    angular.module('StoreApp').controller('MenuController', function ($location, $http, $log) {
        var self = this;

        self.showLogin = function () {
            return sessionStorage.getItem('userToken');
        };

        self.isAdmin = function () {
            return sessionStorage.getItem('isAdmin')
        }

        self.logout = function () {
            sessionStorage.removeItem('userToken');
            sessionStorage.removeItem('isAdmin');
            $location.path('/');
        };
    });


    //LIST
    angular.module('StoreApp').controller('ListController', function (PROD_API, $resource, $location) {
        var self = this;

        self.reveal = false;

        // query products list
        var Product = $resource(PROD_API);
        Product.query().$promise.then(function (data) {
            // on success; / back from the server
            self.reveal = true;
            self.products = data;
        },
        function () {
            // on error
            console.log("error");
        });

        self.isAdmin = function () {
            return sessionStorage.getItem('isAdmin')
        }

    });

    //ADD
    angular.module('StoreApp').controller('AddController', function (PROD_API, $resource, $routeParams, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.add = function () {
            var newProduct = new Product(self.newProduct);
            newProduct.$save(function () {
                $location.path('/list');
            });
        }
    });

    //DETAILS
    angular.module('StoreApp').controller('DetailsController', function (PROD_API, $resource, $routeParams, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.product = Product.get({ id: $routeParams.id });
    });

    //EDIT
    angular.module('StoreApp').controller('EditController', function (PROD_API, $resource, $routeParams, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.product = Product.get({ id: $routeParams.id });

        self.edit = function () {
            self.product.$save(function () {
                $location.path('/list');
            });
        }
    });

    //DELETE 
    angular.module('StoreApp').controller('DeleteController', function (PROD_API, $resource, $routeParams, $location) {
        var self = this;
        var Product = $resource(PROD_API);
        self.product = Product.get({ id: $routeParams.id });

        self.remove = function () {
            Product.remove({ id: self.product.id }).$promise.then(function () {
                $location.path('/list');
            }, function () {
                //alert(['Product deletion failed.'])
            });
        }

        self.redirect = function () {
            $location.path('/list');
        }
    });
})();

