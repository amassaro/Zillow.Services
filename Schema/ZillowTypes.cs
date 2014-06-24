using System;
using System.Xml.Serialization;

namespace Zillow.Services.Schema
{
   
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Regions
    {

        private string zipcodeidField;

        private string cityidField;

        private string countyidField;

        private string stateidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zipcode-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string zipcodeid
        {
            get
            {
                return this.zipcodeidField;
            }
            set
            {
                this.zipcodeidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string cityid
        {
            get
            {
                return this.cityidField;
            }
            set
            {
                this.cityidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("county-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string countyid
        {
            get
            {
                return this.countyidField;
            }
            set
            {
                this.countyidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string stateid
        {
            get
            {
                return this.stateidField;
            }
            set
            {
                this.stateidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class AmountOptional
    {

        private Currency currencyField;

        private bool currencyFieldSpecified;

        private string durationField;

        private bool deprecatedField;

        private bool deprecatedFieldSpecified;

        private string valueField;

        public AmountOptional()
        {
            this.deprecatedField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Currency currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currencySpecified
        {
            get
            {
                return this.currencyFieldSpecified;
            }
            set
            {
                this.currencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated
        {
            get
            {
                return this.deprecatedField;
            }
            set
            {
                this.deprecatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deprecatedSpecified
        {
            get
            {
                return this.deprecatedFieldSpecified;
            }
            set
            {
                this.deprecatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public enum Currency
    {

        /// <remarks/>
        USD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Zestimate
    {

        private Amount amountField;

        private string lastupdatedField;

        private AmountOptional oneWeekChangeField;

        private AmountOptional valueChangeField;

        private ZestimateValuationRange valuationRangeField;

        private string percentileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-updated", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lastupdated
        {
            get
            {
                return this.lastupdatedField;
            }
            set
            {
                this.lastupdatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountOptional oneWeekChange
        {
            get
            {
                return this.oneWeekChangeField;
            }
            set
            {
                this.oneWeekChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmountOptional valueChange
        {
            get
            {
                return this.valueChangeField;
            }
            set
            {
                this.valueChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ZestimateValuationRange valuationRange
        {
            get
            {
                return this.valuationRangeField;
            }
            set
            {
                this.valuationRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string percentile
        {
            get
            {
                return this.percentileField;
            }
            set
            {
                this.percentileField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Amount
    {

        private Currency currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Currency currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class ZestimateValuationRange
    {

        private Amount lowField;

        private Amount highField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount high
        {
            get
            {
                return this.highField;
            }
            set
            {
                this.highField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Address
    {

        private string streetField;

        private string zipcodeField;

        private string cityField;

        private string stateField;

        private decimal latitudeField;

        private decimal longitudeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string zipcode
        {
            get
            {
                return this.zipcodeField;
            }
            set
            {
                this.zipcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class DeprecatedType
    {

        private bool deprecatedField;

        private string valueField;

        public DeprecatedType()
        {
            this.deprecatedField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated
        {
            get
            {
                return this.deprecatedField;
            }
            set
            {
                this.deprecatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Links
    {

        private string homedetailsField;

        private string graphsanddataField;

        private string mapthishomeField;

        private string myestimatorField;

        private DeprecatedType myzestimatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string homedetails
        {
            get
            {
                return this.homedetailsField;
            }
            set
            {
                this.homedetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string graphsanddata
        {
            get
            {
                return this.graphsanddataField;
            }
            set
            {
                this.graphsanddataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mapthishome
        {
            get
            {
                return this.mapthishomeField;
            }
            set
            {
                this.mapthishomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string myestimator
        {
            get
            {
                return this.myestimatorField;
            }
            set
            {
                this.myestimatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DeprecatedType myzestimator
        {
            get
            {
                return this.myzestimatorField;
            }
            set
            {
                this.myzestimatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DetailedProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableProperty))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Property
    {

        private uint zpidField;

        private Links linksField;

        private Address addressField;

        private string fIPScountyField;

        private string useCodeField;

        private string taxAssessmentYearField;

        private string taxAssessmentField;

        private string yearBuiltField;

        private string lotSizeSqFtField;

        private string finishedSqFtField;

        private string bathroomsField;

        private string bedroomsField;

        private string totalRoomsField;

        private string lastSoldDateField;

        private Amount lastSoldPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public uint zpid
        {
            get
            {
                return this.zpidField;
            }
            set
            {
                this.zpidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Links links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Address address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIPScounty
        {
            get
            {
                return this.fIPScountyField;
            }
            set
            {
                this.fIPScountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string useCode
        {
            get
            {
                return this.useCodeField;
            }
            set
            {
                this.useCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string taxAssessmentYear
        {
            get
            {
                return this.taxAssessmentYearField;
            }
            set
            {
                this.taxAssessmentYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string taxAssessment
        {
            get
            {
                return this.taxAssessmentField;
            }
            set
            {
                this.taxAssessmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string yearBuilt
        {
            get
            {
                return this.yearBuiltField;
            }
            set
            {
                this.yearBuiltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lotSizeSqFt
        {
            get
            {
                return this.lotSizeSqFtField;
            }
            set
            {
                this.lotSizeSqFtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string finishedSqFt
        {
            get
            {
                return this.finishedSqFtField;
            }
            set
            {
                this.finishedSqFtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string bathrooms
        {
            get
            {
                return this.bathroomsField;
            }
            set
            {
                this.bathroomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string bedrooms
        {
            get
            {
                return this.bedroomsField;
            }
            set
            {
                this.bedroomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string totalRooms
        {
            get
            {
                return this.totalRoomsField;
            }
            set
            {
                this.totalRoomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lastSoldDate
        {
            get
            {
                return this.lastSoldDateField;
            }
            set
            {
                this.lastSoldDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount lastSoldPrice
        {
            get
            {
                return this.lastSoldPriceField;
            }
            set
            {
                this.lastSoldPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DetailedProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableProperty))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class SimpleProperty : Property
    {

        private Zestimate zestimateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Zestimate zestimate
        {
            get
            {
                return this.zestimateField;
            }
            set
            {
                this.zestimateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class DetailedProperty : SimpleProperty
    {

        private Regions regionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Regions regions
        {
            get
            {
                return this.regionsField;
            }
            set
            {
                this.regionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class ComparableProperty : SimpleProperty
    {

        private decimal scoreField;

        private bool scoreFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scoreSpecified
        {
            get
            {
                return this.scoreFieldSpecified;
            }
            set
            {
                this.scoreFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public partial class Message
    {

        private string textField;

        private string codeField;

        private bool limitwarningField;

        private bool limitwarningFieldSpecified;

        public Message()
        {
            this.limitwarningField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("limit-warning", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool limitwarning
        {
            get
            {
                return this.limitwarningField;
            }
            set
            {
                this.limitwarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool limitwarningSpecified
        {
            get
            {
                return this.limitwarningFieldSpecified;
            }
            set
            {
                this.limitwarningFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public enum SimpleChartDuration
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1year")]
        Item1year,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5years")]
        Item5years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10years")]
        Item10years,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.zillow.com/static/xsd/ZillowTypes.xsd")]
    public enum ChartVariant
    {

        /// <remarks/>
        homedetails,

        /// <remarks/>
        showcase,

        /// <remarks/>
        detailed,

        /// <remarks/>
        seo,

        /// <remarks/>
        partner,
    }
}
