﻿"use strict";

(function (app) {
    app.controller("RegisterController", [
        "$scope", "$location", "identityService", function ($scope, $location, identityService)
        {
            $scope.init = function () {
                if (identityService.isLoggedIn()) {
                    //$scope.redirectToHome();
                    window.location = "#/";
                }
            }();

            $scope.register = function (user) {


                $scope.localRegisterFormSubmitted = true;
                if ($scope.LocalRegisterForm.$valid) {

                    identityService.register(user).success(function () {
                        alert("You have completed registration!");
                        identityService.login(user).success(function (data) {
                            if (data.userName && data.access_token) {
                                identityService.setAccessToken(data.access_token);
                                identityService.setAuthorizedUserData(data);
                                window.location = "#/";
                                //$scope.redirectToHome();
                            }
                        });
                    }).error(function (error) {
                        if (error.modelState) {
                            $scope.localRegisterErrors = _.flatten(_.map(error.modelState, function (items)
                            {
                                return items;
                            }));
                        } else {
                            var data = {
                                responseType: "error",
                                message: error.message
                            };
                            //notifierService.notify(data);
                        }
                    });
                }


            };
        }
    ]);
})(angular.module("tmsApp"));