app.controller("showorder", function ($scope, $http, ajax) {
    ajax.get("https://localhost:44365/api/Order/GetAll", success, error);
    function success(response) {
      $scope.orders = response.data;
    }
    function error(error) {}
  });