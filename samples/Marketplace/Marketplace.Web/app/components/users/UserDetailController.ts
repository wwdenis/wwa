// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

/// <reference path="../../_references.ts" />

module App.Controllers {
    'use strict';

    export class UserDetailController extends Controller {
        
        // $inject: Avoid injection errors caused by minification
        static $inject = ['$scope', '$location', '$stateParams', 'ToastService', 'UserService'];

        // Injected dependencies
        constructor(
            public $scope: Scopes.UserDetailScope,
            private $location: ng.ILocationService,
            private $stateParams: App.StateParameters,
            private ToastService: Services.ToastService,
            private UserService: Services.UserService
        ) {
            // Invoke parent constructor
            super($scope);

            // Gets the route parameter
            $scope.Id = $stateParams.Id;
        }

        public Init() {
            // Load from api
            this.Load();
        }

        public Load() {
            
            var scope = this.$scope;
            var promise = this.UserService.Get(scope.Id);

            this.Wait();

            promise
                .then((result: Models.User) => {
                    scope.Item = result;
                })
                .catch((error: Models.ErrorResult) => {
                    scope.Rule = error.Rule;
                    this.ToastService.Warning(error.Text);
                })
                .finally(() => {
                    this.Done();
                });
        }
    }
} 
