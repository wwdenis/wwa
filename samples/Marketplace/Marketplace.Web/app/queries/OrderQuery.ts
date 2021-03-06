// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

/// <reference path="../_references.ts" />

module App.Queries {
    'use strict';

    export class OrderQuery extends QueryRequest {
        CustomerId: number;
        DealerId: number;
        ProductId: number;
        StatusId: number;

        StartDate: Date;
        EndDate: Date;

        AmountFrom: number;
        AmountTo: number;

        constructor() {
            super();

            this.SortField = "Date";
            this.SortDescending = true;
        }
    }
}  
