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
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
