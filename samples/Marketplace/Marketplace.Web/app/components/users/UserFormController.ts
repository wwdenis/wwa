// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

/// <reference path="../../_references.ts" />

module App.Controllers {
    'use strict';

    export class UserFormController extends Controller {
        
        // $inject: Avoid injection errors caused by minification
        static $inject = ['$scope', '$location', '$stateParams', 'ToastService', 'RoleService', 'ProvinceService', 'UserService'];

        // Injected dependencies
        constructor(
            public $scope: Scopes.UserFormScope,
            private $location: ng.ILocationService,
            private $stateParams: App.StateParameters,
            private ToastService: Services.ToastService,
            private RoleService: Services.RoleService,
            private ProvinceService: Services.ProvinceService,
            private UserService: Services.UserService
        ) {
            // Invoke parent constructor
            super($scope);

            // Gets the route parameter
            this.$scope.Id = $stateParams.Id;
        }

        public Init() {
            
            
            // Scope initialization
            this.$scope.Form = new Models.User();
            
            // Load lists
            this.LoadRoles();

            if (!this.IsNew()) {
                this.Load();
            }
        }

        public NameRemaining() {
            if (!Utils.HasValue(this.$scope.Form))
                return 100;

            return super.Remainder(100, this.$scope.Form.Name);
        }

        public IsNew() {
            return !Utils.HasValue(this.$scope.Id) || this.$scope.Id <= 0;
        }

        public Back() {
            this.$location.url("/users");
        }

        public Save() {
            var scope = this.$scope;
            var location = this.$location;

            this.Wait();

            // Sends out data for insert/update
            var promise = this.UserService.Save(scope.Form);

            promise
                .then((result: any) => {
                    location.url('/users');
                })
                .catch((error: Models.ErrorResult) => {
                    this.$scope.Rule = error.Rule;
                    this.ToastService.Warning(error.Text);
                })
                .finally(() => {
                    this.Done();
                });
        }

        public Load() {
            // Load from api
            var scope = this.$scope;
            var promise = this.UserService.Get(scope.Id);

            this.Wait();

            promise
                .then((result: Models.User) => {
                    scope.Form = result;
                })
                .catch((error: Models.ErrorResult) => {
                    if (error.Rule != null) 
                        this.$scope.Rule = error.Rule;

                    this.ToastService.Warning(error.Text);
                })
                .finally(() => {
                    this.Done();
                });
        }

        private LoadRoles() {
            var scope = this.$scope;
            var promise = this.RoleService.All();

            this.Wait();

            promise
                .then((result: Models.Role[]) => {
                    scope.Roles = result;
                })
                .catch((error: Models.ErrorResult) => {
                    this.$scope.Rule = error.Rule;
                    this.ToastService.Warning(error.Text);
                })
                .finally(() => {
                    this.Done();
                });
        }
    }
} 
