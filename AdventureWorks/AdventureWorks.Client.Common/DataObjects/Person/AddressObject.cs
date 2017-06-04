//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class AddressObject : DataObject
    {
        #region Constants

        public const string AddressId = "AddressId";
        public const string AddressLine1 = "AddressLine1";
        public const string AddressLine2 = "AddressLine2";
        public const string CityState = "CityState";
        public const string Country = "Country";
        public const string PostalCode = "PostalCode";

        #endregion

        #region Properties

        public EnumIntProperty AddressIdProperty { get; private set; }
        public TextProperty AddressLine1Property { get; private set; }
        public TextProperty AddressLine2Property { get; private set; }
        public TextProperty CityStateProperty { get; private set; }
        public TextProperty CountryProperty { get; private set; }
        public TextProperty PostalCodeProperty { get; private set; }

        #endregion

        #region Construction

        public AddressObject()
        {
        }

        public AddressObject(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void Initialize()
        {
            AddressIdProperty = new EnumIntProperty(this, AddressId);
            AddressIdProperty.Required = true;
            AddressIdProperty.Size = 10;
            AddressLine1Property = new TextProperty(this, AddressLine1);
            AddressLine1Property.Required = true;
            AddressLine1Property.Size = 60;
            AddressLine1Property.Editable = false;
            AddressLine2Property = new TextProperty(this, AddressLine2);
            AddressLine2Property.Size = 60;
            AddressLine2Property.Editable = false;
            CityStateProperty = new TextProperty(this, CityState);
            CityStateProperty.Editable = false;
            CountryProperty = new TextProperty(this, Country);
            CountryProperty.Size = 3;
            CountryProperty.Editable = false;
            PostalCodeProperty = new TextProperty(this, PostalCode);
            PostalCodeProperty.Required = true;
            PostalCodeProperty.Size = 15;
            PostalCodeProperty.Editable = false;
        }

        #endregion
    }
}