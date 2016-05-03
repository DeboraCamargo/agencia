angular.module("mrc.auth", ['starter.services'])
    .factory('UsuarioData', function (sessionFactory) {
        return {
            getToken: function () {
                return sessionFactory.get('token');
            },

            setToken: function (token) {
                sessionFactory.set('token', token);
            },

            setTipoLogin: function (tipoLogin) {
                sessionFactory.set('tipoLogin', tipoLogin);
            },

            getTipoLogin: function () {
                return sessionFactory.get('tipoLogin');
            },

            setEmail: function (email) {
                sessionFactory.set('tokenEmail', email);
            },

            getEmail: function () {
                return sessionFactory.get('tokenEmail');
            },
            TIPO_CANDIDATO: 0,
            TIPO_SCOUTER: 1,
        };
    })
    .controller('AuthController', function ($scope, $rootScope, $cordovaOauth, $state, $http, UsuarioData, $ionicLoading, CandidatoData) {
        var Google = 'GGL';
        var Facebook = 'FB';

        $rootScope.Server = 'https://mrcasting.azurewebsites.net';
        //$rootScope.Server = 'https://localhost:12146';

        $scope.facebookLogin = function () {
            $ionicLoading.show({
                template: '<ion-spinner></ion-spinner>'
            });

            $state.go('autenticando');

            $cordovaOauth.facebook("1510350095946443", ["email"], { redirect_uri: "http://localhost/callback" }).then(function (result) {
                UsuarioData.setToken(result.access_token);
                UsuarioData.setTipoLogin(Facebook);
                processarLoginOAuth();
            }, function (error) {
                alert("Ocorreu um erro ao tentar realizar o login");
                //$state.go("inicio");
            });
        }

        $scope.googleLogin = function () {
            $ionicLoading.show({
                template: '<ion-spinner></ion-spinner>'
            });
            $state.go('autenticando');

            $cordovaOauth.google("127206936686-sk65fs3g4pkeqefpv5hk37bk3s3c15ig.apps.googleusercontent.com", ["email"], { redirect_uri: "http://localhost/callback" }).then(function (result) {
                UsuarioData.setToken(result.access_token);
                UsuarioData.setTipoLogin(Google);
                processarLoginOAuth();
            }, function (error) {
                alert("Ocorreu um erro ao tentar realizar o login");
            });
        }

        function processarLoginOAuth() {
            var tipoLogin = UsuarioData.getTipoLogin();
            var token = UsuarioData.getToken();

            if (tipoLogin === Facebook) {
                $http.get("https://graph.facebook.com/v2.2/me", { params: { access_token: token, fields: 'email', format: 'json' } }).then(function (result) {
                    var dados = result.data;
                    var email = dados.email;

                    UsuarioData.setEmail(email);
                    var dto = { Email: email, Token: token };
                    realizarLogin(dto);
                }, function (error) {
                    alert("Ocorreu um erro ao tentar realizar o login com o facebook");
                });
            }
        }

        function realizarLogin(emailTokenDto) {

            $http({
                method: 'post',
                url: $rootScope.Server + '/api/LoginOAuth/Login',
                data: emailTokenDto,
                headers: { 'Content-Type': 'application/json' }
            }).then(
                function (response) {
                    CandidatoData.setCandidato(response.data);
                    $state.go('app.editarDadosPessoais');
                    //$location.path('/app/editarDadosPessoais');
                    $ionicLoading.hide();
                },
                function (response) {
                    if (response.status === 401) {
                        //$state.go('termos');
                        $state.go('inserirDadosPessoais');
                    } else {
                        $state.go('inicio');
                    }
                    $ionicLoading.hide();
                }
            );
        }
    })
    .controller('AuthControllerFake', ['$scope', '$rootScope', '$cordovaOauth', '$state', '$http', 'UsuarioData', '$ionicLoading', 'CandidatoData', '$cordovaNetwork', function ($scope, $rootScope, $cordovaOauth, $state, $http, UsuarioData, $ionicLoading, CandidatoData, $cordovaNetwork) {
        var Google = 'GGL';
        var Facebook = 'FB';

        $rootScope.erro = null;
        $rootScope.Server = 'http://localhost:12146';
        //$rootScope.Server = 'http://10.0.2.2:12146';

        $scope.realizarLogin = realizarLogin

        function realizarLogin() {
            var emailTokenDto = { email: 'alexccamargo@gmail.com', token: 'CAAVdp8j0kssBAG0TbcPfHL2GOT5KRxQKfTDZAWD7OYmQWU4vXAaxysZBi2K9agmo53MNMZB2tQ75LqPrf3MeKMGyOqBFnItVaDZA1Rsd2uQYI1TrejYGDA0RZCGGi3uqJ1puysVXQVJienZBHZCNLioshVDpYZA0F9i4LiWGuQ5NNM7pUeXfRAjaZAdDPXgzQsOcZD' }

            UsuarioData.setEmail(emailTokenDto.email);
            UsuarioData.setToken(emailTokenDto.token);
            UsuarioData.setTipoLogin(Facebook);

            //if ($cordovaNetwork.isOnline()) {
                $http({
                    method: 'post',
                    url: $rootScope.Server + '/api/LoginOAuth/Login',
                    data: emailTokenDto,
                    headers: { 'Content-Type': 'application/json; charset=utf-8' }
                }).then(
                    function (response) {
                        $rootScope.erro = null;
                        //$rootScope.Candidato = response.data;
                        CandidatoData.setCandidato(response.data);
                        $state.go('app.editarDadosPessoais');
                        $ionicLoading.hide();
                    },
                    function (response) {
                        $rootScope.erro = response.status;
                        if (response.status === 401) {
                            $state.go('termos');
                            //$state.go('inserirDadosPessoais');
                        } else {
                            $state.go('autenticacao_fake');
                        }
                    }
                );
            //} else {
            //    alert("Não deu");
            //}
        }
    }]);
