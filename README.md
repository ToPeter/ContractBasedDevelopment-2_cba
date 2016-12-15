# ContractBasedDevelopment-2_cba

## Assigment
In groups, create an application that implements the bank sketched in 1. The
application should use Code Contracts and Design by ContractTM principles
to enforce the restrictions of double bookkeeping and the restrictions of the
LDM.

## Demo

Applying Code Contract to check if the customerId value is positive:
![](https://github.com/ToPeter/ContractBasedDevelopment-2_cba/blob/master/pic/Screenshot_2.png "Solution")

Let's set the value of customerId to negative.
After building the project Code Contract points to the error.
![](https://github.com/ToPeter/ContractBasedDevelopment-2_cba/blob/master/pic/Screenshot_1.png "Problem")


## Short Textual Description

The code contract improves the testability of the project and can detect if preconditions are not met even before you run the project. This can ensure that the preconditions are met before you test the rest of the method, so you don't make stupid calls in the testing classes.
