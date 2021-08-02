app.controller("addproduct",function($scope,ajax){

    $scope.addproduct = function(){
        //$scope.Name
        var d = {
          id:$scope.Id,
          name:$scope.Name
        };
        ajax.post("https://localhost:44365/api/Product/Add",d,
        function(response){

        },
        function(err){

        });
    };
});