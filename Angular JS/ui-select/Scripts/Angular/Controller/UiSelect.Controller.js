(function () {
    'use strict';

    angular
        .module('App')
        .controller('UiSelectController', UiSelectController);

    UiSelectController.$inject = [];

    function UiSelectController() {
        var vm = this;
        //object        
        vm.SingleSelected;
        //array
        vm.DropDownItems = [];
        vm.MultipleSelected = [];
        
        vm.Initialise = Initialise;

        function Initialise() {
            vm.DropDownItems = [
                { DropDownItemId: 0, DropDownItemDescription: 'Description0' },
                { DropDownItemId: 1, DropDownItemDescription: 'Description1' },
                { DropDownItemId: 2, DropDownItemDescription: 'Description2' },
                { DropDownItemId: 3, DropDownItemDescription: 'Description3' },
                { DropDownItemId: 4, DropDownItemDescription: 'Description4' }
            ];
        }

    }
})();