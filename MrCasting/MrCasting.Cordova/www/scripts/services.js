'use strict';
(function () {
    angular.module('starter.services', [])
    .factory('sessionFactory', ['$http', function ($http) {
        return {
            set: function(key,value){
                return sessionStorage.setItem(key,JSON.stringify(value));
            },
            get: function (key) {
                var obj = sessionStorage.getItem(key);
                return obj && obj != ""? JSON.parse(obj): obj; // Verifica se existe obj na sessionStore 
            },
            destroy:function(key){
                return sessionStorage.remove(key);
            }
        }
    }])

.factory('FileService', function () {
    var images;
    var IMAGE_STORAGE_KEY = 'images';

    function getImages() {
        var img = window.localStorage.getItem(IMAGE_STORAGE_KEY);
        if (img) {
            images = JSON.parse(img);
        } else {
            images = [];
        }
        return images;
    };

    function addImage(img) {
        images.push(img);
        window.localStorage.setItem(IMAGE_STORAGE_KEY, JSON.stringify(images));
    };

    return {
        storeImage: addImage,
        images: getImages
    }
})

    .factory('ImageService', function ($cordovaCamera, FileService, $q, $cordovaFile) {

        var factory = {};
        factory.getPic = getPic;
        factory.resize = resize;
        factory.removeHeader = removeHeader;
        factory.addHeader = addHeader;
        var deffered;

        var PNG_HEADER = "data:image/png;base64,";

        function getPic(heigth) {
            var options = {
                quality: 5,
                destinationType: Camera.DestinationType.DATA_URL,
                sourceType: Camera.PictureSourceType.PHOTOLIBRARY
            };

            deffered = $q.defer();
            navigator.camera.getPicture(onCameraSuccess, onCameraError, options);
            return deffered.promise;
        }

        function stringStartsWith (string, prefix) {
            return string.substring(0, prefix.length) == prefix;
        }

        function removeHeader(imagem) {
            if(stringStartsWith(imagem,PNG_HEADER))
                return imagem.substring(PNG_HEADER.length, imagem.length);
            return imagem;
        }

        function addHeader(imagem) {
            if (!stringStartsWith(imagem, PNG_HEADER))
                return PNG_HEADER + imagem;
            return imagem;
        }

        function onCameraSuccess(imageData) {
            deffered.resolve({
                sucesso: true,
                imagem: PNG_HEADER + imageData
            });
        }

        function onCameraError() {
            deffered.reject({
                sucesso: false,
                imagem: ""
            });
        }

        function resize(imgOrigem, canvasDestino, callbackResize) {
            var canvas = canvasDestino;
            var ctx = canvas.getContext("2d");

            var img = new Image();
            img.onload = function () {
                canvas.height = canvas.width * (img.height / img.width);

                /// step 1
                var oc = document.createElement('canvas'),
                    octx = oc.getContext('2d');

                oc.width = img.width * 0.5;
                oc.height = img.height * 0.5;
                octx.drawImage(img, 0, 0, oc.width, oc.height);

                /// step 2
                octx.drawImage(oc, 0, 0, oc.width * 0.5, oc.height * 0.5);

                ctx.drawImage(oc, 0, 0, oc.width * 0.5, oc.height * 0.5,
                0, 0, canvas.width, canvas.height);
                if (callbackResize) {
                    callbackResize();
                }
            }
            img.src = imgOrigem;
        }

        function makeid() {
            var text = '';
            var possible = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';

            for (var i = 0; i < 5; i++) {
                text += possible.charAt(Math.floor(Math.random() * possible.length));
            }
            return text;
        };
        function optionsForType(type) {
            var source;
            switch (type) {
                case 0:
                    source = Camera.PictureSourceType.CAMERA;
                    break;
                case 1:
                    source = Camera.PictureSourceType.PHOTOLIBRARY;
                    break;
            }
            return {
                destinationType: Camera.DestinationType.FILE_URI,
                sourceType: source,
                allowEdit: false,
                encodingType: Camera.EncodingType.JPEG,
                popoverOptions: CameraPopoverOptions,
                saveToPhotoAlbum: false
            };
        }
        function saveMedia(type) {
            return $q(function (resolve, reject) {
                var options = optionsForType(type);

                $cordovaCamera.getPicture(options).then(function (imageUrl) {
                    var name = imageUrl.substr(imageUrl.lastIndexOf('/') + 1);
                    var namePath = imageUrl.substr(0, imageUrl.lastIndexOf('/') + 1);
                    var newName = makeid() + name;
                    $cordovaFile.copyFile(namePath, name, cordova.file.dataDirectory, newName)
                      .then(function (info) {
                          FileService.storeImage(newName);
                          resolve();
                      }, function (e) {
                          reject();
                      });
                });
            })
        }

        return factory;
        //{ handleMediaDialog: saveMedia }
    });
})();

