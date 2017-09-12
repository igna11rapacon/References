(function () {
    'use strict';

    angular
        .module('App')
        .controller('UploadController', UploadController);

    UploadController.$inject = ['UploadService'];

    function UploadController(UploadService) {
        var vm = this;

        vm.Attachment;

        vm.UploadAttachment = UploadAttachment;

        function UploadAttachment() {
            UploadService.Create(vm.Attachment)
                .then(function (response) {
                    alert('Success');
                })
                .catch(function (result) {
                    alert('Fail');
                    console.log(result);
                });
        }

    }
})();