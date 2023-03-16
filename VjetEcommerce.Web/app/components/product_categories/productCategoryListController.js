(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];

        $scope.getProductCagories = getProductCagories;

        function getProductCagories() {
            apiService.get('/api/productcategory/getall', null, function (result) {
                $scope.productCategories = result.data;
                console.log(result.data);
            }, function () {
                console.log('Load productcategory failed.');
            });
        }

        $scope.getProductCagories();
    }
})(angular.module('vjetecommerce.product_categories'));