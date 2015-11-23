(function() {
'use strict';

    angular
        .module('app')
        .controller('RunnersController', RunnersController);

    RunnersController.$inject = ['$http'];
    function RunnersController($http) {
        var vm = this;
        vm.runners = [];

        activate();

        function activate() {
            $http.get('/api/runner')
            .then(function(response){
                vm.runners = response.data;
            })
            .catch(function(err){
                console.log(err);
            });
        }
    }
})();