using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public class ACK : compositeMessage
    {
        public ACK(compositeType parent, string name) : base(null, "ACK")
        {
            data = new abstractType[2];
            data[0] = new MSH(this, "Message Header");
            data[1] = new MSA(this, "MessageAcknowledgment");
 //           data[2] = new ERR(this, "Sending Application");
        }

        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }
        public MSA msa
        {
            get { return data[1] as MSA; }
            set { data[1] = value; }
        }
    }

    public class A01 : compositeMessage
    {
        public A01(compositeType parent, string name) : base(null, "A01")
        {
            data = new abstractType[4];
            data[0] = new MSH(this, "Message Header");
            data[1] = new EVN(this, "Event Type");
            data[2] = new PID(this, "Patient Identification ");
            data[3] = new PV1(this, "Patient Visit");
        }

        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }
        public EVN evn
        {
            get { return data[1] as EVN; }
            set { data[1] = value; }
        }
        public PID pid
        {
            get { return data[2] as PID; }
            set { data[2] = value; }
        }
        public PV1 pv1
        {
            get { return data[3] as PV1; }
            set { data[2] = value; }
        }
    }

    public class A02 : compositeMessage
    {
        public A02(compositeType parent, string name) : base(null, "A02")
        {
            data = new abstractType[4];
            data[0] = new MSH(this, "Message Header");
            data[1] = new EVN(this, "Event Type");
            data[2] = new PID(this, "Patient Identification ");
            data[3] = new PV1(this, "Patient Visit");
        }

        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }
        public EVN evn
        {
            get { return data[1] as EVN; }
            set { data[1] = value; }
        }
        public PID pid
        {
            get { return data[2] as PID; }
            set { data[2] = value; }
        }
        public PV1 pv1
        {
            get { return data[3] as PV1; }
            set { data[2] = value; }
        }
    }

    public class A03 : compositeMessage
    {
        public A03(compositeType parent, string name) : base(null, "A03")
        {
            data = new abstractType[4];
            data[0] = new MSH(this, "Message Header");
            data[1] = new EVN(this, "Event Type");
            data[2] = new PID(this, "Patient Identification ");
            data[3] = new PV1(this, "Patient Visit");
        }

        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }
        public EVN evn
        {
            get { return data[1] as EVN; }
            set { data[1] = value; }
        }
        public PID pid
        {
            get { return data[2] as PID; }
            set { data[2] = value; }
        }
        public PV1 pv1
        {
            get { return data[3] as PV1; }
            set { data[2] = value; }
        }
    }

    public class A04 : compositeMessage
    {
        public A04(compositeType parent, string name) : base(null, "A04")
        {
            data = new abstractType[4];
            data[0] = new MSH(this, "Message Header");
            data[1] = new EVN(this, "Event Type");
            data[2] = new PID(this, "Patient Identification ");
            data[3] = new PV1(this, "Patient Visit");
        }

        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }
        public EVN evn
        {
            get { return data[1] as EVN; }
            set { data[1] = value; }
        }
        public PID pid
        {
            get { return data[2] as PID; }
            set { data[2] = value; }
        }
        public PV1 pv1
        {
            get { return data[3] as PV1; }
            set { data[2] = value; }
        }
    }
}
