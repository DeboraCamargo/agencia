(function () {
    'use strict';

    angular.module('starter.controllers', ["ionic","ngCordova"])

    .controller('AppCtrl', ['$rootScope', '$scope', '$location', function ($rootScope, $scope, $location) {
        $scope.sidemenu = function (link) {
            $location.path(link);
        }
    }])   
    .controller('PlaylistsCtrl', function ($ionicPlatform, $scope, $cordovaDevice) {

        $scope.user = null;

        $ionicPlatform.ready(function () {
            $scope.$apply(function () {
                // sometimes binding does not work! :/

                // getting device infor from $cordovaDevice
                var device = $cordovaDevice.getDevice();

                $scope.manufacturer = device.manufacturer;
                $scope.model = device.model;
                $scope.platform = device.platform;
                $scope.uuid = device.uuid;

            });

        });

    })
})();