angular.module('facebook', ['ezfb', 'hljs'])
.config(function (ezfbProvider) {
    ezfbProvider.setInitParams({
        appId: '1509810019333784'
    });  
})
.controller('FacebookController', function ($scope, ezfb, $window, $location, $state) {
  
    updateLoginStatus(updateApiMe);

    $scope.login = function () {
        ezfb.login(function (res) {
            if (res.authResponse) {
                //Sucesso ?
                updateLoginStatus(updateApiMe);
                $state.go('app.editarDadosPessoais');
            } else {
                $state.go('termos');
            }
        }, {scope: 'email'});
    };

    $scope.logout = function () {
        ezfb.logout(function () {
            updateLoginStatus(updateApiMe);
        });
    };
    
    function updateLoginStatus (more) {
        ezfb.getLoginStatus(function (res) {
            $scope.loginStatus = res;

            (more || angular.noop)();
        });
    }

    function updateApiMe () {
        ezfb.api('/me', function (res) {
            $scope.apiMe = res;
        });
    }
});
