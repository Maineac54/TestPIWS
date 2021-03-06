﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestPIWS.PIWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xml.osisoft.com/services/PIDataService", ConfigurationName="PIWebService.IPITimeSeries")]
    public interface IPITimeSeries {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/GetPIArchiveData", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/GetPIArchiveDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.TimeSeries[] GetPIArchiveData(TestPIWS.PIWebService.PIArcDataRequest[] requests);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/GetPIUpdates", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/GetPIUpdatesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.TimeSeriesUpdates[] GetPIUpdates(System.Guid updateTicket, ushort maxWaitForUpdates, TestPIWS.PIWebService.UpdateFilterType evtFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/SignUpForPIUpdates", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/SignUpForPIUpdatesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.SignUpResults SignUpForPIUpdates(string[] paths, ushort expiration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/CancelSignUpForPIUpdates", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/CancelSignUpForPIUpdatesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        void CancelSignUpForPIUpdates(System.Guid updateTicket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/ListPaths", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/ListPathssResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        string[] ListPathsByUpdateTicket(System.Guid updateTicket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/GetPISnapshotData", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/GetPISnapshotDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.TimeSeries[] GetPISnapshotData(string[] paths);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/GetPISummaryData", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/GetPISummaryDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.TimeSeries[] GetPISummaryData(TestPIWS.PIWebService.PISummaryDataRequest[] requests);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/InsertPIData", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/InsertPIDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        TestPIWS.PIWebService.TimeSeries InsertPIData(TestPIWS.PIWebService.TimeSeries[] events, TestPIWS.PIWebService.InsertPIDataDuplicateSwitch duplicateSwitch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xml.osisoft.com/services/IPITimeSeries/GetProductVersion", ReplyAction="http://xml.osisoft.com/services/IPITimeSeries/GetProductVersionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DataItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIManner))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIConstraint))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PIDataRequest))]
        string GetProductVersion();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class PIArcDataRequest : PIDataRequest {
        
        private PIArcManner pIArcMannerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public PIArcManner PIArcManner {
            get {
                return this.pIArcMannerField;
            }
            set {
                this.pIArcMannerField = value;
                this.RaisePropertyChanged("PIArcManner");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class PIArcManner : PIManner {
        
        private PIArcMannerRetrievalType retrievalTypeField;
        
        private int numValuesField;
        
        private PIArcMannerBoundaries boundariesField;
        
        public PIArcManner() {
            this.retrievalTypeField = PIArcMannerRetrievalType.Compressed;
            this.numValuesField = 400;
            this.boundariesField = PIArcMannerBoundaries.Inside;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PIArcMannerRetrievalType.Compressed)]
        public PIArcMannerRetrievalType RetrievalType {
            get {
                return this.retrievalTypeField;
            }
            set {
                this.retrievalTypeField = value;
                this.RaisePropertyChanged("RetrievalType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(400)]
        public int NumValues {
            get {
                return this.numValuesField;
            }
            set {
                this.numValuesField = value;
                this.RaisePropertyChanged("NumValues");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PIArcMannerBoundaries.Inside)]
        public PIArcMannerBoundaries Boundaries {
            get {
                return this.boundariesField;
            }
            set {
                this.boundariesField = value;
                this.RaisePropertyChanged("Boundaries");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum PIArcMannerRetrievalType {
        
        /// <remarks/>
        Compressed,
        
        /// <remarks/>
        Interpolated,
        
        /// <remarks/>
        PlotValues,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum PIArcMannerBoundaries {
        
        /// <remarks/>
        Inside,
        
        /// <remarks/>
        Outside,
        
        /// <remarks/>
        Interpolated,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PISummaryManner))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIArcManner))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public abstract partial class PIManner : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string filterField;
        
        private bool updatesField;
        
        public PIManner() {
            this.updatesField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
                this.RaisePropertyChanged("Filter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Updates {
            get {
                return this.updatesField;
            }
            set {
                this.updatesField = value;
                this.RaisePropertyChanged("Updates");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class SignUpResults : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid updateTicketField;
        
        private int[] errorsField;
        
        private string[] errDescsField;
        
        private int errorCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid UpdateTicket {
            get {
                return this.updateTicketField;
            }
            set {
                this.updateTicketField = value;
                this.RaisePropertyChanged("UpdateTicket");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", Order=1)]
        public int[] Errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
                this.RaisePropertyChanged("Errors");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrDescs", Order=2)]
        public string[] ErrDescs {
            get {
                return this.errDescsField;
            }
            set {
                this.errDescsField = value;
                this.RaisePropertyChanged("ErrDescs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int ErrorCount {
            get {
                return this.errorCountField;
            }
            set {
                this.errorCountField = value;
                this.RaisePropertyChanged("ErrorCount");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimedValueUpdate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class TimedValue : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string pathField;
        
        private string flagsField;
        
        private System.DateTime timeField;
        
        private string uOMField;
        
        private string statusField;
        
        private double pctGoodField;
        
        private bool pctGoodFieldSpecified;
        
        private string dataTypeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("Path");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Flags {
            get {
                return this.flagsField;
            }
            set {
                this.flagsField = value;
                this.RaisePropertyChanged("Flags");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
                this.RaisePropertyChanged("Time");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UOM {
            get {
                return this.uOMField;
            }
            set {
                this.uOMField = value;
                this.RaisePropertyChanged("UOM");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double PctGood {
            get {
                return this.pctGoodField;
            }
            set {
                this.pctGoodField = value;
                this.RaisePropertyChanged("PctGood");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PctGoodSpecified {
            get {
                return this.pctGoodFieldSpecified;
            }
            set {
                this.pctGoodFieldSpecified = value;
                this.RaisePropertyChanged("PctGoodSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
                this.RaisePropertyChanged("DataType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class TimedValueUpdate : TimedValue {
        
        private UpdateType updateTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UpdateType UpdateType {
            get {
                return this.updateTypeField;
            }
            set {
                this.updateTypeField = value;
                this.RaisePropertyChanged("UpdateType");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum UpdateType {
        
        /// <remarks/>
        Archive,
        
        /// <remarks/>
        Snapshot,
        
        /// <remarks/>
        Delete,
        
        /// <remarks/>
        Edit,
        
        /// <remarks/>
        AddNoReplace,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeries))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesUpdates))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public abstract partial class DataItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesUpdates))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class TimeSeries : DataItem {
        
        private TimedValue[] timedValuesField;
        
        private string pathField;
        
        private string errDescField;
        
        private int errorField;
        
        private string seriesIDField;
        
        private string dataTypeField;
        
        private string uOMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=0)]
        public TimedValue[] TimedValues {
            get {
                return this.timedValuesField;
            }
            set {
                this.timedValuesField = value;
                this.RaisePropertyChanged("TimedValues");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("Path");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrDesc {
            get {
                return this.errDescField;
            }
            set {
                this.errDescField = value;
                this.RaisePropertyChanged("ErrDesc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
                this.RaisePropertyChanged("Error");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeriesID {
            get {
                return this.seriesIDField;
            }
            set {
                this.seriesIDField = value;
                this.RaisePropertyChanged("SeriesID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
                this.RaisePropertyChanged("DataType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UOM {
            get {
                return this.uOMField;
            }
            set {
                this.uOMField = value;
                this.RaisePropertyChanged("UOM");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class TimeSeriesUpdates : TimeSeries {
        
        private TimedValueUpdate[] updatesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=0)]
        public TimedValueUpdate[] Updates {
            get {
                return this.updatesField;
            }
            set {
                this.updatesField = value;
                this.RaisePropertyChanged("Updates");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRange))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public abstract partial class PIConstraint : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class TimeRange : PIConstraint {
        
        private string startField;
        
        private string endField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
                this.RaisePropertyChanged("Start");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string End {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
                this.RaisePropertyChanged("End");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PISummaryDataRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIArcDataRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public abstract partial class PIDataRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TimeRange timeRangeField;
        
        private string pathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TimeRange TimeRange {
            get {
                return this.timeRangeField;
            }
            set {
                this.timeRangeField = value;
                this.RaisePropertyChanged("TimeRange");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
                this.RaisePropertyChanged("Path");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class PISummaryDataRequest : PIDataRequest {
        
        private PISummaryManner pISummaryMannerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public PISummaryManner PISummaryManner {
            get {
                return this.pISummaryMannerField;
            }
            set {
                this.pISummaryMannerField = value;
                this.RaisePropertyChanged("PISummaryManner");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public partial class PISummaryManner : PIManner {
        
        private PISummaryMannerSummaryValue summaryValueField;
        
        private int intervalsField;
        
        private PISummaryMannerWeightType weightTypeField;
        
        private bool useStartField;
        
        public PISummaryManner() {
            this.summaryValueField = PISummaryMannerSummaryValue.Average;
            this.weightTypeField = PISummaryMannerWeightType.TimeWeighted;
            this.useStartField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PISummaryMannerSummaryValue.Average)]
        public PISummaryMannerSummaryValue SummaryValue {
            get {
                return this.summaryValueField;
            }
            set {
                this.summaryValueField = value;
                this.RaisePropertyChanged("SummaryValue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Intervals {
            get {
                return this.intervalsField;
            }
            set {
                this.intervalsField = value;
                this.RaisePropertyChanged("Intervals");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PISummaryMannerWeightType.TimeWeighted)]
        public PISummaryMannerWeightType WeightType {
            get {
                return this.weightTypeField;
            }
            set {
                this.weightTypeField = value;
                this.RaisePropertyChanged("WeightType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseStart {
            get {
                return this.useStartField;
            }
            set {
                this.useStartField = value;
                this.RaisePropertyChanged("UseStart");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum PISummaryMannerSummaryValue {
        
        /// <remarks/>
        Average,
        
        /// <remarks/>
        Minimum,
        
        /// <remarks/>
        Maximum,
        
        /// <remarks/>
        Range,
        
        /// <remarks/>
        StdDev,
        
        /// <remarks/>
        Total,
        
        /// <remarks/>
        PStdDev,
        
        /// <remarks/>
        Count,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum PISummaryMannerWeightType {
        
        /// <remarks/>
        TimeWeighted,
        
        /// <remarks/>
        EventWeighted,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum UpdateFilterType {
        
        /// <remarks/>
        Snapshot,
        
        /// <remarks/>
        Archive,
        
        /// <remarks/>
        SnapshotAndArchive,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml.osisoft.com/services/PIDataService")]
    public enum InsertPIDataDuplicateSwitch {
        
        /// <remarks/>
        InsertDuplicate,
        
        /// <remarks/>
        ReplaceDuplicate,
        
        /// <remarks/>
        ReplaceOnlyDuplicate,
        
        /// <remarks/>
        ErrorDuplicate,
        
        /// <remarks/>
        ErrorDuplicatesSilent,
        
        /// <remarks/>
        ReplaceOnlyDuplicatesSilent,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPITimeSeriesChannel : TestPIWS.PIWebService.IPITimeSeries, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PITimeSeriesClient : System.ServiceModel.ClientBase<TestPIWS.PIWebService.IPITimeSeries>, TestPIWS.PIWebService.IPITimeSeries {
        
        public PITimeSeriesClient() {
        }
        
        public PITimeSeriesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PITimeSeriesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PITimeSeriesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PITimeSeriesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestPIWS.PIWebService.TimeSeries[] GetPIArchiveData(TestPIWS.PIWebService.PIArcDataRequest[] requests) {
            return base.Channel.GetPIArchiveData(requests);
        }
        
        public TestPIWS.PIWebService.TimeSeriesUpdates[] GetPIUpdates(System.Guid updateTicket, ushort maxWaitForUpdates, TestPIWS.PIWebService.UpdateFilterType evtFilter) {
            return base.Channel.GetPIUpdates(updateTicket, maxWaitForUpdates, evtFilter);
        }
        
        public TestPIWS.PIWebService.SignUpResults SignUpForPIUpdates(string[] paths, ushort expiration) {
            return base.Channel.SignUpForPIUpdates(paths, expiration);
        }
        
        public void CancelSignUpForPIUpdates(System.Guid updateTicket) {
            base.Channel.CancelSignUpForPIUpdates(updateTicket);
        }
        
        public string[] ListPathsByUpdateTicket(System.Guid updateTicket) {
            return base.Channel.ListPathsByUpdateTicket(updateTicket);
        }
        
        public TestPIWS.PIWebService.TimeSeries[] GetPISnapshotData(string[] paths) {
            return base.Channel.GetPISnapshotData(paths);
        }
        
        public TestPIWS.PIWebService.TimeSeries[] GetPISummaryData(TestPIWS.PIWebService.PISummaryDataRequest[] requests) {
            return base.Channel.GetPISummaryData(requests);
        }
        
        public TestPIWS.PIWebService.TimeSeries InsertPIData(TestPIWS.PIWebService.TimeSeries[] events, TestPIWS.PIWebService.InsertPIDataDuplicateSwitch duplicateSwitch) {
            return base.Channel.InsertPIData(events, duplicateSwitch);
        }
        
        public string GetProductVersion() {
            return base.Channel.GetProductVersion();
        }
    }
}
