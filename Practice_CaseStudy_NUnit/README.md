# Practice Case Study - NUnit

---



## Getting Started

This solution contains 8 Tests. They are -

- CreateMedicineDetail_WhenCalled_ReturnMedicine.
- CreateMedicineDetail_MedicineNameIsNullOrEmpty_RaiseExcception.
- CreateMedicineDetail_PricePerStripIsLessThanOrEqualZero_RaiseExcception.
- CreateMedicineDetail_ExpiryDateLessThanCurrentDate_RaiseExcception.
- CreateCartonDetail_WhenCalled_ReturnCartonDetail.
- CreateCartonDetail_MedicineStripCountIsLessOrEqualZero_RaiseException.
- CreateCartonDetail_LaunchDateLessThanCurrentDate_RaiseException.
- CreateCartonDetail_IfMedicineIsNull_ReturnNull.



### CreateMedicineDetail_WhenCalled_ReturnMedicine

> Tests if the **Medicine** object is being created by **CreateMedicineDetail()** method.

### CreateMedicineDetail_MedicineNameIsNullOrEmpty_RaiseExcception

> Checks if exception is thrown on **providing empty value for Generic Medicine name**.

### CreateMedicineDetail_PricePerStripIsLessThanOrEqualZero_RaiseExcception

> Check if exception is thrown on **providing value less than 0 for price per strip**.

### CreateMedicineDetail_ExpiryDateLessThanCurrentDate_RaiseExcception

> Check if exception is thrown on **providing date less than current date for expiry date  parameter**.



### CreateCartonDetail_WhenCalled_ReturnCartonDetail

> Tests if the **CartonDetail** object is being created by **CreateCartonDetail()** method.

### CreateCartonDetail_MedicineStripCountIsLessOrEqualZero_RaiseException

> Check if exception is thrown on **providing value less than 0 for medicine strip count**.

### CreateCartonDetail_LaunchDateLessThanCurrentDate_RaiseException

> Check if exception is thrown on **providing date less than current date for launch date  parameter**. 

### CreateCartonDetail_IfMedicineIsNull_ReturnNull

> - Check if **null value provided for Medicine object, then Null carton detail should be  obtained**.