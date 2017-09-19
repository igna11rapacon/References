(function () {
    'use strict';

    angular
        .module('App')
        .factory('UploadService', UploadService);

    UploadService.$inject = ['$http'];

    function UploadService($http) {
        return {
            Create: Create
        }

        function Create(Upload) {
            var data = {
                file: Upload.files[0]
            };

            var getModelAsFormData = function (data) {
                var dataAsFormData = new FormData();
                angular.forEach(data, function (value, key) {
                    dataAsFormData.append(key, value);
                });
                return dataAsFormData;
            };

            return $http({
                method: 'POST',
                url: '/Home/FormUpload',
                data: getModelAsFormData(data),
                transformRequest: angular.identity,
                headers: { 'Content-Type': undefined }
            });
        }

    }
})();