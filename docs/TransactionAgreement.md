# VRChat.API.Model.TransactionAgreement
Represents a single Transaction, which is likely between VRChat and Steam.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreementId** | **string** |  | 
**ItemId** | **int** |  | 
**Agreement** | **string** |  | 
**Status** | **string** | This is NOT TransactionStatus, but whatever Steam return. | 
**Period** | **string** |  | 
**Frequency** | **int** |  | 
**BillingType** | **string** |  | 
**StartDate** | **string** |  | 
**EndDate** | **string** |  | 
**RecurringAmt** | **decimal** |  | 
**Currency** | **string** |  | 
**TimeCreated** | **string** |  | 
**NextPayment** | **string** |  | 
**LastPayment** | **string** |  | 
**LastAmount** | **decimal** |  | 
**LastAmountVat** | **decimal** |  | 
**Outstanding** | **int** |  | 
**FailedAttempts** | **int** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

