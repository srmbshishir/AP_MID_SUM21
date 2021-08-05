app.controller("addproduct",function($scope,ajax){

    $scope.addproduct = function(){
        //$scope.Name
        var d = {
          id:$scope.Id,
          name:$scope.Name,
          price:$scope.Price,
          category_id:$scope.Category_id,
          qty:$scope.Quantity
        };
        ajax.post("https://localhost:44365/api/Product/Add",d,
        function(response){

        },
        function(err){

        });
    };
});