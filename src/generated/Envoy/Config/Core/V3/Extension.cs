// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/core/v3/extension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Core.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/core/v3/extension.proto</summary>
  public static partial class ExtensionReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/core/v3/extension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRlbnZveS9jb25maWcvY29yZS92My9leHRlbnNpb24ucHJvdG8SFGVudm95",
            "LmNvbmZpZy5jb3JlLnYzGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvGh11",
            "ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxoXdmFsaWRhdGUvdmFsaWRh",
            "dGUucHJvdG8iYwoUVHlwZWRFeHRlbnNpb25Db25maWcSFQoEbmFtZRgBIAEo",
            "CUIH+kIEcgIQARI0Cgx0eXBlZF9jb25maWcYAiABKAsyFC5nb29nbGUucHJv",
            "dG9idWYuQW55Qgj6QgWiAQIIAUKCAQoiaW8uZW52b3lwcm94eS5lbnZveS5j",
            "b25maWcuY29yZS52M0IORXh0ZW5zaW9uUHJvdG9QAVpCZ2l0aHViLmNvbS9l",
            "bnZveXByb3h5L2dvLWNvbnRyb2wtcGxhbmUvZW52b3kvY29uZmlnL2NvcmUv",
            "djM7Y29yZXYzuoDI0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Core.V3.TypedExtensionConfig), global::Envoy.Config.Core.V3.TypedExtensionConfig.Parser, new[]{ "Name", "TypedConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message type for extension configuration.
  /// [#next-major-version: revisit all existing typed_config that doesn't use this wrapper.].
  /// </summary>
  public sealed partial class TypedExtensionConfig : pb::IMessage<TypedExtensionConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TypedExtensionConfig> _parser = new pb::MessageParser<TypedExtensionConfig>(() => new TypedExtensionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TypedExtensionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Core.V3.ExtensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedExtensionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedExtensionConfig(TypedExtensionConfig other) : this() {
      name_ = other.name_;
      typedConfig_ = other.typedConfig_ != null ? other.typedConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedExtensionConfig Clone() {
      return new TypedExtensionConfig(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of an extension. This is not used to select the extension, instead
    /// it serves the role of an opaque identifier.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "typed_config" field.</summary>
    public const int TypedConfigFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any typedConfig_;
    /// <summary>
    /// The typed config for the extension. The type URL will be used to identify
    /// the extension. In the case that the type URL is *xds.type.v3.TypedStruct*
    /// (or, for historical reasons, *udpa.type.v1.TypedStruct*), the inner type
    /// URL of *TypedStruct* will be utilized. See the
    /// :ref:`extension configuration overview
    /// &lt;config_overview_extension_configuration>` for further details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any TypedConfig {
      get { return typedConfig_; }
      set {
        typedConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TypedExtensionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TypedExtensionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(TypedConfig, other.TypedConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (typedConfig_ != null) hash ^= TypedConfig.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (typedConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TypedConfig);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (typedConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TypedConfig);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (typedConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypedConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TypedExtensionConfig other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.typedConfig_ != null) {
        if (typedConfig_ == null) {
          TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        TypedConfig.MergeFrom(other.TypedConfig);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (typedConfig_ == null) {
              TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(TypedConfig);
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (typedConfig_ == null) {
              TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(TypedConfig);
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