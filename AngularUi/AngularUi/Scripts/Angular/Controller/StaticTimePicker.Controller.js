(function () {
    'use strict';

    angular
        .module('App')
        .controller('StaticTimePickerController', StaticTimePickerController);

    StaticTimePickerController.$inject = [];

    function StaticTimePickerController() {
        var vm = this;
		//variables
        vm.Hstep;
        vm.Ismeridian;
        vm.Mstep;
        vm.Time;
		//object array
        vm.StepOptions = [];

        //declared functions read
        vm.Initialise = Initialise;
        //declared functions update
        vm.Clear = Clear;
        vm.Update = Update;
        vm.ToggleMode = ToggleMode;

        //public read
        function Initialise() {
            vm.Hstep = 1;
            vm.Ismeridian = true;
            vm.Mstep = 15;
            vm.Time = new Date();

            vm.StepOptions = {
                Hstep: [1, 2, 3],
                Mstep: [1, 5, 10, 15, 25, 30]
            };
        }

        //public update
        function Clear() {
            vm.Time = null;
        }

        function Update() {
            var d = new Date();
            d.setHours(14);
            d.setMinutes(0);
            vm.Time = d;
        }

        function ToggleMode() {
            vm.Ismeridian = !vm.Ismeridian;
        }

    }
})();