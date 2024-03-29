// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: udpa/annotations/security.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Udpa.Annotations {

  /// <summary>Holder for reflection information generated from udpa/annotations/security.proto</summary>
  public static partial class SecurityReflection {

    #region Descriptor
    /// <summary>File descriptor for udpa/annotations/security.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SecurityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch91ZHBhL2Fubm90YXRpb25zL3NlY3VyaXR5LnByb3RvEhB1ZHBhLmFubm90",
            "YXRpb25zGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxogZ29vZ2xl",
            "L3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8ibwoXRmllbGRTZWN1cml0eUFu",
            "bm90YXRpb24SKgoiY29uZmlndXJlX2Zvcl91bnRydXN0ZWRfZG93bnN0cmVh",
            "bRgBIAEoCBIoCiBjb25maWd1cmVfZm9yX3VudHJ1c3RlZF91cHN0cmVhbRgC",
            "IAEoCDpdCghzZWN1cml0eRIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlv",
            "bnMYsfKmBSABKAsyKS51ZHBhLmFubm90YXRpb25zLkZpZWxkU2VjdXJpdHlB",
            "bm5vdGF0aW9uQixaImdpdGh1Yi5jb20vY25jZi94ZHMvZ28vYW5ub3RhdGlv",
            "bnO6gMjRBgIIAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { SecurityExtensions.Security }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Udpa.Annotations.FieldSecurityAnnotation), global::Udpa.Annotations.FieldSecurityAnnotation.Parser, new[]{ "ConfigureForUntrustedDownstream", "ConfigureForUntrustedUpstream" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of udpa/annotations/security.proto</summary>
  public static partial class SecurityExtensions {
    /// <summary>
    /// Magic number is the 28 most significant bits in the sha256sum of
    /// "udpa.annotations.security".
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Udpa.Annotations.FieldSecurityAnnotation> Security =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Udpa.Annotations.FieldSecurityAnnotation>(11122993, pb::FieldCodec.ForMessage(88983946, global::Udpa.Annotations.FieldSecurityAnnotation.Parser));
  }

  #region Messages
  /// <summary>
  /// These annotations indicate metadata for the purpose of understanding the
  /// security significance of fields.
  /// </summary>
  public sealed partial class FieldSecurityAnnotation : pb::IMessage<FieldSecurityAnnotation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FieldSecurityAnnotation> _parser = new pb::MessageParser<FieldSecurityAnnotation>(() => new FieldSecurityAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FieldSecurityAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Udpa.Annotations.SecurityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldSecurityAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldSecurityAnnotation(FieldSecurityAnnotation other) : this() {
      configureForUntrustedDownstream_ = other.configureForUntrustedDownstream_;
      configureForUntrustedUpstream_ = other.configureForUntrustedUpstream_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldSecurityAnnotation Clone() {
      return new FieldSecurityAnnotation(this);
    }

    /// <summary>Field number for the "configure_for_untrusted_downstream" field.</summary>
    public const int ConfigureForUntrustedDownstreamFieldNumber = 1;
    private bool configureForUntrustedDownstream_;
    /// <summary>
    /// Field should be set in the presence of untrusted downstreams.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ConfigureForUntrustedDownstream {
      get { return configureForUntrustedDownstream_; }
      set {
        configureForUntrustedDownstream_ = value;
      }
    }

    /// <summary>Field number for the "configure_for_untrusted_upstream" field.</summary>
    public const int ConfigureForUntrustedUpstreamFieldNumber = 2;
    private bool configureForUntrustedUpstream_;
    /// <summary>
    /// Field should be set in the presence of untrusted upstreams.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ConfigureForUntrustedUpstream {
      get { return configureForUntrustedUpstream_; }
      set {
        configureForUntrustedUpstream_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FieldSecurityAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FieldSecurityAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigureForUntrustedDownstream != other.ConfigureForUntrustedDownstream) return false;
      if (ConfigureForUntrustedUpstream != other.ConfigureForUntrustedUpstream) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigureForUntrustedDownstream != false) hash ^= ConfigureForUntrustedDownstream.GetHashCode();
      if (ConfigureForUntrustedUpstream != false) hash ^= ConfigureForUntrustedUpstream.GetHashCode();
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
      if (ConfigureForUntrustedDownstream != false) {
        output.WriteRawTag(8);
        output.WriteBool(ConfigureForUntrustedDownstream);
      }
      if (ConfigureForUntrustedUpstream != false) {
        output.WriteRawTag(16);
        output.WriteBool(ConfigureForUntrustedUpstream);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ConfigureForUntrustedDownstream != false) {
        output.WriteRawTag(8);
        output.WriteBool(ConfigureForUntrustedDownstream);
      }
      if (ConfigureForUntrustedUpstream != false) {
        output.WriteRawTag(16);
        output.WriteBool(ConfigureForUntrustedUpstream);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ConfigureForUntrustedDownstream != false) {
        size += 1 + 1;
      }
      if (ConfigureForUntrustedUpstream != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FieldSecurityAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.ConfigureForUntrustedDownstream != false) {
        ConfigureForUntrustedDownstream = other.ConfigureForUntrustedDownstream;
      }
      if (other.ConfigureForUntrustedUpstream != false) {
        ConfigureForUntrustedUpstream = other.ConfigureForUntrustedUpstream;
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
          case 8: {
            ConfigureForUntrustedDownstream = input.ReadBool();
            break;
          }
          case 16: {
            ConfigureForUntrustedUpstream = input.ReadBool();
            break;
          }
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
          case 8: {
            ConfigureForUntrustedDownstream = input.ReadBool();
            break;
          }
          case 16: {
            ConfigureForUntrustedUpstream = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
