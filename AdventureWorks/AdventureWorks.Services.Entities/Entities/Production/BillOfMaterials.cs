//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;

namespace AdventureWorks.Services.Entities
{
    ///<summary>
    /// Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.
    ///</summary>
    public partial class BillOfMaterials
    {
        public BillOfMaterials()
        {
        }

        #region Properties

        public int BillOfMaterialsId  { get; set; }

        ///<summary>
        /// Parent product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int? ProductAssemblyId  { get; set; }

        ///<summary>
        /// Component identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ComponentId  { get; set; }

        ///<summary>
        /// Date the component started being used in the assembly item.
        ///</summary>
        public DateTime StartDate  { get; set; }

        ///<summary>
        /// Date the component stopped being used in the assembly item.
        ///</summary>
        public DateTime? EndDate  { get; set; }

        ///<summary>
        /// Standard code identifying the unit of measure for the quantity.
        ///</summary>
        public string UnitMeasureCode  { get; set; }

        ///<summary>
        /// Indicates the depth the component is from its parent (AssemblyID).
        ///</summary>
        public short BomLevel  { get; set; }

        ///<summary>
        /// Quantity of the component needed to create the assembly.
        ///</summary>
        public decimal PerAssemblyQty  { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate  { get; set; }

        #endregion

        #region Navigation Properties

        ///<summary>
        /// Product object referenced by the field ProductAssemblyId.
        ///</summary>
        public virtual Product ProductAssemblyObject { get; set; }

        ///<summary>
        /// Product object referenced by the field ComponentId.
        ///</summary>
        public virtual Product ComponentObject { get; set; }

        ///<summary>
        /// UnitMeasure object referenced by the field UnitMeasureCode.
        ///</summary>
        public virtual UnitMeasure UnitMeasureCodeObject { get; set; }

        #endregion
    }
}