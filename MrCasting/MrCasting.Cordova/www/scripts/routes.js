function routeConfig($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state('inicio',
        {
            url: '/inicio',
            templateUrl: 'conteudo/inicio/inicio.html',
            controller: 'AuthController'
        })

        .state('termos',
        {
            url: '/termos',
            templateUrl: 'conteudo/inicio/termos.html'
        })

        .state('login',
        {
            url: '/login',
            templateUrl: 'conteudo/login/login.html',
            controller: 'LoginController'
        })
        .state('autenticando',
        {
            url: '/autenticando',
            templateUrl: 'conteudo/inicio/autenticando.html',
            controller: 'AuthController'
        })

        .state('inserirDadosPessoais',
        {
            url: '/inserirDadosPessoais',
            templateUrl: 'conteudo/candidato/inserir_dadospessoais.html',
            controller: 'InserirDadosPessoaisController',
            controllerAs: 'inserirDadosPessoaisCtrl'
        })

        .state('app.editarDadosPessoais', {
            url: '/editarDadosPessoais',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo.candidato.editar_dadospessoais.html',
                    controller: 'EditarDadosPessoaisController',
                    controllerAs: 'editarDadosPessoaisCtrl'
                }
            }
        })
        .state('app.editarCandidato', {
            url: '/editarCandidato',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_candidato.html',
                    controller: 'EditarCandidatoController',
                    controllerAs: 'editarCandidatoCtrl'
                }
            }
        })
        .state('inserirContato',
        {
            url: '/inserir_contato',
            templateUrl: 'conteudo/candidato/inserir_contato.html',
            controller: 'InserirContatoController',
            controllerAs: 'inserirContatoCtrl'
        })
        .state('inserirInteresses',
        {
            url: '/inserir_interesses',
            templateUrl: 'conteudo/candidato/inserir_interesses.html',
            controller: 'InserirInteresseController',
            controllerAs: 'inserirInteresseCtrl'
        })

        .state('candidato.novoConfirma',
        {
            url: "/confirma",
            templateUrl: "conteudo/candidato/novo_confirma.html",
        })
        .state('app', {
            url: '/app',
            abstract: true,
            templateUrl: 'templates/menu.html',
            controller: 'AppCtrl'
        })
        .state('app.endereco', {
            url: '/endereco',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_endereco.html',
                    controller: 'EditarEnderecoController',
                    controllerAs: 'editarEnderecoCtrl'
                }
            }
        })
        .state('app.realise', {
            url: '/realise',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_realise.html',
                    controller: 'RealiseController',
                    controllerAs: 'RealiseCtrl'
                }
            }
        })

         .state('app.perfil', {
             url: '/perfil',
             views: {
                 'menuContent': {
                     templateUrl: 'conteudo/candidato/perfil_Candidato.html',
                     controller: 'PerfilController',
                     controllerAs: 'perfilCtrl'
                 }
             }
         })

        .state('app.caracFisica', {
            url: '/caracFisica',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_carac_Fisica.html',
                    controller: 'EditarCaracFisicaController',
                    controllerAs: 'editarCaracFisicaCtrl'
                }
            }
        })

        .state('app.tags', {
            url: '/tags',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_tag.html',
                    controller: 'EditarTagsController',
                    controllerAs: 'editarTagsCtrl'
                }
            }
        })
        .state('app.hobby', {
            url: '/hobby',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_hobby.html',
                    controller: 'EditarHobbyController',
                    controllerAs: 'editarHobbyCtrl'
                }
            }
        })
        .state('app.habilidade', {
            url: '/habilidade',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_habilidade.html',
                    controller: 'EditarHabilidadeController',
                    controllerAs: 'editarHabilidadeCtrl'
                }
            }
        })


        .state('app.editarInteresse', {
            url: '/editarInteresse',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_interesse.html',
                    controller: 'EditarInteresseController',
                    controllerAs: 'editarInteresseCtrl'
                }
            }
        })

        .state('app.editarContato', {
            url: '/editarContato',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_contato.html',
                    controller: 'EditarContatoController',
                    controllerAs: 'editarContatoCtrl'
                }
            }
        })

        .state('app.editarAlbumFoto', {
            url: '/editarAlbumFoto',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/editar_albumFoto.html',
                    controller: 'ImageController',
                    controllerAs: 'ImageCtrl'
                }
            }
        })

           .state('app.mensagemcandidato', {
               url: '/mensagemcandidato',
            views: {
                'menuContent': {
                    templateUrl: 'conteudo/candidato/mensagem_candidato.html',
                    //controller: 'MensagemController',
                    //controllerAs: 'MensagemCtrl'
                }
            }
           })

         .state('app.contacandidato', {
             url: '/contacandidato',
             views: {
                 'menuContent': {
                     templateUrl: 'conteudo/candidato/conta_candidato.html',
                     controller: 'ContaCandidatoController',
                     controllerAs: 'ContaCandidatoCtrl'
                 }
             }
         })

       

         .state('app.faleconosco', {
             url: '/faleconosco',
             views: {
                 'menuContent': {
                     templateUrl: 'conteudo/candidato/fale_conosco.html',
                     controller: 'FaleConoscoController',
                     controllerAs: 'FaleConoscoCtrl'
                 }
             }
         })

        .state('app.playlists', {
            url: '/playlists',
            views: {
                'menuContent': {
                    templateUrl: 'templates/playlists.html',
                    controller: 'PlaylistsCtrl'
                }
            }
        })

        .state('app.single', {
            url: '/playlists/:playlistId',
            views: {
                'menuContent': {
                    templateUrl: 'templates/playlist.html',
                    controller: 'PlaylistCtrl'
                }
            }
        })
    //PARA TESTES
        .state('autenticacao_fake',
        {
            url: '/autenticacao_fake',
            templateUrl: 'conteudo/inicio/autenticacao_fake.html',
            controller: 'AuthControllerFake'
        })

    ;

    // if none of the above states are matched, use this as the fallback
    $urlRouterProvider.otherwise('/inicio');
    //$urlRouterProvider.otherwise('/login');
    //$urlRouterProvider.otherwise('/perfil');
    //$urlRouterProvider.otherwise('/termos');
    //$urlRouterProvider.otherwise('/app/editarDadosPessoais');
    //$urlRouterProvider.otherwise('/inserir_dadospessoais');
    //$urlRouterProvider.otherwise('/app/realise');
    // $urlRouterProvider.otherwise('/app/editarInteresse');
    // $urlRouterProvider.otherwise('/app/endereco');
    // $urlRouterProvider.otherwise('/app/caracFisica');
    //$urlRouterProvider.otherwise('/app/hobby');
    //$urlRouterProvider.otherwise('/app/tags');
    //$urlRouterProvider.otherwise('/app/habilidade');
    //$urlRouterProvider.otherwise('/app/editarAlbumFoto');
    //$urlRouterProvider.otherwise('/autenticacao_fake');


}