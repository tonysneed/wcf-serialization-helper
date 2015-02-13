using System;
using System.Collections.Generic;
using System.ServiceModel;
using WcfSerializationHelper.Sample.Entities;

namespace WcfSerializationHelper.Sample.Core
{
    [DataContractSerializerPreserveReferences] // Handle cyclical references
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        IEnumerable<Category> GetCategories();

        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}
