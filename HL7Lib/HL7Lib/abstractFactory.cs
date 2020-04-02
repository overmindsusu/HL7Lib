using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public abstract class abstractFactory
    {
        public abstract abstractType Create(compositeType parent,Enum product, string name);
    }

    public class messageFactory : abstractFactory
    {
        abstractType a;
        public enum enumMessages {ACK, A01, A02 }      //状态枚举声明
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            switch ((enumMessages)product)
            {
                case enumMessages.ACK:
                    a = new ACK(null,"ACK");
                    break;
                case enumMessages.A01:
                    a = new A01(null,"A01");
                    break;
                case enumMessages.A02:
                    a = new A01(null, "A02");
                    break;
            }
            return a;
        }
    }

    public class segmentFactory : abstractFactory
    {
        abstractType a;
        public enum enumSegments { ERR,MSA,MSH,EVN,PID,PD1,PV1 };      //状态枚举声明
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            switch ((enumSegments)product)
            {
                case enumSegments.ERR:
                    a = new ERR(parent,name);
                    break;
                case enumSegments.EVN:
                    a = new EVN(parent,name);
                    break;
                case enumSegments.MSA:
                    a = new MSA(parent, name);
                    break;
                case enumSegments.MSH:
                    a = new MSH(parent, name);
                    break;
                case enumSegments.PID:
                    a = new PID(parent, name);
                    break;
                case enumSegments.PV1:
                    a = new PV1(parent, name);
                    break;
                case enumSegments.PD1:
                    a = new PD1(parent, name);
                    break;
            }

            return a;
        }
    }

    public class fieldFactory : abstractFactory
    {
        abstractType a;
        private primitiveFactory factory;
        public enum enumFields { HD,PT,EI,CE, VID,MSG,ELD,ERL,CWE,XTN,XCN,CX,XPN,XAD,DLN,XON,PL,FC};      //状态枚举声明
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            switch ((enumFields)product)
            {
                case enumFields.HD:
                    a = new HD(parent,name);
                    break;
                case enumFields.PT:
                    a = new PT(parent, name);
                    break;
                case enumFields.EI:
                    a = new EI(parent, name);
                    break;
                case enumFields.CE:
                    a = new CE(parent, name);
                    break;
                case enumFields.VID:
                    a = new VID(parent, name);
                    break;
                case enumFields.MSG:
                    a = new MSG(parent, name);
                    break;
                case enumFields.ELD:
                    a = new ELD(parent, name);
                    break;
                case enumFields.ERL:
                    a = new ERL(parent, name);
                    break;
                case enumFields.CWE:
                    a = new CWE(parent, name);
                    break;
                case enumFields.XTN:
                    a = new XTN(parent, name);
                    break;
                case enumFields.XCN:
                    a = new XCN(parent, name);
                    break;
                case enumFields.CX:
                    a = new CX(parent, name);
                    break;
                case enumFields.XPN:
                    a = new XPN(parent, name);
                    break;
                case enumFields.XAD:
                    a = new XAD(parent, name);
                    break;
                case enumFields.DLN:
                    a = new DLN(parent, name);
                    break;
                case enumFields.XON:
                    a = new XON(parent, name);
                    break;
                case enumFields.PL:
                    a = new PL(parent, name);
                    break;
                case enumFields.FC:
                    a = new FC(parent, name);
                    break;
                default:
                    a=factory.Create(parent,product,name);
                    break;                   
            }
            return a;
        }
    }

    public class primitiveFactory : abstractFactory
    {
        abstractType a;
        public enum enumPrimiteve { ID,IS,ST ,NM,DT,TM,TN,TX,FT,TS,SI,CM};      //状态枚举声明
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            switch ((enumPrimiteve)product)
            {
                case enumPrimiteve.ID:
                    a = new ID(name);
                    break;
                case enumPrimiteve.IS:
                    a = new IS(name);
                    break;
                case enumPrimiteve.ST:
                    a = new ST(name);
                    break;
            }

            return a;
        }
    }
}
