//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Contracts" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Xomega.Framework;

namespace AdventureWorks.Services
{
    #region ISpecialOfferService interface

    ///<summary>
    /// Sale discounts lookup table.
    ///</summary>
    [ServiceContract]
    public interface ISpecialOfferService
    {

        ///<summary>
        /// Reads a list of Special Offer objects based on the specified criteria.
        ///</summary>
        [OperationContract]
        [FaultContract(typeof(ErrorList))]
        IEnumerable<SpecialOffer_ReadListOutput> ReadList();

    }
    #endregion

    #region SpecialOffer_ReadListOutput structure

    ///<summary>
    /// The output structure of operation ISpecialOfferService.ReadList.
    ///</summary>
    [DataContract]
    public class SpecialOffer_ReadListOutput
    {
        [DataMember]
        public int SpecialOfferId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string Category { get; set; }
    }
    #endregion

}