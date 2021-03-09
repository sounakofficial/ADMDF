# Practice Case Study - NUnit

---



## Getting Started

This solution contains 5 Tests. They are -

- MedicineObjectCreationTest.
- MedicineExceptionsTest.
- CartonObjectCreationTest.
- CartonExceptionsTest.
- NullMedicineObjectTest



### MedicineObjectCreationTest

> Tests if the **Medicine** object is being created by **CreateMedicineDetail()** method.

### MedicineExceptionsTest

> - Checks if exception is thrown on **providing empty value for Generic Medicine name**.
> - Check if exception is thrown on **providing value less than 0 for price per strip**.
> - Check if exception is thrown on **providing date less than current date for expiry date  parameter**.

### CartonObjectCreationTest

> Tests if the **CartonDetail** object is being created by **CreateCartonDetail()** method.

### CartonExceptionsTest.

> - Check if exception is thrown on **providing value less than 0 for medicine strip count**.
> - Check if exception is thrown on **providing date less than current date for launch date  parameter**. 

### NullMedicineObjectTest

> - Check if **null value provided for Medicine object, then Null carton detail should be  obtained**.