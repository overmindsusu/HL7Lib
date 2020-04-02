using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public static class common
    {
        public static string version = "2.4";//HL7 Version      
        public static string segmentDelimiter = "\r";
        public static string fieldDelimiter = "|";
        public static string componentDelimiter = "^";
        public static string subComponentDelimiter = "&";
        public static string repeatDelimiter = "~";
        public static string escapeDelimiter = "\\";
    }

  
    public abstract class abstractType
    {

        protected string name;
        protected string value;
        public abstractType(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => this.name;
            set
            {
                Name = value;
            }
        }

        public string Version
        {
            get => common.version;
            set
            {
                Version = value;
            }
        }

        public string Value
        {
            get => ToString();
            set
            {
                Parse(value);
            }
        }

        public abstract override string ToString();


        public abstract bool Parse(string text);

    }

    public class primitiveType : abstractType
    {
        public primitiveType(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return value;
        }

        public override bool Parse(string text)
        {
            value = text;
            return true;
        }
    }

    public class compositeType : abstractType
    {
        protected abstractType[] data;
        private string delimiter;

        public compositeType(compositeType parent, string name) : base(name)
        {
            //根据上层节点的分隔符选择当前节点的分隔符
            if (parent == null)
                delimiter = common.segmentDelimiter;
            else if (parent.delimiter == common.segmentDelimiter)
                delimiter = common.fieldDelimiter;
            else if (parent.delimiter == common.fieldDelimiter)
                delimiter = common.componentDelimiter;
            else if (parent.delimiter == common.componentDelimiter)
                delimiter = common.subComponentDelimiter;
        }


        public override string ToString()
        {
            string x = null;
            int i;
            //添加分隔符
            for (i=0;i<data.Length;i++)
            {
                x += data[i].ToString()+ this.delimiter;
            }

            //省略空值字段,字符转char使用TrimEnd
            char[] c = delimiter.ToCharArray();            
            x = x.TrimEnd(c[0]);
            return (x);
        }

        public override bool Parse(string text)
        {
            string[] subs = text.Split(delimiter[0]);
            for (int i = 0; i < subs.Length; i++)
            {
                if (subs[i] == null || subs[i].Length == 0) continue;
                data[i].Parse(subs[i]);
            }
            value = text;
            return true;

        }
    }

    public class compositeMessage : compositeType
    {
        public compositeMessage(compositeType parent, string name) : base(parent, name)
        {
        }
    }

    public class compositeField : compositeType
    {
        public compositeField(compositeType parent, string name) : base(parent, name)
        {
        }
    }

    public class compositeSegment : compositeType
    {
        public compositeSegment(compositeType parent, string name) : base(parent, name)
        {
        }
        public override bool Parse(string text)
        {
            //去除段名
            string[] subs = text.Split('|');
            for (int i = 1; i < subs.Length; i++)
            {
                if (subs[i] == null || subs[i].Length == 0) continue;
                //subs[0]为段名,不放入data
                data[i-1].Parse(subs[i]);
            }
            value = text;
            return true;

        }
        public override string ToString()
        {
            //加上段名
            string x = name;
            return (name+"|"+base.ToString());
        }
    }


}
