﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace HiiP.Framework.Settings.BusinessEntity {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("LoggingFilterDS")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class LoggingFilterDS : global::System.Data.DataSet {
        
        private T_IC_LOGGING_FILTERDataTable tableT_IC_LOGGING_FILTER;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public LoggingFilterDS() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected LoggingFilterDS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["T_IC_LOGGING_FILTER"] != null)) {
                    base.Tables.Add(new T_IC_LOGGING_FILTERDataTable(ds.Tables["T_IC_LOGGING_FILTER"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public T_IC_LOGGING_FILTERDataTable T_IC_LOGGING_FILTER {
            get {
                return this.tableT_IC_LOGGING_FILTER;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            LoggingFilterDS cln = ((LoggingFilterDS)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["T_IC_LOGGING_FILTER"] != null)) {
                    base.Tables.Add(new T_IC_LOGGING_FILTERDataTable(ds.Tables["T_IC_LOGGING_FILTER"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableT_IC_LOGGING_FILTER = ((T_IC_LOGGING_FILTERDataTable)(base.Tables["T_IC_LOGGING_FILTER"]));
            if ((initTable == true)) {
                if ((this.tableT_IC_LOGGING_FILTER != null)) {
                    this.tableT_IC_LOGGING_FILTER.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "LoggingFilterDS";
            this.Prefix = "";
            this.Namespace = "http://hiip.ooh.dhs.vic.gov.au/LoggingFilterDS.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableT_IC_LOGGING_FILTER = new T_IC_LOGGING_FILTERDataTable();
            base.Tables.Add(this.tableT_IC_LOGGING_FILTER);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeT_IC_LOGGING_FILTER() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            LoggingFilterDS ds = new LoggingFilterDS();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        public delegate void T_IC_LOGGING_FILTERRowChangeEventHandler(object sender, T_IC_LOGGING_FILTERRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class T_IC_LOGGING_FILTERDataTable : global::System.Data.TypedTableBase<T_IC_LOGGING_FILTERRow> {
            
            private global::System.Data.DataColumn columnCATEGORY;
            
            private global::System.Data.DataColumn columnUSER_ID;
            
            private global::System.Data.DataColumn columnFLAG;
            
            private global::System.Data.DataColumn columnVERSION_NO;
            
            private global::System.Data.DataColumn columnTRANSACTION_ID;
            
            private global::System.Data.DataColumn columnCREATED_BY;
            
            private global::System.Data.DataColumn columnCREATED_TIME;
            
            private global::System.Data.DataColumn columnLAST_UPDATED_BY;
            
            private global::System.Data.DataColumn columnLAST_UPDATED_TIME;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERDataTable() {
                this.TableName = "T_IC_LOGGING_FILTER";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal T_IC_LOGGING_FILTERDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected T_IC_LOGGING_FILTERDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn CATEGORYColumn {
                get {
                    return this.columnCATEGORY;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn USER_IDColumn {
                get {
                    return this.columnUSER_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn FLAGColumn {
                get {
                    return this.columnFLAG;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn VERSION_NOColumn {
                get {
                    return this.columnVERSION_NO;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn TRANSACTION_IDColumn {
                get {
                    return this.columnTRANSACTION_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn CREATED_BYColumn {
                get {
                    return this.columnCREATED_BY;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn CREATED_TIMEColumn {
                get {
                    return this.columnCREATED_TIME;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn LAST_UPDATED_BYColumn {
                get {
                    return this.columnLAST_UPDATED_BY;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn LAST_UPDATED_TIMEColumn {
                get {
                    return this.columnLAST_UPDATED_TIME;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRow this[int index] {
                get {
                    return ((T_IC_LOGGING_FILTERRow)(this.Rows[index]));
                }
            }
            
            public event T_IC_LOGGING_FILTERRowChangeEventHandler T_IC_LOGGING_FILTERRowChanging;
            
            public event T_IC_LOGGING_FILTERRowChangeEventHandler T_IC_LOGGING_FILTERRowChanged;
            
            public event T_IC_LOGGING_FILTERRowChangeEventHandler T_IC_LOGGING_FILTERRowDeleting;
            
            public event T_IC_LOGGING_FILTERRowChangeEventHandler T_IC_LOGGING_FILTERRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddT_IC_LOGGING_FILTERRow(T_IC_LOGGING_FILTERRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRow AddT_IC_LOGGING_FILTERRow(string CATEGORY, string USER_ID, int FLAG, int VERSION_NO, string TRANSACTION_ID, string CREATED_BY, System.DateTime CREATED_TIME, string LAST_UPDATED_BY, System.DateTime LAST_UPDATED_TIME) {
                T_IC_LOGGING_FILTERRow rowT_IC_LOGGING_FILTERRow = ((T_IC_LOGGING_FILTERRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        CATEGORY,
                        USER_ID,
                        FLAG,
                        VERSION_NO,
                        TRANSACTION_ID,
                        CREATED_BY,
                        CREATED_TIME,
                        LAST_UPDATED_BY,
                        LAST_UPDATED_TIME};
                rowT_IC_LOGGING_FILTERRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowT_IC_LOGGING_FILTERRow);
                return rowT_IC_LOGGING_FILTERRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRow FindByCATEGORYUSER_ID(string CATEGORY, string USER_ID) {
                return ((T_IC_LOGGING_FILTERRow)(this.Rows.Find(new object[] {
                            CATEGORY,
                            USER_ID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                T_IC_LOGGING_FILTERDataTable cln = ((T_IC_LOGGING_FILTERDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new T_IC_LOGGING_FILTERDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnCATEGORY = base.Columns["CATEGORY"];
                this.columnUSER_ID = base.Columns["USER_ID"];
                this.columnFLAG = base.Columns["FLAG"];
                this.columnVERSION_NO = base.Columns["VERSION_NO"];
                this.columnTRANSACTION_ID = base.Columns["TRANSACTION_ID"];
                this.columnCREATED_BY = base.Columns["CREATED_BY"];
                this.columnCREATED_TIME = base.Columns["CREATED_TIME"];
                this.columnLAST_UPDATED_BY = base.Columns["LAST_UPDATED_BY"];
                this.columnLAST_UPDATED_TIME = base.Columns["LAST_UPDATED_TIME"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnCATEGORY = new global::System.Data.DataColumn("CATEGORY", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCATEGORY);
                this.columnUSER_ID = new global::System.Data.DataColumn("USER_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnUSER_ID);
                this.columnFLAG = new global::System.Data.DataColumn("FLAG", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFLAG);
                this.columnVERSION_NO = new global::System.Data.DataColumn("VERSION_NO", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnVERSION_NO);
                this.columnTRANSACTION_ID = new global::System.Data.DataColumn("TRANSACTION_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTRANSACTION_ID);
                this.columnCREATED_BY = new global::System.Data.DataColumn("CREATED_BY", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCREATED_BY);
                this.columnCREATED_TIME = new global::System.Data.DataColumn("CREATED_TIME", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCREATED_TIME);
                this.columnLAST_UPDATED_BY = new global::System.Data.DataColumn("LAST_UPDATED_BY", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLAST_UPDATED_BY);
                this.columnLAST_UPDATED_TIME = new global::System.Data.DataColumn("LAST_UPDATED_TIME", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLAST_UPDATED_TIME);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnCATEGORY,
                                this.columnUSER_ID}, true));
                this.columnCATEGORY.AllowDBNull = false;
                this.columnCATEGORY.MaxLength = 50;
                this.columnUSER_ID.AllowDBNull = false;
                this.columnUSER_ID.MaxLength = 50;
                this.columnVERSION_NO.AllowDBNull = false;
                this.columnTRANSACTION_ID.AllowDBNull = false;
                this.columnTRANSACTION_ID.MaxLength = 50;
                this.columnCREATED_BY.AllowDBNull = false;
                this.columnCREATED_BY.MaxLength = 256;
                this.columnCREATED_TIME.AllowDBNull = false;
                this.columnLAST_UPDATED_BY.AllowDBNull = false;
                this.columnLAST_UPDATED_BY.MaxLength = 256;
                this.columnLAST_UPDATED_TIME.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRow NewT_IC_LOGGING_FILTERRow() {
                return ((T_IC_LOGGING_FILTERRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new T_IC_LOGGING_FILTERRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(T_IC_LOGGING_FILTERRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.T_IC_LOGGING_FILTERRowChanged != null)) {
                    this.T_IC_LOGGING_FILTERRowChanged(this, new T_IC_LOGGING_FILTERRowChangeEvent(((T_IC_LOGGING_FILTERRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.T_IC_LOGGING_FILTERRowChanging != null)) {
                    this.T_IC_LOGGING_FILTERRowChanging(this, new T_IC_LOGGING_FILTERRowChangeEvent(((T_IC_LOGGING_FILTERRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.T_IC_LOGGING_FILTERRowDeleted != null)) {
                    this.T_IC_LOGGING_FILTERRowDeleted(this, new T_IC_LOGGING_FILTERRowChangeEvent(((T_IC_LOGGING_FILTERRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.T_IC_LOGGING_FILTERRowDeleting != null)) {
                    this.T_IC_LOGGING_FILTERRowDeleting(this, new T_IC_LOGGING_FILTERRowChangeEvent(((T_IC_LOGGING_FILTERRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveT_IC_LOGGING_FILTERRow(T_IC_LOGGING_FILTERRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                LoggingFilterDS ds = new LoggingFilterDS();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "T_IC_LOGGING_FILTERDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class T_IC_LOGGING_FILTERRow : global::System.Data.DataRow {
            
            private T_IC_LOGGING_FILTERDataTable tableT_IC_LOGGING_FILTER;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal T_IC_LOGGING_FILTERRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableT_IC_LOGGING_FILTER = ((T_IC_LOGGING_FILTERDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string CATEGORY {
                get {
                    return ((string)(this[this.tableT_IC_LOGGING_FILTER.CATEGORYColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.CATEGORYColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string USER_ID {
                get {
                    return ((string)(this[this.tableT_IC_LOGGING_FILTER.USER_IDColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.USER_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int FLAG {
                get {
                    try {
                        return ((int)(this[this.tableT_IC_LOGGING_FILTER.FLAGColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'FLAG\' in table \'T_IC_LOGGING_FILTER\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.FLAGColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int VERSION_NO {
                get {
                    return ((int)(this[this.tableT_IC_LOGGING_FILTER.VERSION_NOColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.VERSION_NOColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string TRANSACTION_ID {
                get {
                    return ((string)(this[this.tableT_IC_LOGGING_FILTER.TRANSACTION_IDColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.TRANSACTION_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string CREATED_BY {
                get {
                    return ((string)(this[this.tableT_IC_LOGGING_FILTER.CREATED_BYColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.CREATED_BYColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime CREATED_TIME {
                get {
                    return ((global::System.DateTime)(this[this.tableT_IC_LOGGING_FILTER.CREATED_TIMEColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.CREATED_TIMEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string LAST_UPDATED_BY {
                get {
                    return ((string)(this[this.tableT_IC_LOGGING_FILTER.LAST_UPDATED_BYColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.LAST_UPDATED_BYColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime LAST_UPDATED_TIME {
                get {
                    return ((global::System.DateTime)(this[this.tableT_IC_LOGGING_FILTER.LAST_UPDATED_TIMEColumn]));
                }
                set {
                    this[this.tableT_IC_LOGGING_FILTER.LAST_UPDATED_TIMEColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsFLAGNull() {
                return this.IsNull(this.tableT_IC_LOGGING_FILTER.FLAGColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetFLAGNull() {
                this[this.tableT_IC_LOGGING_FILTER.FLAGColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class T_IC_LOGGING_FILTERRowChangeEvent : global::System.EventArgs {
            
            private T_IC_LOGGING_FILTERRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRowChangeEvent(T_IC_LOGGING_FILTERRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public T_IC_LOGGING_FILTERRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591