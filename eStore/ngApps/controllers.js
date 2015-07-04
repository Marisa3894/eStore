(function () {

    angular.module('StoreApp').controller('MasterController', function (PROD_API, $resource, $location) {
        var self = this;

        var Product = $resource(PROD_API);
        self.products = Product.query();

    });

})();