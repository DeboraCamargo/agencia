(function () {
    angular.module("mrc.login", [])
    .factory('LoginData', function () {

        var data = {
            Usuario: '',
        };

        return {
            getUserName: function () {
                return data.Usuario;
            },
            setUserName: function (usuario) {
                data.Usuario = usuario;
            }
        };
    })
    .controller('LoginController', ['$scope', '$state', 'LoginData', function ($scope, $state, LoginData) {
        $scope.Data = LoginData;
        $scope.loginData = { usuario:'Joao'}       
        $scope.doLogin = doLogin;

        function doLogin(loginData) {
            $scope.Data.setUserName(loginData.usuario);
            $state.go('inserirDadosPessoais');
        }
    }])
})();