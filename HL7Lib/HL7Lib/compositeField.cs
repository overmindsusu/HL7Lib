using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public class VID : compositeField
    {
        public VID(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ID("Version ID");
            data[1] = new CE(this,"Internationalization Code");
            data[2] = new CE(this,"International Version ID");
        }
        public ID VersionID{
            get{return data[0] as ID;}
            set{data[0] = value;}
        }
        public CE InternationalizationCode{
            get{return data[1] as CE;}
            set{data[1] = value;}
        }
        public CE InternationalVersionID
        {
            get { return data[2] as CE; }
            set { data[2] = value; }
        }
    }


    public class HD : compositeField
    {

        public HD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new IS("Namespace ID");
            data[1] = new ST("2 Universal ID");
            data[2] = new ID("Universal ID Type");
        }
        public IS NamespaceID
        {

            get { return data[0] as IS; }
            set { data[0] = value; }
        }
        public ST UniversalID
        {
            get { return data[1] as ST; }
            set
            {
                data[1] = value;
            }
        }
        public ID UniversalIDType
        {
            get { return data[2] as ID; }
            set
            {
                data[2] = value;
            }
        }
    }

    public class CE : compositeField
    {
        public  CE(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new ST("Identifier");
            data[1] = new ST("Text");
            data[2] = new ST("Name Of Coding System");
            data[3] = new ST("Alternate Identifier");
            data[4] = new ST("Alternate Text");
            data[5] = new ST("Name Of Alternate Coding System");
        }
        public ST Identifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST Text
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }

        public ST NameOfCodingSystem
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public ST AlternateIdentifier
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST AlternateText
        {
            get { return data[4] as ST; }
            set { data[4] = value; }
        }
        public ST NameOfAlternateCodingSystem
        {
            get { return data[5] as ST; }
            set { data[5] = value; }
        }
    }
    public class MSG : compositeField
    {
        public MSG(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ID("Message Type");
            data[1] = new ID("Trigger Event");
            data[2] = new ID("Message Structure");
        }
        public ID MessageType
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ID TriggerEvent
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public ID MessageStructure
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
    }

    public class PT : compositeField
    {
        public PT(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new ID("Processing ID");
            data[1] = new ID("Processing Mode");
        }
        public ID ProcessingID
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ID ProcessingMode
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
    }

    public class EI : compositeField
    {
        public EI(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[4];
            data[0] = new ST("Entity Identifier");
            data[1] = new IS("Namespace ID");
            data[2] = new ST("Universal ID");
            data[3] = new ID("Universal ID Type");
        }
        public ST EntityIdentifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public IS NamespaceID
        {
            get { return data[1] as IS; }
            set { data[1] = value; }
        }
        public ST UniversalID
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public ID UniversalIDType
        {
            get { return data[3] as ID; }
            set { data[3] = value; }
        }
    }

    public class TS : compositeField
    {
        public TS(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new DTM("Time");
            data[1] = new ST("Degree Of Precison");
        }
        public DTM Time
        {
            get { return data[0] as DTM; }
            set { data[0] = value; }
        }
        public ST DegreeOfPrecison
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }

    }

    /*    public class CE : compositeField
        {
            public CE(compositeType parent, string name) : base(parent, name)
            {
                data = new abstractType[4];
                data[0] = new ST("Entity Identifier");
                data[1] = new IS("Namespace ID");
                data[2] = new ST("Universal ID");
                data[3] = new ID("Universal ID Type");
            }
            public ST EntityIdentifier
            {
                get { return data[0] as ST; }
                set { data[0] = value; }
            }
            public IS NamespaceID
            {
                get { return data[1] as IS; }
                set { data[1] = value; }
            }
            public ST UniversalID
            {
                get { return data[2] as ST; }
                set { data[2] = value; }
            }
            public ID UniversalIDType
            {
                get { return data[3] as ID; }
                set { data[3] = value; }
            }
        }
    */
    public class ELD : compositeField
    {
        public ELD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[4];
            data[0] = new ST("Segment ID");
            data[1] = new NM("Segment Sequence");
            data[2] = new NM("Field Position");
            data[3] = new CE(this, "Code Identifying Error");
        }
        public ST SegmentID
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public NM SegmentSequence
        {
            get { return data[1] as NM; }
            set { data[1] = value; }
        }
        public NM FieldPosition
        {
            get { return data[2] as NM; }
            set { data[2] = value; }
        }
        public CE CodeIdentifyingError
        {
            get { return data[3] as CE; }
            set { data[3] = value; }
        }
    }

    public class ERL : compositeField
    {
        public ERL(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[6];
            data[0] = new ST("Segment ID");
            data[1] = new NM("Segment Sequence");
            data[2] = new NM("Field Position");
            data[3] = new NM("Field Repeition");
            data[4] = new NM("Component Number");
            data[5] = new NM("Sub-Component Number");
        }
        public ST SegmentID
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public NM SegmentSequence
        {
            get { return data[1] as NM; }
            set { data[1] = value; }
        }
        public NM FieldPosition
        {
            get { return data[2] as NM; }
            set { data[2] = value; }
        }
        public NM FieldRepeition
        {
            get { return data[3] as NM; }
            set { data[3] = value; }
        }
        public NM ComponentNumber
        {
            get { return data[4] as NM; }
            set { data[4] = value; }
        }
        public NM SubComponentNumber
        {
            get { return data[5] as NM; }
            set { data[5] = value; }
        }
    }

    public class CWE : compositeField
    {
        public CWE(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[9];
            data[0] = new ST("Identifier");
            data[1] = new ST("Text");
            data[2] = new ID("Name Of Coding System");
            data[3] = new ST("Alternate Identifier");
            data[4] = new ST("Alternate Text");
            data[5] = new ID("Name Of Alternate Coding System");
            data[6] = new ST("Coding System Version ID");
            data[7] = new ST("Alternate Coding System Version ID");
            data[8] = new ST("Original Text");
        }
        public ST Identifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST Text
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public ID NameOfCodingSystem
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
        public ST AlternateIdentifier
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST AlternateText
        {
            get { return data[4] as ST; }
            set { data[4] = value; }
        }
        public ID NameOfAlternateCodingSystem
        {
            get { return data[5] as ID; }
            set { data[5] = value; }
        }
        public ST CodingSystemVersionID
        {
            get { return data[6] as ST; }
            set { data[6] = value; }
        }
        public ST AlternateCodingSystemVersionID
        {
            get { return data[7] as ST; }
            set { data[7] = value; }
        }
        public ST OriginalText
        {
            get { return data[8] as ST; }
            set { data[8] = value; }
        }
    }

    public class XTN : compositeField
    {
        public XTN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[12];
            data[0] = new ST("Telephone Number");
            data[1] = new ID("Telecommunication Use Code");
            data[2] = new ID("Telecommunication Equipment Type");
            data[3] = new ST("Email Address");
            data[4] = new NM("Country Code");
            data[5] = new NM("Area/City Code");
            data[6] = new NM("Local Number");
            data[7] = new NM("Extension");
            data[8] = new ST("Any Text");
            data[9] = new ST("Extension Prefix");
            data[10] = new ST("Speed Dial Code");
            data[11] = new ST("Unformatted Telephone Number");
        }
        public ST TelephoneNumber
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ID TelecommunicationUseCode
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public ID TelecommunicationEquipmentType
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
        public ST EmailAddress
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public NM CountryCode
        {
            get { return data[4] as NM; }
            set { data[4] = value; }
        }
        public NM AreaCityCode
        {
            get { return data[5] as NM; }
            set { data[5] = value; }
        }
        public NM LocalNumber
        {
            get { return data[6] as NM; }
            set { data[6] = value; }
        }
        public NM Extension
        {
            get { return data[7] as NM; }
            set { data[7] = value; }
        }
        public ST AnyText
        {
            get { return data[8] as ST; }
            set { data[8] = value; }
        }
        public ST ExtensionPrefix
        {
            get { return data[9] as ST; }
            set { data[9] = value; }
        }
        public ST SpeedDialCode
        {
            get { return data[10] as ST; }
            set { data[10] = value; }
        }
        public ST UnformattedTelephoneNumber
        {
            get { return data[11] as ST; }
            set { data[11] = value; }
        }
    }

    public class XCN : compositeField
    {
        public XCN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[15];
            data[0] = new ST("ID Number (ST)");
            data[1] = new CM("Family+Last Name Prefix");
            data[2] = new ST("Given Name");
            data[3] = new ST("Middle Initial Or Name");
            data[4] = new ST("Suffix (E.G., JR Or III)");
            data[5] = new ST("Prefix (E.G., DR)");
            data[6] = new IS("Degree (E.G., MD)");
            data[7] = new IS("Source Table");
            data[8] = new HD(this,"Assigning Authority");
            data[9] = new ID("Name Type Code");
            data[10] = new ST("Identifier Check Digit");
            data[11] = new ID("Code Identifying The Check Digit Scheme Employed");
            data[12] = new IS("Identifier Type Code");
            data[13] = new HD(this,"Assigning Facility");
            data[14] = new ID("Name Representation Code");
        }
        public ST IDNumber
        {
            get{ return data[0] as ST; }
            set{ data[0] = value; }
        }
        public CM FamilyLastNamePrefix
        {
            get{return data[1] as CM;}
            set{data[1] = value;}
        }
        public ST GivenName
        {
        get{return data[2] as ST;}
        set{data[2] = value;}
        }
        public ST MiddleInitialOrName
        {
        get{return data[3] as ST;}
        set{data[3] = value;}
        }
        public ST Suffix
        {
            get{ return data[4] as ST; }
            set{ data[4] = value; }
        }
        public ST Prefix
        {
            get{ return data[5] as ST; }
            set{ data[5] = value; }
        }
        public IS Degree
        {
            get{ return data[6] as IS; }
            set{ data[6] = value; }
        }
        public IS SourceTable
        {
        get{return data[7] as IS;}
        set{data[7] = value;}
        }
        public HD AssigningAuthority
        {
        get{return data[8] as HD;}
        set{data[8] = value;}
        }
        public ID NameTypeCode
        {
            get { return data[9] as ID; }
            set { data[9] = value; }
        }
        public ST IdentifierCheckDigit
        {
            get { return data[10] as ST; }
            set { data[10] = value; }
        }
        public ID CodeIdentifyingTheCheckDigitSchemeEmployed
        {
            get { return data[11] as ID; }
            set { data[11] = value; }
        }
        public IS IdentifierTypeCode
        {
            get { return data[12] as IS; }
            set { data[12] = value; }
        }
        public HD AssigningFacility
        {
        get{return data[13] as HD;}
        set{data[13] = value;}
        }
        public ID NameRepresentationCode
        {
            get { return data[14] as ID; }
            set { data[14] = value; }
        }
    }

    public class CX : compositeField
    {
        public CX(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[5];
            data[0] = new ST("ID");
            data[1] = new ID("Code Identifying The Check Digit Scheme Employed");
            data[2] = new HD(this,"Assigning Authority");
            data[3] = new IS("Identifier Type Code");
            data[4] = new HD(this,"Assigning Facility");
        }
        public ST ID
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ID CodeIdentifyingTheCheckDigitSchemeEmployed
        {

            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public HD AssigningAuthority
        {
            get{return data[2] as HD;}
            set{data[2] = value;}
        }
        public IS IdentifierTypeCode
        {
            get { return data[3] as IS; }
            set { data[3] = value; }
        }
        public HD AssigningFacility
        {
            get{return data[4] as HD;}
            set{data[4] = value;}
        }
    }

    public class XPN : compositeField
    {
        public XPN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[8];
            data[0] = new CM("Family+Last Name Prefix");
            data[1] = new ST("Given Name");
            data[2] = new ST("Middle Initial Or Name");
            data[3] = new ST("Suffix (E.G., JR Or III)");
            data[4] = new ST("Prefix (E.G., DR)");
            data[5] = new IS("Degree (E.G., MD)");
            data[6] = new ID("Name Type Code");
            data[7] = new ID("Name Representation Code");
        }
        public CM FamilyLastNamePrefix
        {
            get{return data[0] as CM;}
            set{data[0] = value;}
        }
        public ST GivenName
        {
            get{return data[1] as ST;}
            set{data[1] = value;}
        }
        public ST MiddleInitialOrName
        {
            get{return data[2] as ST;}
            set{data[2] = value;}
        }
        public ST Suffix
        {
            get{ return data[3] as ST; }
            set{ data[3] = value; }
        }
        public ST Prefix
        {
            get{ return data[4] as ST; }
            set{ data[4] = value; }
        }
        public IS Degree
        {
            get{ return data[5] as IS; }
            set{ data[5] = value; }
        }
        public ID NameTypeCode
        {
            get { return data[6] as ID; }
            set { data[6] = value; }
        }
        public ID NameRepresentationCode
        {
            get { return data[7] as ID; }
            set { data[7] = value; }
        }
    }

    public class XAD : compositeField
    {
        public XAD(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[11];
            data[0] = new ST("Street Address");
            data[1] = new ST("Other Designation");
            data[2] = new ST("City");
            data[3] = new ST("State Or Province");
            data[4] = new ST("Zip Or Postal Code");
            data[5] = new ID("Country");
            data[6] = new ID("Address Type");
            data[7] = new ST("Other Geographic Designation");
            data[8] = new IS("County/Parish Code");
            data[9] = new IS("Census Tract");
            data[10] = new ID("Address Representation Code");
        }
        public ST StreetAddress
        {
            get{return data[0] as ST;}
            set{data[0] = value;}
        }
        public ST OtherDesignation
        {
            get{return data[1] as ST;}
            set{data[1] = value;}
        }
        public ST City
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public ST StateOrProvince
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST ZipOrPostalCode
        {
            get{return data[4] as ST;}
            set{data[4] = value;}
        }
        public ID Country
        {
            get { return data[5] as ID; }
            set { data[5] = value; }
        }
        public ID AddressType
        {
            get{return data[6] as ID;}
            set{data[6] = value;}
        }
        public ST OtherGeographicDesignation
        {
            get { return data[7] as ST; }
            set { data[7] = value; }
        }
        public IS CountyParishCode
        {
            get { return data[8] as IS; }
            set { data[8] = value; }
        }
        public IS CensusTract
        {
            get{return data[9] as IS;}
            set{data[9] = value;}
        }
        public ID AddressRepresentationCode
        {
            get { return data[10] as ID; }
            set { data[10] = value; }
        }
    }

    public class DLN : compositeField
    {
        public DLN(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new ST("Driver'S License Number");
            data[1] = new IS("Issuing State, Province, Country");
            data[2] = new DT("Expiration Date");
        }
        public ST DriverSLicenseNumber
        {
            get{return data[0] as ST;}
            set{data[0] = value;}
        }
        public IS IssuingStateProvinceCountry
        {
            get{return data[1] as IS;}
            set{data[1] = value;}
        }
        public DT ExpirationDate
        {
            get{return data[2] as DT;}
            set{data[2] = value;}
        }
    }

    public class XON : compositeField
    {
        public XON(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[9];
            data[0] = new ST("Organization Name");
            data[1] = new IS("Organization Name Type Code");
            data[2] = new NM("ID Number (NM)");
            data[3] = new NM("Check Digit");
            data[4] = new ID("Code Identifying The Check Digit Scheme Employed");
            data[5] = new HD(this,"Assigning Authority");
            data[6] = new IS("Identifier Type Code");
            data[7] = new HD(this,"Assigning Facility ID");
            data[8] = new ID("Name Representation Code");
        }
        public ST OrganizationName
        {
            get{return data[0] as ST;}
            set{data[0] = value;}
        }
        public IS OrganizationNameTypeCode
        {
            get{return data[1] as IS;}
            set{data[1] = value;}
        }
        public NM IDNumber
        {
            get{ return data[2] as NM; }
            set{ data[2] = value; }
        }
        public NM CheckDigit
        {
            get{return data[3] as NM;}
            set{data[3] = value;}
        }
        public ID CodeIdentifyingTheCheckDigitSchemeEmployed
        {
            get { return data[4] as ID; }
            set { data[4] = value; }
        }
        public HD AssigningAuthority
        {
            get{return data[5] as HD;}
            set{data[5] = value;}
        }
        public IS IdentifierTypeCode
        {
            get { return data[6] as IS; }
            set { data[6] = value; }
        }
        public HD AssigningFacilityID
        {
            get { return data[7] as HD; }
            set { data[7] = value; }
        }
        public ID NameRepresentationCode
        {
            get { return data[8] as ID; }
            set { data[8] = value; }
        }
    }

    public class PL : compositeField
    {
        public PL(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[9];
            data[0] = new IS("Point Of Care");
            data[1] = new IS("Room");
            data[2] = new IS("Bed");
            data[3] = new HD(this,"Facility (HD)");
            data[4] = new IS("Location Status");
            data[5] = new IS("Person Location Type");
            data[6] = new IS("Building");
            data[7] = new IS("Floor");
            data[8] = new ST("Location Description");
        }
        public IS PointOfCare
        {
            get { return data[0] as IS; }
            set { data[0] = value; }
        }
        public IS Room
        {
            get { return data[1] as IS; }
            set { data[1] = value; }
        }
        public IS Bed
        {
            get { return data[2] as IS; }
            set { data[2] = value; }
        }
        public HD Facility
        {
            get{ return data[3] as HD; }
            set{ data[3] = value; }
        }
        public IS LocationStatus
        {
            get{return data[4] as IS;}
            set{data[4] = value;}
        }
        public IS PersonLocationType
        {
            get { return data[5] as IS; }
            set { data[5] = value; }
        }
        public IS Building
        {
            get { return data[6] as IS; }
            set { data[6] = value; }
        }
        public IS Floor
        {
            get { return data[7] as IS; }
            set { data[7] = value; }
        }
        public ST LocationDescription
        {
            get{return data[8] as ST;}
            set{data[8] = value;}
        }
    }

    public class FC : compositeField
    {
        public FC(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[2];
            data[0] = new IS("Financial Class");
            data[1] = new TS(this,"Effective Date");
        }
        public IS FinancialClass
        {
            get{return data[0] as IS;}
            set{data[0] = value;}
        }
        public TS EffectiveDate
        {
            get{return data[1] as TS;}
            set{data[1] = value;}
        }
    }

}
