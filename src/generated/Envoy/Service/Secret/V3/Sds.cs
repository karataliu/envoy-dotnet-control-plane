// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/secret/v3/sds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Secret.V3 {

  /// <summary>Holder for reflection information generated from envoy/service/secret/v3/sds.proto</summary>
  public static partial class SdsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/secret/v3/sds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFlbnZveS9zZXJ2aWNlL3NlY3JldC92My9zZHMucHJvdG8SF2Vudm95LnNl",
            "cnZpY2Uuc2VjcmV0LnYzGiplbnZveS9zZXJ2aWNlL2Rpc2NvdmVyeS92My9k",
            "aXNjb3ZlcnkucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8a",
            "IGVudm95L2Fubm90YXRpb25zL3Jlc291cmNlLnByb3RvGh11ZHBhL2Fubm90",
            "YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9hbm5vdGF0aW9ucy92ZXJzaW9u",
            "aW5nLnByb3RvIjYKCFNkc0R1bW15OiqaxYgeJQojZW52b3kuc2VydmljZS5k",
            "aXNjb3ZlcnkudjIuU2RzRHVtbXky2QMKFlNlY3JldERpc2NvdmVyeVNlcnZp",
            "Y2USewoMRGVsdGFTZWNyZXRzEjEuZW52b3kuc2VydmljZS5kaXNjb3Zlcnku",
            "djMuRGVsdGFEaXNjb3ZlcnlSZXF1ZXN0GjIuZW52b3kuc2VydmljZS5kaXNj",
            "b3ZlcnkudjMuRGVsdGFEaXNjb3ZlcnlSZXNwb25zZSIAKAEwARJyCg1TdHJl",
            "YW1TZWNyZXRzEiwuZW52b3kuc2VydmljZS5kaXNjb3ZlcnkudjMuRGlzY292",
            "ZXJ5UmVxdWVzdBotLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYzLkRpc2Nv",
            "dmVyeVJlc3BvbnNlIgAoATABEpMBCgxGZXRjaFNlY3JldHMSLC5lbnZveS5z",
            "ZXJ2aWNlLmRpc2NvdmVyeS52My5EaXNjb3ZlcnlSZXF1ZXN0Gi0uZW52b3ku",
            "c2VydmljZS5kaXNjb3ZlcnkudjMuRGlzY292ZXJ5UmVzcG9uc2UiJoLT5JMC",
            "FyIVL3YzL2Rpc2NvdmVyeTpzZWNyZXRzgtPkkwIDOgEqGjiKpJbzBzIKMGVu",
            "dm95LmV4dGVuc2lvbnMudHJhbnNwb3J0X3NvY2tldHMudGxzLnYzLlNlY3Jl",
            "dEKEAQolaW8uZW52b3lwcm94eS5lbnZveS5zZXJ2aWNlLnNlY3JldC52M0II",
            "U2RzUHJvdG9QAVpHZ2l0aHViLmNvbS9lbnZveXByb3h5L2dvLWNvbnRyb2wt",
            "cGxhbmUvZW52b3kvc2VydmljZS9zZWNyZXQvdjM7c2VjcmV0djO6gMjRBgIQ",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Service.Discovery.V3.DiscoveryReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Envoy.Annotations.ResourceReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Secret.V3.SdsDummy), global::Envoy.Service.Secret.V3.SdsDummy.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#not-implemented-hide:] Not configuration. Workaround c++ protobuf issue with importing
  /// services: https://github.com/google/protobuf/issues/4221
  /// </summary>
  public sealed partial class SdsDummy : pb::IMessage<SdsDummy>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SdsDummy> _parser = new pb::MessageParser<SdsDummy>(() => new SdsDummy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SdsDummy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Secret.V3.SdsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SdsDummy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SdsDummy(SdsDummy other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SdsDummy Clone() {
      return new SdsDummy(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SdsDummy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SdsDummy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SdsDummy other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
