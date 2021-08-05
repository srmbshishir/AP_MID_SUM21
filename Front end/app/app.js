var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/addcategories", {
        templateUrl : "views/pages/addcategory.html",
          controller: 'addcategory'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/edit", {
        templateUrl : "views/pages/edit.html",
        controller: 'edit'
    })
    .when("/showcategories", {
        templateUrl : "views/pages/showcategories.html",
        controller: 'showcategories'
    })
    .when("/showproducts", {
        templateUrl : "views/pages/showproducts.html",
        controller: 'showproducts'
    })
    .when("/addproduct", {
        templateUrl : "views/pages/addproduct.html",
        controller: 'addproduct'
    })
    .when("/showorder", {
        templateUrl : "views/pages/showorder.html",
        controller: 'showorder'
    })
    .when("/showorder/:id", {
        templateUrl : "views/pages/orderdetails.html",
        controller: 'orderdetails'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
