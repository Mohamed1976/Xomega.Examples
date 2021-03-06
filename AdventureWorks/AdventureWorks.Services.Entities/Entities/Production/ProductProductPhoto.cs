//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;

namespace AdventureWorks.Services.Entities
{
    ///<summary>
    /// Cross-reference table mapping products and product photos.
    ///</summary>
    public partial class ProductProductPhoto
    {
        public ProductProductPhoto()
        {
        }

        #region Properties

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId  { get; set; }

        ///<summary>
        /// Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        ///</summary>
        public int ProductPhotoId  { get; set; }

        ///<summary>
        /// 0 = Photo is not the principal image. 1 = Photo is the principal image.
        ///</summary>
        public bool Primary  { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate  { get; set; }

        #endregion

        #region Navigation Properties

        ///<summary>
        /// Product object referenced by the field ProductId.
        ///</summary>
        public virtual Product ProductObject { get; set; }

        ///<summary>
        /// ProductPhoto object referenced by the field ProductPhotoId.
        ///</summary>
        public virtual ProductPhoto ProductPhotoObject { get; set; }

        #endregion
    }
}