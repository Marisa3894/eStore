(function () {

    angular.module('StoreApp').controller('MasterController', function (PROD_API, $resource, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.products = Product.query();

    });

    angular.module('StoreApp').controller('ListController', function (PROD_API, $resource, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.products = Product.query();
    });

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

    angular.module('StoreApp').controller('DetailsController', function (PROD_API, $resource, $routeParams, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.product = Product.get({ id: $routeParams.id });
    });

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