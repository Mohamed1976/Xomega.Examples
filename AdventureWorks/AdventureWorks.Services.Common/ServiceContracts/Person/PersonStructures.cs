//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Contracts" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace AdventureWorks.Services
{
    #region AddressKey structure

    ///<summary>
    /// Address key information
    ///</summary>
    [DataContract]
    public class AddressKey
    {
        [DataMember]
        public int AddressId { get; set; }
    }
    #endregion

    #region AddressInfo structure

    ///<summary>
    /// Full address information
    ///</summary>
    [DataContract]
    public class AddressInfo
    {
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string CityState { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Country { get; set; }
    }
    #endregion

    #region Credentials structure

    [DataContract]
    public class Credentials
    {
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
    #endregion

    #region PersonInfo structure

    [DataContract]
    public class PersonInfo
    {
        [DataMember]
        public int BusinessEntityId { get; set; }
        [DataMember]
        public string PersonType { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int? Store { get; set; }
        [DataMember]
        public int? Vendor { get; set; }
    }
    #endregion

}