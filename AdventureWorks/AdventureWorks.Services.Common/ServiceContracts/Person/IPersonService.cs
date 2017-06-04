//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Contracts" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System.ServiceModel;
using Xomega.Framework;

namespace AdventureWorks.Services
{
    #region IPersonService interface

    ///<summary>
    /// Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.
    ///</summary>
    [ServiceContract]
    public interface IPersonService
    {

        ///<summary>
        /// Authenticates a Person using email and password.
        ///</summary>
        [OperationContract]
        [FaultContract(typeof(ErrorList))]
        void Authenticate(Credentials _credentials);

        ///<summary>
        /// Reads person info by email as the key.
        ///</summary>
        [OperationContract]
        [FaultContract(typeof(ErrorList))]
        PersonInfo Read(string _email);

    }
    #endregion

}