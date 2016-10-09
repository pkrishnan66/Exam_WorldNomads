/// <reference path="angular.js" />
var myApp = angular.module("WorldNomads", [])
                  .controller("numericSequenceController", function ($scope, $log, $http) {

                      //Initialize input
                      $scope.inputValue = "";
                      $scope.invalidInput = false;
                      $scope.istextDisabled = false;

                      //Set the CheckBoxes to False...
                      $scope.NumericBuilderCheckbox = {
                          chkEvenSequence: false,
                          chkOddSequence: false,
                          chkNumericSequence: false,
                          chkFibonacciSequence: false,
                          chkSpecialSequence: false
                      };

                      //Initialize the Variables
                      $scope.InitializeEvenSequence = "Select to Build Even Sequence";
                      $scope.InitializeOddSequence = "Select to Build Odd Sequence";
                      $scope.InitializeFibSequence = "Select to Build Fibonacci Sequence";
                      $scope.InitializeNumericSequence = "Select to Build Numeric Sequence"
                      $scope.InitializeSpecialSequence = "Select to Build Special Sequence";

                      //Set the Text Disabled...

                      $scope.PerformInputValidation = function () {
                          if($scope.istextDisabled)
                          {
                              $scope.istextDisabled = false;
                          }
                          if ($scope.inputValue === ""  || $scope.inputValue > 2147483647) {

                              return true;
                          }
                      }


                         $scope.SetOddSequence = function () {
                          switch($scope.NumericBuilderCheckbox.chkOddSequence)
                          {
                              case true:
                                  if($scope.PerformInputValidation())
                                  {
                                      $scope.OddSequence = "Invalid or No Input";
                                  }
                                  else
                                  {
                                      $scope.BuildOddSequence();
                                  }
                                  $scope.InitializeOddSequence = "View Built Odd Sequence for " + $scope.inputValue;
                                  $scope.istextDisabled = true;
                                  break;
                              case false:
                                  $scope.InitializeOddSequence = "Select to Build Odd Sequence";
                                  $scope.istextDisabled = false;
                                  $scope.inputValue = "";
                                  $scope.OddSequence = "";
                                  break;
                          }
                                 
                      }

                      //Perform Checkbox validation for Odd Sequence

                      //Build the Odd Sequence...
                      $scope.BuildOddSequence = function () {
                          $http({
                              method: 'GET',
                              url: '/NumericSequence/OddSequenceResult',
                              params: { inputValue: $scope.inputValue }
                          }).then(function (response) {
                              $scope.OddSequence = response.data;
                              $log.info(response.data);
                          });

                      }

                      $scope.SetEvenSequence = function () {
                          switch ($scope.NumericBuilderCheckbox.chkEvenSequence) {
                              case true:
                                  if ($scope.PerformInputValidation()) {
                                      $scope.EvenSequeunce = "Invalid or No Input";
                                  }
                                  else {
                                      $scope.BuildEvenSequence();
                                  }
                                  $scope.istextDisabled = true;
                                  $scope.InitializeEvenSequence = "View Built Even Sequence for " + $scope.inputValue;
                                  break;
                              case false:
                                  $scope.InitializeEvenSequence = "Select to Build Even Sequence";
                                  $scope.istextDisabled = false;
                                  $scope.inputValue = "";
                                  $scope.EvenSequeunce = "";
                                  break;
                          }

                      }


                      $scope.BuildEvenSequence = function () {
                          $http({
                              method: 'GET',
                              url: '/NumericSequence/EvenSequenceResult',
                              params: { inputValue: $scope.inputValue }
                          }).then(function (response) {
                              $scope.EvenSequeunce = response.data;
                              $log.info(response.data);
                          });

                      }

                      $scope.SetNumericSequence = function () {
                          switch ($scope.NumericBuilderCheckbox.chkNumericSequence) {
                              case true:
                                  if ($scope.PerformInputValidation()) {
                                      $scope.NumericSequence = "Invalid or No Input";
                                  }
                                  else {
                                      $scope.BuildNumericSequence();
                                  }
                                  $scope.InitializeNumericSequence = "View Built Numeric Sequence for " + $scope.inputValue;

                                  $scope.istextDisabled = true;
                                  break;
                              case false:
                                  $scope.InitializeNumericSequence = "Select to Build Numeric Sequence";
                                  $scope.istextDisabled = false;
                                  $scope.inputValue = "";
                                  $scope.NumericSequence = "";
                                  break;
                          }

                      }


                     $scope.BuildNumericSequence = function () {
                          $http({
                              method: 'GET',
                              url: '/NumericSequence/NumericSequenceResult',
                              params: { inputValue: $scope.inputValue }
                          }).then(function (response) {
                              $scope.NumericSequence = response.data;
                              $log.info(response.data);
                          });

                      }

                     $scope.SetSpecialSequence = function () {
                         switch ($scope.NumericBuilderCheckbox.chkSpecialSequence) {
                             case true:
                                 if ($scope.PerformInputValidation()) {
                                     $scope.SpecialSequence = "Invalid or No Input";
                                 }
                                 else {
                                     $scope.BuildSpecialSequence();
                                 }
                                 $scope.InitializeSpecialSequence = "View Built Special Sequence for " + $scope.inputValue;

                                 $scope.istextDisabled = true;
                                 break;
                             case false:
                                 $scope.InitializeSpecialSequence = "Select to Build Special Sequence";
                                 $scope.istextDisabled = false;
                                 $scope.inputValue = "";
                                 $scope.SpecialSequence = "";
                                 break;
                         }

                     }


                     $scope.BuildSpecialSequence = function () {
                         $http({
                             method: 'GET',
                             url: '/NumericSequence/SpecialSequenceResult',
                             params: { inputValue: $scope.inputValue }
                         }).then(function (response) {
                             $scope.SpecialSequence = response.data;
                             $log.info(response.data);
                         });

                     }


                     $scope.SetFibonacciSequence = function () {
                         switch ($scope.NumericBuilderCheckbox.chkFibSequence) {
                             case true:
                                 if ($scope.PerformInputValidation()) {
                                     $scope.FibonacciSequence = "Invalid or No Input";
                                 }
                                 else {
                                     $scope.BuildFibonacciSequence();
                                 }
                                 $scope.InitializeFibSequence = "View Built Fibonacci Sequence for " + $scope.inputValue;
                                 $scope.istextDisabled = true;
                                 break;
                             case false:
                                 $scope.InitializeFibSequence = "Select to Build Fibonacci Sequence";
                                 $scope.istextDisabled = false;
                                 $scope.inputValue = "";
                                 $scope.FibonacciSequence = "";
                                 break;
                         }

                     }


                     $scope.BuildFibonacciSequence = function () {
                         $http({
                             method: 'GET',
                             url: '/NumericSequence/FibonacciSequenceResult',
                             params: { inputValue: $scope.inputValue }
                         }).then(function (response) {
                             $scope.FibonacciSequence = response.data;
                             $log.info(response.data);
                         });

                     }

                      
});
                










