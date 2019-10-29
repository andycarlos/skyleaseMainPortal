namespace Skylease.Models.awb
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1", IsNullable = false)]
    public partial class diffgram
    {

        private NewDataSet newDataSetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public NewDataSet NewDataSet
        {
            get
            {
                return this.newDataSetField;
            }
            set
            {
                this.newDataSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private NewDataSetTable tableField;

        /// <remarks/>
        public NewDataSetTable Table
        {
            get
            {
                return this.tableField;
            }
            set
            {
                this.tableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NewDataSetTable
    {

        private ulong awbField;

        private System.DateTime dateField;

        private string originField;

        private string destinationField;

        private int totpiecesField;

        private decimal totweightField;

        private decimal totvolumeField;

        private string useridField;

        private string idField;

        private int rowOrderField;

        /// <remarks/>
        public ulong awb
        {
            get
            {
                return this.awbField;
            }
            set
            {
                this.awbField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        public string destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        public int totpieces
        {
            get
            {
                return this.totpiecesField;
            }
            set
            {
                this.totpiecesField = value;
            }
        }

        /// <remarks/>
        public decimal totweight
        {
            get
            {
                return this.totweightField;
            }
            set
            {
                this.totweightField = value;
            }
        }

        /// <remarks/>
        public decimal totvolume
        {
            get
            {
                return this.totvolumeField;
            }
            set
            {
                this.totvolumeField = value;
            }
        }

        /// <remarks/>
        public string userid
        {
            get
            {
                return this.useridField;
            }
            set
            {
                this.useridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-msdata")]
        public int rowOrder
        {
            get
            {
                return this.rowOrderField;
            }
            set
            {
                this.rowOrderField = value;
            }
        }
    }
}
namespace Skylease.Models.trakingHistory
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1", IsNullable = false)]
    public partial class diffgram
    {

        private NewDataSetTable[] newDataSetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Table", IsNullable = false)]
        public NewDataSetTable[] NewDataSet
        {
            get
            {
                return this.newDataSetField;
            }
            set
            {
                this.newDataSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NewDataSetTable
    {

        private uint idField;

        private string sOURCEField;

        private string tYPEField;

        private ulong cODEField;

        private System.DateTime dATEINField;

        private ulong rEFERENCEField;

        private byte pIECESField;

        private ushort wEIGHTField;

        private string nOTEField;

        private string uSERIDField;

        private System.DateTime dATEINFField;

        private string idField1;

        private byte rowOrderField;

        /// <remarks/>
        public uint ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string SOURCE
        {
            get
            {
                return this.sOURCEField;
            }
            set
            {
                this.sOURCEField = value;
            }
        }

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public ulong CODE
        {
            get
            {
                return this.cODEField;
            }
            set
            {
                this.cODEField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DATEIN
        {
            get
            {
                return this.dATEINField;
            }
            set
            {
                this.dATEINField = value;
            }
        }

        /// <remarks/>
        public ulong REFERENCE
        {
            get
            {
                return this.rEFERENCEField;
            }
            set
            {
                this.rEFERENCEField = value;
            }
        }

        /// <remarks/>
        public byte PIECES
        {
            get
            {
                return this.pIECESField;
            }
            set
            {
                this.pIECESField = value;
            }
        }

        /// <remarks/>
        public ushort WEIGHT
        {
            get
            {
                return this.wEIGHTField;
            }
            set
            {
                this.wEIGHTField = value;
            }
        }

        /// <remarks/>
        public string NOTE
        {
            get
            {
                return this.nOTEField;
            }
            set
            {
                this.nOTEField = value;
            }
        }

        /// <remarks/>
        public string USERID
        {
            get
            {
                return this.uSERIDField;
            }
            set
            {
                this.uSERIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DATEINF
        {
            get
            {
                return this.dATEINFField;
            }
            set
            {
                this.dATEINFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public string id
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-msdata")]
        public byte rowOrder
        {
            get
            {
                return this.rowOrderField;
            }
            set
            {
                this.rowOrderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private NewDataSetTable[] tableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Table")]
        public NewDataSetTable[] Table
        {
            get
            {
                return this.tableField;
            }
            set
            {
                this.tableField = value;
            }
        }
    }


}
namespace Skylease.Models.agent
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1", IsNullable = false)]
    public partial class diffgram
    {

        private NewDataSet newDataSetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public NewDataSet NewDataSet
        {
            get
            {
                return this.newDataSetField;
            }
            set
            {
                this.newDataSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private NewDataSetTable tableField;

        /// <remarks/>
        public NewDataSetTable Table
        {
            get
            {
                return this.tableField;
            }
            set
            {
                this.tableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NewDataSetTable
    {

        private ushort codeField;

        private string nameField;

        private string baseField;

        private string emailField;

        private string idField;

        private int rowOrderField;

        /// <remarks/>
        public ushort Code
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
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-msdata")]
        public int rowOrder
        {
            get
            {
                return this.rowOrderField;
            }
            set
            {
                this.rowOrderField = value;
            }
        }
    }
}
