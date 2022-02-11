// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: xmkprojunit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServiceApp {

  /// <summary>Holder for reflection information generated from xmkprojunit.proto</summary>
  public static partial class XmkprojunitReflection {

    #region Descriptor
    /// <summary>File descriptor for xmkprojunit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static XmkprojunitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChF4bWtwcm9qdW5pdC5wcm90bxIDeG1rIgUKA052bCIUCgREYXRhEgwKBGRh",
            "dGEYASABKAkiJwoUUXVlcnlQcm9qVW5pdFJlcXVlc3QSDwoHcHJvQ29kZRgB",
            "IAEoCSI4ChVRdWVyeVByb2pVbml0UmVzcG9uc2USHwoFdW5pdHMYASADKAsy",
            "EC54bWsuWG1rUHJvalVuaXQidwoLWG1rUHJvalVuaXQSDgoGaXRlbUlkGAEg",
            "ASgJEg8KB3Byb0NvZGUYAiABKAkSDgoGYWdlbmN5GAMgASgFEhIKCmFnZW5j",
            "eVR5cGUYBCABKAkSDwoHYmRnWWVhchgFIAEoBRISCgphZG1kaXZDb2RlGAYg",
            "ASgJMnsKElhta1Byb2pVbml0U2VydmljZRI8Cg1RdWVyeVByb2pVbml0Ehku",
            "eG1rLlF1ZXJ5UHJvalVuaXRSZXF1ZXN0GhAueG1rLlhta1Byb2pVbml0EicK",
            "EFF1ZXJ5UHJvalVuaXRBbGwSCC54bWsuTnZsGgkueG1rLkRhdGFCEaoCDkdy",
            "cGNTZXJ2aWNlQXBwYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceApp.Nvl), global::GrpcServiceApp.Nvl.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceApp.Data), global::GrpcServiceApp.Data.Parser, new[]{ "Data_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceApp.QueryProjUnitRequest), global::GrpcServiceApp.QueryProjUnitRequest.Parser, new[]{ "ProCode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceApp.QueryProjUnitResponse), global::GrpcServiceApp.QueryProjUnitResponse.Parser, new[]{ "Units" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceApp.XmkProjUnit), global::GrpcServiceApp.XmkProjUnit.Parser, new[]{ "ItemId", "ProCode", "Agency", "AgencyType", "BdgYear", "AdmdivCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Nvl : pb::IMessage<Nvl> {
    private static readonly pb::MessageParser<Nvl> _parser = new pb::MessageParser<Nvl>(() => new Nvl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Nvl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nvl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nvl(Nvl other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Nvl Clone() {
      return new Nvl(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Nvl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Nvl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Nvl other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class Data : pb::IMessage<Data> {
    private static readonly pb::MessageParser<Data> _parser = new pb::MessageParser<Data>(() => new Data());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Data> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Data() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Data(Data other) : this() {
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Data Clone() {
      return new Data(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int Data_FieldNumber = 1;
    private string data_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Data_ {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Data);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Data other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data_ != other.Data_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Data_.Length != 0) hash ^= Data_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Data_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Data_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Data_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Data_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Data other) {
      if (other == null) {
        return;
      }
      if (other.Data_.Length != 0) {
        Data_ = other.Data_;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Data_ = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QueryProjUnitRequest : pb::IMessage<QueryProjUnitRequest> {
    private static readonly pb::MessageParser<QueryProjUnitRequest> _parser = new pb::MessageParser<QueryProjUnitRequest>(() => new QueryProjUnitRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryProjUnitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitRequest(QueryProjUnitRequest other) : this() {
      proCode_ = other.proCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitRequest Clone() {
      return new QueryProjUnitRequest(this);
    }

    /// <summary>Field number for the "proCode" field.</summary>
    public const int ProCodeFieldNumber = 1;
    private string proCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProCode {
      get { return proCode_; }
      set {
        proCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryProjUnitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryProjUnitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProCode != other.ProCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProCode.Length != 0) hash ^= ProCode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryProjUnitRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProCode.Length != 0) {
        ProCode = other.ProCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ProCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QueryProjUnitResponse : pb::IMessage<QueryProjUnitResponse> {
    private static readonly pb::MessageParser<QueryProjUnitResponse> _parser = new pb::MessageParser<QueryProjUnitResponse>(() => new QueryProjUnitResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryProjUnitResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitResponse(QueryProjUnitResponse other) : this() {
      units_ = other.units_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryProjUnitResponse Clone() {
      return new QueryProjUnitResponse(this);
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcServiceApp.XmkProjUnit> _repeated_units_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcServiceApp.XmkProjUnit.Parser);
    private readonly pbc::RepeatedField<global::GrpcServiceApp.XmkProjUnit> units_ = new pbc::RepeatedField<global::GrpcServiceApp.XmkProjUnit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcServiceApp.XmkProjUnit> Units {
      get { return units_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryProjUnitResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryProjUnitResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!units_.Equals(other.units_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= units_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      units_.WriteTo(output, _repeated_units_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += units_.CalculateSize(_repeated_units_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryProjUnitResponse other) {
      if (other == null) {
        return;
      }
      units_.Add(other.units_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            units_.AddEntriesFrom(input, _repeated_units_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class XmkProjUnit : pb::IMessage<XmkProjUnit> {
    private static readonly pb::MessageParser<XmkProjUnit> _parser = new pb::MessageParser<XmkProjUnit>(() => new XmkProjUnit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<XmkProjUnit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceApp.XmkprojunitReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XmkProjUnit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XmkProjUnit(XmkProjUnit other) : this() {
      itemId_ = other.itemId_;
      proCode_ = other.proCode_;
      agency_ = other.agency_;
      agencyType_ = other.agencyType_;
      bdgYear_ = other.bdgYear_;
      admdivCode_ = other.admdivCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XmkProjUnit Clone() {
      return new XmkProjUnit(this);
    }

    /// <summary>Field number for the "itemId" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private string itemId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ItemId {
      get { return itemId_; }
      set {
        itemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "proCode" field.</summary>
    public const int ProCodeFieldNumber = 2;
    private string proCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProCode {
      get { return proCode_; }
      set {
        proCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "agency" field.</summary>
    public const int AgencyFieldNumber = 3;
    private int agency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Agency {
      get { return agency_; }
      set {
        agency_ = value;
      }
    }

    /// <summary>Field number for the "agencyType" field.</summary>
    public const int AgencyTypeFieldNumber = 4;
    private string agencyType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AgencyType {
      get { return agencyType_; }
      set {
        agencyType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bdgYear" field.</summary>
    public const int BdgYearFieldNumber = 5;
    private int bdgYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BdgYear {
      get { return bdgYear_; }
      set {
        bdgYear_ = value;
      }
    }

    /// <summary>Field number for the "admdivCode" field.</summary>
    public const int AdmdivCodeFieldNumber = 6;
    private string admdivCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdmdivCode {
      get { return admdivCode_; }
      set {
        admdivCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as XmkProjUnit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(XmkProjUnit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ProCode != other.ProCode) return false;
      if (Agency != other.Agency) return false;
      if (AgencyType != other.AgencyType) return false;
      if (BdgYear != other.BdgYear) return false;
      if (AdmdivCode != other.AdmdivCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId.Length != 0) hash ^= ItemId.GetHashCode();
      if (ProCode.Length != 0) hash ^= ProCode.GetHashCode();
      if (Agency != 0) hash ^= Agency.GetHashCode();
      if (AgencyType.Length != 0) hash ^= AgencyType.GetHashCode();
      if (BdgYear != 0) hash ^= BdgYear.GetHashCode();
      if (AdmdivCode.Length != 0) hash ^= AdmdivCode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ItemId);
      }
      if (ProCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProCode);
      }
      if (Agency != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Agency);
      }
      if (AgencyType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AgencyType);
      }
      if (BdgYear != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BdgYear);
      }
      if (AdmdivCode.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AdmdivCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemId);
      }
      if (ProCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProCode);
      }
      if (Agency != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Agency);
      }
      if (AgencyType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AgencyType);
      }
      if (BdgYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BdgYear);
      }
      if (AdmdivCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdmdivCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(XmkProjUnit other) {
      if (other == null) {
        return;
      }
      if (other.ItemId.Length != 0) {
        ItemId = other.ItemId;
      }
      if (other.ProCode.Length != 0) {
        ProCode = other.ProCode;
      }
      if (other.Agency != 0) {
        Agency = other.Agency;
      }
      if (other.AgencyType.Length != 0) {
        AgencyType = other.AgencyType;
      }
      if (other.BdgYear != 0) {
        BdgYear = other.BdgYear;
      }
      if (other.AdmdivCode.Length != 0) {
        AdmdivCode = other.AdmdivCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ItemId = input.ReadString();
            break;
          }
          case 18: {
            ProCode = input.ReadString();
            break;
          }
          case 24: {
            Agency = input.ReadInt32();
            break;
          }
          case 34: {
            AgencyType = input.ReadString();
            break;
          }
          case 40: {
            BdgYear = input.ReadInt32();
            break;
          }
          case 50: {
            AdmdivCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code