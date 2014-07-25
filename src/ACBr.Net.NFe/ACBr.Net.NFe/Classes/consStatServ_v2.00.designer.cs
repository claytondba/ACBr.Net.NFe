// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NFe.NET</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>True</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>True</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace ACBr.Net.NFe
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Xml;
    using ACBr.Net.NFe.TiposBasicos;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsStatServ
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TAmb tpAmbField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TCodUfIBGE cUFField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TConsStatServXServ xServField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string versaoField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TConsStatServXServ xServ
        {
            get
            {
                return this.xServField;
            }
            set
            {
                this.xServField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TConsStatServ));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TConsStatServ object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        public virtual string Serialize()
        {
            return Serialize(Encoding.UTF8);
        }

        /// <summary>
        /// Deserializes workflow markup into an TConsStatServ object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TConsStatServ object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TConsStatServ obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TConsStatServ);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out TConsStatServ obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TConsStatServ Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((TConsStatServ)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current TConsStatServ object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, Encoding.UTF8, out exception);
        }

        public virtual void SaveToFile(string fileName)
        {
            SaveToFile(fileName, Encoding.UTF8);
        }

        public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize(encoding);
                streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an TConsStatServ object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TConsStatServ object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TConsStatServ obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TConsStatServ);
            try
            {
                obj = LoadFromFile(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out TConsStatServ obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out TConsStatServ obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TConsStatServ LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, Encoding.UTF8);
        }

        public static TConsStatServ LoadFromFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file, encoding);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    //public enum TAmb
    //{

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("1")]
    //    Item1,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("2")]
    //    Item2,
    //}

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    //public enum TCodUfIBGE
    //{

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("11")]
    //    Item11,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("12")]
    //    Item12,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("13")]
    //    Item13,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("14")]
    //    Item14,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("15")]
    //    Item15,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("16")]
    //    Item16,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("17")]
    //    Item17,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("21")]
    //    Item21,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("22")]
    //    Item22,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("23")]
    //    Item23,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("24")]
    //    Item24,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("25")]
    //    Item25,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("26")]
    //    Item26,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("27")]
    //    Item27,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("28")]
    //    Item28,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("29")]
    //    Item29,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("31")]
    //    Item31,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("32")]
    //    Item32,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("33")]
    //    Item33,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("35")]
    //    Item35,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("41")]
    //    Item41,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("42")]
    //    Item42,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("43")]
    //    Item43,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("50")]
    //    Item50,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("51")]
    //    Item51,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("52")]
    //    Item52,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("53")]
    //    Item53,
    //}

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsStatServXServ
    {

        /// <remarks/>
        STATUS,
    }
}
