WCF Serialization Helper
=======================

Library with helper classes for configuring the Data Contract Serializer for WCF to handle cyclical references, which are common with entities generated by ORM tools such as Entity Framework.

### Source
- WcfSerializationHelper

### Test
- Unit tests for serialization helpers

### Samples
- Sample WCF application
  + To produce cycles, uncomment lines 37-46 in MockDatabase.cs
    in Sample.Data project.
  + To configure serializer to handle cycles, reference WcfSerializationHelper
    from the Sample.Core project and add the [DataContractSerializerPreserveReferences] attribute
	to the ISampleService contract interface.
