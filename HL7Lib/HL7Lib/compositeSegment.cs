using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public class ERR : compositeSegment
    {
        public ERR(compositeType parent, string name) : base(parent, "ERR")
        {
            data = new abstractType[12];
            data[0] = new ELD(this, "Error Code And Location");
            data[1] = new ERL(this, "Error Location");
            data[2] = new CWE(this, "HL7 Error Code");
            data[3] = new ID("Severity");
            data[4] = new CWE(this, "Application Error Code");
            data[5] = new ST("Application Error Parameter");
            data[6] = new TX("Diagnostic Information");
            data[7] = new TX("User Message");
            data[8] = new IS("Inform Person Indicator");
            data[9] = new CWE(this, "Override Type");
            data[10] = new CWE(this, "Override Reason Code");
            data[11] = new XTN(this, "Help Desk Contact Point");
        }
        public ELD ErrorCodeAndLocation
        {
            get { return data[0] as ELD; }
            set { data[0] = value; }
        }
        public ERL ErrorLocation
        {
            get { return data[1] as ERL; }
            set { data[1] = value; }
        }
        public CWE HL7ErrorCode
        {
            get { return data[2] as CWE; }
            set { data[2] = value; }
        }
        public ID Severity
        {
            get { return data[3] as ID; }
            set { data[3] = value; }
        }
        public CWE ApplicationErrorCode
        {
            get { return data[4] as CWE; }
            set { data[4] = value; }
        }
        public ST ApplicationErrorParameter
        {
            get { return data[5] as ST; }
            set { data[5] = value; }
        }
        public TX DiagnosticInformation
        {
            get { return data[6] as TX; }
            set { data[6] = value; }
        }
        public TX UserMessage
        {
            get { return data[7] as TX; }
            set { data[7] = value; }
        }
        public IS InformPersonIndicator
        {
            get { return data[8] as IS; }
            set { data[8] = value; }
        }
        public CWE OverrideType
        {
            get { return data[9] as CWE; }
            set { data[9] = value; }
        }
        public CWE OverrideReasonCode
        {
            get { return data[10] as CWE; }
            set { data[10] = value; }
        }
        public XTN HelpDeskContactPoint
        {
            get { return data[11] as XTN; }
            set { data[11] = value; }
        }
    }

    public class MSA : compositeSegment
    {
        public MSA(compositeType parent, string name) : base(parent, "MSA")
        {
            data = new abstractType[6];
            data[0] = new ID("Acknowledgment Code");
            data[1] = new ST("Message Control ID");
            data[2] = new ST("Text Message");
            data[3] = new NM("Expected Sequence Number");
            data[4] = new ID("Delayed Acknowledgment Type");
            data[5] = new CE(this, "Error Condition");

        }

        public ID AcknowledgmentCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ST MessageControlID
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public ST TextMessage
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public NM ExpectedSequenceNumber
        {
            get { return data[3] as NM; }
            set { data[3] = value; }
        }
        public ID DelayedAcknowledgmentType
        {
            get { return data[4] as ID; }
            set { data[4] = value; }
        }
        public CE ErrorCondition
        {
            get { return data[5] as CE; }
            set { data[5] = value; }
        }

    }

    public class MSH : compositeSegment
    {
            public MSH(compositeType parent, string name) : base(parent, "MSH")
            {
                data = new abstractType[21];
                data[0] = new ST("Field Separator");
                data[1] = new ST("Encoding Characters");
                data[2] = new HD(this,"Sending Application");
                data[3] = new HD(this,"Sending Facility");
                data[4] = new HD(this,"Receiving Application");
                data[5] = new HD(this,"Receiving Facility");
                data[6] = new TS(this,"Date/Time Of Message");
                data[7] = new ST("Security");
                data[8] = new MSG(this,"Message Type");
                data[9] = new ST("Message Control ID");
                data[10] = new PT(this,"Processing ID");
                data[11] = new VID(this,"Version ID");
                data[12] = new NM("Sequence Number");
                data[13] = new ST("Continuation Pointer");
                data[14] = new ID("Accept Acknowledgment Type");
                data[15] = new ID("Application Acknowledgment Type");
                data[16] = new ID("Country Code");
                data[17] = new ID("Character Set");
                data[18] = new CE(this,"Principal Language Of Message");
                data[19] = new ID("Alternate Character Set Handling Scheme");
                data[20] = new EI(this,"Message Profile Identifier");
            }
            public ST FieldSeparator
            {
                    get{return data[0] as ST;}
                    set{data[0] = value;}
            }
            public ST EncodingCharacters{
                get{return data[1] as ST;}
                set{data[1] = value;}
            }
            public HD SendingApplication{
                get{return data[2] as HD;}
                set{data[2] = value;}
            }
            public HD SendingFacility{
                get{return data[3] as HD;}
                set{data[3] = value;}
            }
            public HD ReceivingApplication{
                get{return data[4] as HD;}
                set{data[4] = value;}
            }
            public HD ReceivingFacility{
                get{return data[5] as HD;}
                set{data[5] = value;}
            }
            public TS DateTimeOfMessage{
                get{return data[6] as TS;}
                set{data[6] = value;}
            }
            public ST Security
            {
                get { return data[7] as ST; }
                set { data[7] = value; }
            }
            public MSG MessageType{
                get{return data[8] as MSG;}
                set{data[8] = value;}
            }
            public ST MessageControlID
            {
                get { return data[9] as ST; }
                set { data[9] = value; }
            }
            public PT ProcessingID{
                get{return data[10] as PT;}
                set{data[10] = value;}
            }
            public VID VersionID{
                get{return data[11] as VID;}
                set{data[11] = value;}
            }
            public NM SequenceNumber{
                get{return data[12] as NM;}
                set{data[12] = value;}
            }
            public ST ContinuationPointer{
                get{return data[13] as ST;}
                set{data[13] = value;}
            }
            public ID AcceptAcknowledgmentType
            {
                get { return data[14] as ID; }
                set { data[14] = value; }
            }
            public ID ApplicationAcknowledgmentType
            {
                get { return data[15] as ID; }
                set { data[15] = value; }
            }
            public ID CountryCode{
                get{return data[16] as ID;}
                set{data[16] = value;}
            }
            public ID CharacterSet{
                get{return data[17] as ID;}
                set{data[17] = value;}
            }
            public CE PrincipalLanguageOfMessage{
                get{return data[18] as CE;}
                set{data[18] = value;}
            }
            public ID AlternateCharacterSetHandlingScheme
            {
                get { return data[19] as ID; }
                set { data[19] = value; }
            }
            public EI MessageProfileIdentifier
            {
                get { return data[20] as EI; }
                set { data[20] = value; }
            }

        public override bool Parse(string text)
        {
            string x =text.Substring(3,1);//提取MSH-1
            data[0].Parse(x);
            string[] subs = text.Split('|');
            for (int i = 1; i < subs.Length; i++)
            {
                if (subs[i] == null || subs[i].Length == 0) continue;

                data[i].Parse(subs[i]);
            }
            value = text;
            return true;

        }

        public override string ToString()
        {
            //data[0]为分隔符号
            string x = "MSH"+data[0].ToString();
            int i;
            for (i = 1; i < data.Length; i++)
            {
                x += data[i].ToString()+'|';
            }
            //省略空值字段
            x=x.TrimEnd('|');
            return (x);
        }
    }

    public class EVN : compositeSegment
    {
        public EVN(compositeType parent, string name) : base(parent, "EVN")
        {
            data = new abstractType[6];
            data[0] = new ID("Event Type Code");
            data[1] = new TS(this,"Recorded Date/Time");
            data[2] = new TS(this,"Date/Time Planned Event");
            data[3] = new IS("Event Reason Code");
            data[4] = new XCN(this,"Operator ID");
            data[5] = new TS(this,"Event Occurred");
        }
        public ID EventTypeCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public TS RecordedDateTime
        {
            get{return data[1] as TS;}
            set{data[1] = value;}
        }
        public TS DateTimePlannedEvent
        {
            get{return data[2] as TS;}
            set{data[2] = value;}
        }
        public IS EventReasonCode
        {
            get { return data[3] as IS; }
            set { data[3] = value; }
        }
        public XCN OperatorID
        {
            get{return data[4] as XCN;}
            set{data[4] = value;}
        }
        public TS EventOccurred
        {
            get{return data[5] as TS;}
            set{data[5] = value;}
        }
    }

    public class PID : compositeField
    {
        public PID(compositeType parent, string name) : base(null, "PID")
        {
            data = new abstractType[30];
            data[0] = new SI("Set ID - PID");
            data[1] = new CX(this,"Patient ID");
            data[2] = new CX(this,"Patient Identifier List");
            data[3] = new CX(this,"Alternate Patient ID - PID");
            data[4] = new XPN(this,"Patient Name");
            data[5] = new XPN(this,"Mother'S Maiden Name");
            data[6] = new TS(this,"Date/Time Of Birth");
            data[7] = new IS("Sex");
            data[8] = new XPN(this,"Patient Alias");
            data[9] = new CE(this,"Race");
            data[10] = new XAD(this,"Patient Address");
            data[11] = new IS("County Code");
            data[12] = new XTN(this,"Phone Number - Home");
            data[13] = new XTN(this,"Phone Number - Business");
            data[14] = new CE(this,"Primary Language");
            data[15] = new CE(this,"Marital Status");
            data[16] = new CE(this,"Religion");
            data[17] = new CX(this,"Patient Account Number");
            data[18] = new ST("SSN Number - Patient");
            data[19] = new DLN(this, "Driver'S License Number - Patient");
            data[20] = new CX(this,"Mother'S Identifier");
            data[21] = new CE(this,"Ethnic Group");
            data[22] = new ST("Birth Place");
            data[23] = new ID("Multiple Birth Indicator");
            data[24] = new NM("Birth Order");
            data[25] = new CE(this, "Citizenship");
            data[26] = new CE(this, "Veterans Military Status");
            data[27] = new CE(this, "Nationality");
            data[28] = new TS(this,"Patient Death Date And Time");
            data[29] = new ID("Patient Death Indicator");
        }
        public SI SetIDPID
        {
            get{return data[0] as SI;}
            set{data[0] = value;}
        }
        public CX PatientID
        {
            get{return data[1] as CX;}
            set{data[1] = value;}
        }
        public CX PatientIdentifierList
        {
            get { return data[2] as CX; }
            set { data[2] = value; }
        }
        public CX AlternatePatientIDPID
        {
            get{return data[3] as CX;}
            set{data[3] = value;}
        }
        public XPN PatientName
        {
            get{return data[4] as XPN;}
            set{data[4] = value;}
        }
        public XPN MotherSMaidenName
        {
            get{return data[5] as XPN;}
            set{data[5] = value;}
        }
        public TS DateTimeOfBirth
        {
            get{return data[6] as TS;}
            set{data[6] = value;}
        }
        public IS Sex
        {
            get { return data[7] as IS; }
            set { data[7] = value; }
        }
        public XPN PatientAlias
        {
            get{return data[8] as XPN;}
            set{data[8] = value;}
        }
        public CE Race
        {
            get { return data[9] as CE; }
            set { data[9] = value; }
        }
        public XAD PatientAddress
        {
            get{return data[10] as XAD;}
            set{data[10] = value;}
        }
        public IS CountyCode
        {
            get{return data[11] as IS;}
            set{data[11] = value;}
        }
        public XTN PhoneNumberHome
        {
            get{return data[12] as XTN;}
            set{data[12] = value;}
        }
        public XTN PhoneNumberBusiness
        {
            get{return data[13] as XTN;}
            set{data[13] = value;}
        }
        public CE PrimaryLanguage
        {
            get{return data[14] as CE;}
            set{data[14] = value;}
        }
        public CE MaritalStatus
        {
            get{return data[15] as CE;}
            set{data[15] = value;}
        }
        public CE Religion
        {
            get { return data[16] as CE; }
            set { data[16] = value; }
        }
        public CX PatientAccountNumber
        {
            get { return data[17] as CX; }
            set { data[17] = value; }
        }
        public ST SSNNumberPatient
        {
            get{return data[18] as ST;}
            set{data[18] = value;}
        }
        public DLN DriverSLicenseNumberPatient
        {
            get{return data[19] as DLN;}
            set{data[19] = value;}
        }
        public CX MotherSIdentifier
        {
            get{return data[20] as CX;}
            set{data[20] = value;}
        }
        public CE EthnicGroup
        {
            get{return data[21] as CE;}
            set{data[21] = value;}
        }
        public ST BirthPlace
        {
            get{return data[22] as ST;}
            set{data[22] = value;}
        }
        public ID MultipleBirthIndicator
        {
            get { return data[23] as ID; }
            set { data[23] = value; }
        }
        public NM BirthOrder
        {
            get{return data[24] as NM;}
            set{data[24] = value;}
        }
        public CE Citizenship
        {
            get { return data[25] as CE; }
            set { data[25] = value; }
        }
        public CE VeteransMilitaryStatus
        {
            get { return data[26] as CE; }
            set { data[26] = value; }
        }
        public CE Nationality
        {
            get { return data[27] as CE; }
            set { data[27] = value; }
        }
        public TS PatientDeathDateAndTime
        {
            get { return data[28] as TS; }
            set { data[28] = value; }
        }
        public ID PatientDeathIndicator
        {
            get { return data[29] as ID; }
            set { data[29] = value; }
        }
    }

    public class PD1 : compositeField
    {
        public PD1(compositeType parent, string name) : base(null, "PD1")
        {
            data = new abstractType[12];
            data[0] = new IS("Living Dependency");
            data[1] = new IS("Living Arrangement");
            data[2] = new XON(this,"Patient Primary Facility");
            data[3] = new XCN(this,"Patient Primary Care Provider Name & ID No.");
            data[4] = new IS("Student Indicator");
            data[5] = new IS("Handicap");
            data[6] = new IS("Living Will");
            data[7] = new IS("Organ Donor");
            data[8] = new ID("Separate Bill");
            data[9] = new CX(this,"Duplicate Patient");
            data[10] = new CE(this,"Publicity Code");
            data[11] = new ID("Protection Indicator");
        }
        public IS LivingDependency
        {
            get{return data[0] as IS;}
            set{data[0] = value;}
        }
        public IS LivingArrangement
        {
            get{return data[1] as IS;}
            set{data[1] = value;}
        }
        public XON PatientPrimaryFacility
        {
            get { return data[2] as XON; }
            set { data[2] = value; }
        }
        public XCN PatientPrimaryCareProviderNameIDNo
        {
            get { return data[3] as XCN; }
            set { data[3] = value; }
        }
        public IS StudentIndicator
        {
            get{return data[4] as IS;}
            set{data[4] = value;}
        }
        public IS Handicap
        {
            get { return data[5] as IS; }
            set { data[5] = value; }
        }
        public IS LivingWill
        {
            get{return data[6] as IS;}
            set{data[6] = value;}
        }
        public IS OrganDonor
        {
            get{return data[7] as IS;}
            set{data[7] = value;}
        }
        public ID SeparateBill
        {
            get{return data[8] as ID;}
            set{data[8] = value;}
        }
        public CX DuplicatePatient
        {
            get{return data[9] as CX;}
            set{data[9] = value;}
        }
        public CE PublicityCode
        {
            get{return data[10] as CE;}
            set{data[10] = value;}
        }
        public ID ProtectionIndicator
        {
            get{return data[11] as ID;}
            set{data[11] = value;}
        }
    }

    public class PV1 : compositeSegment
    {
        public PV1(compositeType parent, string name) : base(parent, "PV1")
        {
            data = new abstractType[51];
            data[0] = new SI("Set ID - PV1");
            data[1] = new IS("Patient Class");
            data[2] = new PL(this,"Assigned Patient Location");
            data[3] = new IS("Admission Type");
            data[4] = new CX(this, "Preadmit Number");
            data[5] = new PL(this, "Prior Patient Location");
            data[6] = new XCN(this, "Attending Doctor");
            data[7] = new XCN(this, "Referring Doctor");
            data[8] = new XCN(this, "Consulting Doctor");
            data[9] = new IS("Hospital Service");
            data[10] = new PL(this, "Temporary Location");
            data[11] = new IS("Preadmit Test Indicator");
            data[12] = new IS("Re-Admission Indicator");
            data[13] = new IS("Admit Source");
            data[14] = new IS("Ambulatory Status");
            data[15] = new IS("VIP Indicator");
            data[16] = new XCN(this, "Admitting Doctor");
            data[17] = new IS("Patient Type");
            data[18] = new CX(this, "Visit Number");
            data[19] = new FC(this, "Financial Class");
            data[20] = new IS("Charge Price Indicator");
            data[21] = new IS("Courtesy Code");
            data[22] = new IS("Credit Rating");
            data[23] = new IS("Contract Code");
            data[24] = new DT("Contract Effective Date");
            data[25] = new NM("Contract Amount");
            data[26] = new NM("Contract Period");
            data[27] = new IS("Interest Code");
            data[28] = new IS("Transfer To Bad Debt Code");
            data[29] = new DT("Transfer To Bad Debt Date");
            data[30] = new IS("Bad Debt Agency Code");
            data[31] = new NM("Bad Debt Transfer Amount");
            data[32] = new NM("Bad Debt Recovery Amount");
            data[33] = new IS("Delete Account Indicator");
            data[34] = new DT("Delete Account Date");
            data[35] = new IS("Discharge Disposition");
            data[36] = new CE(this, "Diet Type");
            data[37] = new IS("Servicing Facility");
            data[38] = new IS("Bed Status");
            data[39] = new IS("Account Status");
            data[40] = new PL(this, "Pending Location");
            data[41] = new PL(this, "Prior Temporary Location");
            data[42] = new TS(this,"Admit Date/Time");
            data[43] = new TS(this,"Discharge Date/Time");
            data[44] = new NM("Current Patient Balance");
            data[45] = new NM("Total Charges");
            data[46] = new NM("Total Adjustments");
            data[47] = new NM("Total Payments");
            data[48] = new CX(this, "Alternate Visit ID");
            data[49] = new IS("Visit Indicator");
            data[50] = new XCN(this, "Other Healthcare Provider");
        }
        public SI SetIDPV1
        {
            get{return data[0] as SI;}
            set{data[0] = value;}
        }
        public IS PatientClass
        {
            get{return data[1] as IS;}
            set{data[1] = value;}
        }
        public PL AssignedPatientLocation
        {
            get { return data[2] as PL; }
            set { data[2] = value; }
        }
        public IS AdmissionType
        {
            get{return data[3] as IS;}
            set{data[3] = value;}
        }
        public CX PreadmitNumber
        {
            get{return data[4] as CX;}
            set{data[4] = value;}
        }
        public PL PriorPatientLocation
        {
            get { return data[5] as PL; }
            set { data[5] = value; }
        }
        public XCN AttendingDoctor
        {
            get{return data[6] as XCN;}
            set{data[6] = value;}
        }
        public XCN ReferringDoctor
        {
            get{return data[7] as XCN;}
            set{data[7] = value;}
        }
        public XCN ConsultingDoctor
        {
            get{return data[8] as XCN;}
            set{data[8] = value;}
        }
        public IS HospitalService
        {
            get{return data[9] as IS;}
            set{data[9] = value;}
        }
        public PL TemporaryLocation
        {
            get{return data[10] as PL;}
            set{data[10] = value;}
        }
        public IS PreadmitTestIndicator
        {
            get { return data[11] as IS; }
            set { data[11] = value; }
        }
        public IS ReAdmissionIndicator
        {
            get { return data[12] as IS; }
            set { data[12] = value; }
        }
        public IS AdmitSource
        {
            get{return data[13] as IS;}
            set{data[13] = value;}
        }
        public IS AmbulatoryStatus
        {
            get{return data[14] as IS;}
            set{data[14] = value;}
        }
        public IS VIPIndicator
        {
            get{return data[15] as IS;}
            set{data[15] = value;}
        }
        public XCN AdmittingDoctor
        {
            get{return data[16] as XCN;}
            set{data[16] = value;}
        }
        public IS PatientType
        {
            get{return data[17] as IS;}
            set{data[17] = value;}
        }
        public CX VisitNumber
        {
            get{return data[18] as CX;}
            set{data[18] = value;}
        }
        public FC FinancialClass
        {
            get{return data[19] as FC;}
            set{data[19] = value;}
        }
        public IS ChargePriceIndicator
        {
            get { return data[20] as IS; }
            set { data[20] = value; }
        }
        public IS CourtesyCode
        {
            get{return data[21] as IS;}
            set{data[21] = value;}
        }
        public IS CreditRating
        {
            get{return data[22] as IS;}
            set{data[22] = value;}
        }
        public IS ContractCode
        {
            get{return data[23] as IS;}
            set{data[23] = value;}
        }
        public DT ContractEffectiveDate
        {
            get { return data[24] as DT; }
            set { data[24] = value; }
        }
        public NM ContractAmount
        {
            get{return data[25] as NM;}
            set{data[25] = value;}
        }
        public NM ContractPeriod
        {
            get{return data[26] as NM;}
            set{data[26] = value;}
        }
        public IS InterestCode
        {
            get{return data[27] as IS;}
            set{data[27] = value;}
        }
        public IS TransferToBadDebtCode
        {
            get { return data[28] as IS; }
            set { data[28] = value; }
        }
        public DT TransferToBadDebtDate
        {
            get { return data[29] as DT; }
            set { data[29] = value; }
        }
        public IS BadDebtAgencyCode
        {
            get{return data[30] as IS;}
            set{data[30] = value;}
        }
        public NM BadDebtTransferAmount
        {
            get{return data[31] as NM;}
            set{data[31] = value;}
        }
        public NM BadDebtRecoveryAmount
        {
            get{return data[32] as NM;}
            set{data[32] = value;}
        }
        public IS DeleteAccountIndicator
        {
            get { return data[33] as IS; }
            set { data[33] = value; }
        }
        public DT DeleteAccountDate
        {
            get { return data[34] as DT; }
            set { data[34] = value; }
        }
        public IS DischargeDisposition
        {
            get{return data[35] as IS;}
            set{data[35] = value;}
        }
        public CE DietType
        {
            get{return data[36] as CE;}
            set{data[36] = value;}
        }
        public IS ServicingFacility
        {
            get{return data[37] as IS;}
            set{data[37] = value;}
        }
        public IS BedStatus
        {
            get{return data[38] as IS;}
            set{data[38] = value;}
        }
        public IS AccountStatus
        {
            get{return data[39] as IS;}
            set{data[39] = value;}
        }
        public PL PendingLocation
        {
            get{return data[40] as PL;}
            set{data[40] = value;}
        }
        public PL PriorTemporaryLocation
        {
            get { return data[41] as PL; }
            set { data[41] = value; }
        }
        public TS AdmitDateTime
        {
            get{return data[42] as TS;}
            set{data[42] = value;}
        }
        public TS DischargeDateTime
        {
            get{return data[43] as TS;}
            set{data[43] = value;}
        }
        public NM CurrentPatientBalance
        {
            get { return data[44] as NM; }
            set { data[44] = value; }
        }
        public NM TotalCharges
        {
            get{return data[45] as NM;}
            set{data[45] = value;}
        }
        public NM TotalAdjustments
        {
            get{return data[46] as NM;}
            set{data[46] = value;}
        }
        public NM TotalPayments
        {
            get{return data[47] as NM;}
            set{data[47] = value;}
        }
        public CX AlternateVisitID
        {
            get { return data[48] as CX; }
            set { data[48] = value; }
        }
        public IS VisitIndicator
        {
            get{return data[49] as IS;}
            set{data[49] = value;}
        }
        public XCN OtherHealthcareProvider
        {
            get { return data[50] as XCN; }
            set { data[50] = value; }
        }
    }

}


