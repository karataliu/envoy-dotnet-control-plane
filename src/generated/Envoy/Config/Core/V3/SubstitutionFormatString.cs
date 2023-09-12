// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/core/v3/substitution_format_string.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Core.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/core/v3/substitution_format_string.proto</summary>
  public static partial class SubstitutionFormatStringReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/core/v3/substitution_format_string.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubstitutionFormatStringReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVlbnZveS9jb25maWcvY29yZS92My9zdWJzdGl0dXRpb25fZm9ybWF0X3N0",
            "cmluZy5wcm90bxIUZW52b3kuY29uZmlnLmNvcmUudjMaH2Vudm95L2NvbmZp",
            "Zy9jb3JlL3YzL2Jhc2UucHJvdG8aJGVudm95L2NvbmZpZy9jb3JlL3YzL2V4",
            "dGVuc2lvbi5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxoj",
            "ZW52b3kvYW5ub3RhdGlvbnMvZGVwcmVjYXRpb24ucHJvdG8aHXVkcGEvYW5u",
            "b3RhdGlvbnMvc3RhdHVzLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90",
            "byIsChFKc29uRm9ybWF0T3B0aW9ucxIXCg9zb3J0X3Byb3BlcnRpZXMYASAB",
            "KAgiiwMKGFN1YnN0aXR1dGlvbkZvcm1hdFN0cmluZxIiCgt0ZXh0X2Zvcm1h",
            "dBgBIAEoCUILGAGSx4bYBAMzLjBIABI4Cgtqc29uX2Zvcm1hdBgCIAEoCzIX",
            "Lmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3RCCPpCBYoBAhABSAASPgoSdGV4dF9m",
            "b3JtYXRfc291cmNlGAUgASgLMiAuZW52b3kuY29uZmlnLmNvcmUudjMuRGF0",
            "YVNvdXJjZUgAEhkKEW9taXRfZW1wdHlfdmFsdWVzGAMgASgIEiEKDGNvbnRl",
            "bnRfdHlwZRgEIAEoCUIL+kIIcgbAAQLIAQASPgoKZm9ybWF0dGVycxgGIAMo",
            "CzIqLmVudm95LmNvbmZpZy5jb3JlLnYzLlR5cGVkRXh0ZW5zaW9uQ29uZmln",
            "EkQKE2pzb25fZm9ybWF0X29wdGlvbnMYByABKAsyJy5lbnZveS5jb25maWcu",
            "Y29yZS52My5Kc29uRm9ybWF0T3B0aW9uc0INCgZmb3JtYXQSA/hCAUKRAQoi",
            "aW8uZW52b3lwcm94eS5lbnZveS5jb25maWcuY29yZS52M0IdU3Vic3RpdHV0",
            "aW9uRm9ybWF0U3RyaW5nUHJvdG9QAVpCZ2l0aHViLmNvbS9lbnZveXByb3h5",
            "L2dvLWNvbnRyb2wtcGxhbmUvZW52b3kvY29uZmlnL2NvcmUvdjM7Y29yZXYz",
            "uoDI0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.BaseReflection.Descriptor, global::Envoy.Config.Core.V3.ExtensionReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Envoy.Annotations.DeprecationReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Core.V3.JsonFormatOptions), global::Envoy.Config.Core.V3.JsonFormatOptions.Parser, new[]{ "SortProperties" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Core.V3.SubstitutionFormatString), global::Envoy.Config.Core.V3.SubstitutionFormatString.Parser, new[]{ "TextFormat", "JsonFormat", "TextFormatSource", "OmitEmptyValues", "ContentType", "Formatters", "JsonFormatOptions" }, new[]{ "Format" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Optional configuration options to be used with json_format.
  /// </summary>
  public sealed partial class JsonFormatOptions : pb::IMessage<JsonFormatOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JsonFormatOptions> _parser = new pb::MessageParser<JsonFormatOptions>(() => new JsonFormatOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JsonFormatOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Core.V3.SubstitutionFormatStringReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JsonFormatOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JsonFormatOptions(JsonFormatOptions other) : this() {
      sortProperties_ = other.sortProperties_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JsonFormatOptions Clone() {
      return new JsonFormatOptions(this);
    }

    /// <summary>Field number for the "sort_properties" field.</summary>
    public const int SortPropertiesFieldNumber = 1;
    private bool sortProperties_;
    /// <summary>
    /// The output JSON string properties will be sorted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SortProperties {
      get { return sortProperties_; }
      set {
        sortProperties_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JsonFormatOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JsonFormatOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SortProperties != other.SortProperties) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SortProperties != false) hash ^= SortProperties.GetHashCode();
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
      if (SortProperties != false) {
        output.WriteRawTag(8);
        output.WriteBool(SortProperties);
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
      if (SortProperties != false) {
        output.WriteRawTag(8);
        output.WriteBool(SortProperties);
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
      if (SortProperties != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JsonFormatOptions other) {
      if (other == null) {
        return;
      }
      if (other.SortProperties != false) {
        SortProperties = other.SortProperties;
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
            SortProperties = input.ReadBool();
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
            SortProperties = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Configuration to use multiple :ref:`command operators &lt;config_access_log_command_operators>`
  /// to generate a new string in either plain text or JSON format.
  /// [#next-free-field: 8]
  /// </summary>
  public sealed partial class SubstitutionFormatString : pb::IMessage<SubstitutionFormatString>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubstitutionFormatString> _parser = new pb::MessageParser<SubstitutionFormatString>(() => new SubstitutionFormatString());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SubstitutionFormatString> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Core.V3.SubstitutionFormatStringReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubstitutionFormatString() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubstitutionFormatString(SubstitutionFormatString other) : this() {
      omitEmptyValues_ = other.omitEmptyValues_;
      contentType_ = other.contentType_;
      formatters_ = other.formatters_.Clone();
      jsonFormatOptions_ = other.jsonFormatOptions_ != null ? other.jsonFormatOptions_.Clone() : null;
      switch (other.FormatCase) {
        case FormatOneofCase.TextFormat:
          TextFormat = other.TextFormat;
          break;
        case FormatOneofCase.JsonFormat:
          JsonFormat = other.JsonFormat.Clone();
          break;
        case FormatOneofCase.TextFormatSource:
          TextFormatSource = other.TextFormatSource.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubstitutionFormatString Clone() {
      return new SubstitutionFormatString(this);
    }

    /// <summary>Field number for the "text_format" field.</summary>
    public const int TextFormatFieldNumber = 1;
    /// <summary>
    /// Specify a format with command operators to form a text string.
    /// Its details is described in :ref:`format string&lt;config_access_log_format_strings>`.
    ///
    /// For example, setting ``text_format`` like below,
    ///
    /// .. validated-code-block:: yaml
    ///   :type-name: envoy.config.core.v3.SubstitutionFormatString
    ///
    ///   text_format: "%LOCAL_REPLY_BODY%:%RESPONSE_CODE%:path=%REQ(:path)%\n"
    ///
    /// generates plain text similar to:
    ///
    /// .. code-block:: text
    ///
    ///   upstream connect error:503:path=/foo
    ///
    /// Deprecated in favor of :ref:`text_format_source &lt;envoy_v3_api_field_config.core.v3.SubstitutionFormatString.text_format_source>`. To migrate text format strings, use the :ref:`inline_string &lt;envoy_v3_api_field_config.core.v3.DataSource.inline_string>` field.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TextFormat {
      get { return HasTextFormat ? (string) format_ : ""; }
      set {
        format_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        formatCase_ = FormatOneofCase.TextFormat;
      }
    }
    /// <summary>Gets whether the "text_format" field is set</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTextFormat {
      get { return formatCase_ == FormatOneofCase.TextFormat; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "text_format" </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTextFormat() {
      if (HasTextFormat) {
        ClearFormat();
      }
    }

    /// <summary>Field number for the "json_format" field.</summary>
    public const int JsonFormatFieldNumber = 2;
    /// <summary>
    /// Specify a format with command operators to form a JSON string.
    /// Its details is described in :ref:`format dictionary&lt;config_access_log_format_dictionaries>`.
    /// Values are rendered as strings, numbers, or boolean values as appropriate.
    /// Nested JSON objects may be produced by some command operators (e.g. FILTER_STATE or DYNAMIC_METADATA).
    /// See the documentation for a specific command operator for details.
    ///
    /// .. validated-code-block:: yaml
    ///   :type-name: envoy.config.core.v3.SubstitutionFormatString
    ///
    ///   json_format:
    ///     status: "%RESPONSE_CODE%"
    ///     message: "%LOCAL_REPLY_BODY%"
    ///
    /// The following JSON object would be created:
    ///
    /// .. code-block:: json
    ///
    ///  {
    ///    "status": 500,
    ///    "message": "My error message"
    ///  }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct JsonFormat {
      get { return formatCase_ == FormatOneofCase.JsonFormat ? (global::Google.Protobuf.WellKnownTypes.Struct) format_ : null; }
      set {
        format_ = value;
        formatCase_ = value == null ? FormatOneofCase.None : FormatOneofCase.JsonFormat;
      }
    }

    /// <summary>Field number for the "text_format_source" field.</summary>
    public const int TextFormatSourceFieldNumber = 5;
    /// <summary>
    /// Specify a format with command operators to form a text string.
    /// Its details is described in :ref:`format string&lt;config_access_log_format_strings>`.
    ///
    /// For example, setting ``text_format`` like below,
    ///
    /// .. validated-code-block:: yaml
    ///   :type-name: envoy.config.core.v3.SubstitutionFormatString
    ///
    ///   text_format_source:
    ///     inline_string: "%LOCAL_REPLY_BODY%:%RESPONSE_CODE%:path=%REQ(:path)%\n"
    ///
    /// generates plain text similar to:
    ///
    /// .. code-block:: text
    ///
    ///   upstream connect error:503:path=/foo
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.DataSource TextFormatSource {
      get { return formatCase_ == FormatOneofCase.TextFormatSource ? (global::Envoy.Config.Core.V3.DataSource) format_ : null; }
      set {
        format_ = value;
        formatCase_ = value == null ? FormatOneofCase.None : FormatOneofCase.TextFormatSource;
      }
    }

    /// <summary>Field number for the "omit_empty_values" field.</summary>
    public const int OmitEmptyValuesFieldNumber = 3;
    private bool omitEmptyValues_;
    /// <summary>
    /// If set to true, when command operators are evaluated to null,
    ///
    /// * for ``text_format``, the output of the empty operator is changed from ``-`` to an
    ///   empty string, so that empty values are omitted entirely.
    /// * for ``json_format`` the keys with null values are omitted in the output structure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OmitEmptyValues {
      get { return omitEmptyValues_; }
      set {
        omitEmptyValues_ = value;
      }
    }

    /// <summary>Field number for the "content_type" field.</summary>
    public const int ContentTypeFieldNumber = 4;
    private string contentType_ = "";
    /// <summary>
    /// Specify a ``content_type`` field.
    /// If this field is not set then ``text/plain`` is used for ``text_format`` and
    /// ``application/json`` is used for ``json_format``.
    ///
    /// .. validated-code-block:: yaml
    ///   :type-name: envoy.config.core.v3.SubstitutionFormatString
    ///
    ///   content_type: "text/html; charset=UTF-8"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "formatters" field.</summary>
    public const int FormattersFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Envoy.Config.Core.V3.TypedExtensionConfig> _repeated_formatters_codec
        = pb::FieldCodec.ForMessage(50, global::Envoy.Config.Core.V3.TypedExtensionConfig.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Core.V3.TypedExtensionConfig> formatters_ = new pbc::RepeatedField<global::Envoy.Config.Core.V3.TypedExtensionConfig>();
    /// <summary>
    /// Specifies a collection of Formatter plugins that can be called from the access log configuration.
    /// See the formatters extensions documentation for details.
    /// [#extension-category: envoy.formatter]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Core.V3.TypedExtensionConfig> Formatters {
      get { return formatters_; }
    }

    /// <summary>Field number for the "json_format_options" field.</summary>
    public const int JsonFormatOptionsFieldNumber = 7;
    private global::Envoy.Config.Core.V3.JsonFormatOptions jsonFormatOptions_;
    /// <summary>
    /// If json_format is used, the options will be applied to the output JSON string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.JsonFormatOptions JsonFormatOptions {
      get { return jsonFormatOptions_; }
      set {
        jsonFormatOptions_ = value;
      }
    }

    private object format_;
    /// <summary>Enum of possible cases for the "format" oneof.</summary>
    public enum FormatOneofCase {
      None = 0,
      TextFormat = 1,
      JsonFormat = 2,
      TextFormatSource = 5,
    }
    private FormatOneofCase formatCase_ = FormatOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FormatOneofCase FormatCase {
      get { return formatCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFormat() {
      formatCase_ = FormatOneofCase.None;
      format_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SubstitutionFormatString);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SubstitutionFormatString other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TextFormat != other.TextFormat) return false;
      if (!object.Equals(JsonFormat, other.JsonFormat)) return false;
      if (!object.Equals(TextFormatSource, other.TextFormatSource)) return false;
      if (OmitEmptyValues != other.OmitEmptyValues) return false;
      if (ContentType != other.ContentType) return false;
      if(!formatters_.Equals(other.formatters_)) return false;
      if (!object.Equals(JsonFormatOptions, other.JsonFormatOptions)) return false;
      if (FormatCase != other.FormatCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTextFormat) hash ^= TextFormat.GetHashCode();
      if (formatCase_ == FormatOneofCase.JsonFormat) hash ^= JsonFormat.GetHashCode();
      if (formatCase_ == FormatOneofCase.TextFormatSource) hash ^= TextFormatSource.GetHashCode();
      if (OmitEmptyValues != false) hash ^= OmitEmptyValues.GetHashCode();
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      hash ^= formatters_.GetHashCode();
      if (jsonFormatOptions_ != null) hash ^= JsonFormatOptions.GetHashCode();
      hash ^= (int) formatCase_;
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
      if (HasTextFormat) {
        output.WriteRawTag(10);
        output.WriteString(TextFormat);
      }
      if (formatCase_ == FormatOneofCase.JsonFormat) {
        output.WriteRawTag(18);
        output.WriteMessage(JsonFormat);
      }
      if (OmitEmptyValues != false) {
        output.WriteRawTag(24);
        output.WriteBool(OmitEmptyValues);
      }
      if (ContentType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ContentType);
      }
      if (formatCase_ == FormatOneofCase.TextFormatSource) {
        output.WriteRawTag(42);
        output.WriteMessage(TextFormatSource);
      }
      formatters_.WriteTo(output, _repeated_formatters_codec);
      if (jsonFormatOptions_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(JsonFormatOptions);
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
      if (HasTextFormat) {
        output.WriteRawTag(10);
        output.WriteString(TextFormat);
      }
      if (formatCase_ == FormatOneofCase.JsonFormat) {
        output.WriteRawTag(18);
        output.WriteMessage(JsonFormat);
      }
      if (OmitEmptyValues != false) {
        output.WriteRawTag(24);
        output.WriteBool(OmitEmptyValues);
      }
      if (ContentType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ContentType);
      }
      if (formatCase_ == FormatOneofCase.TextFormatSource) {
        output.WriteRawTag(42);
        output.WriteMessage(TextFormatSource);
      }
      formatters_.WriteTo(ref output, _repeated_formatters_codec);
      if (jsonFormatOptions_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(JsonFormatOptions);
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
      if (HasTextFormat) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TextFormat);
      }
      if (formatCase_ == FormatOneofCase.JsonFormat) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JsonFormat);
      }
      if (formatCase_ == FormatOneofCase.TextFormatSource) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextFormatSource);
      }
      if (OmitEmptyValues != false) {
        size += 1 + 1;
      }
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      size += formatters_.CalculateSize(_repeated_formatters_codec);
      if (jsonFormatOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JsonFormatOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SubstitutionFormatString other) {
      if (other == null) {
        return;
      }
      if (other.OmitEmptyValues != false) {
        OmitEmptyValues = other.OmitEmptyValues;
      }
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      formatters_.Add(other.formatters_);
      if (other.jsonFormatOptions_ != null) {
        if (jsonFormatOptions_ == null) {
          JsonFormatOptions = new global::Envoy.Config.Core.V3.JsonFormatOptions();
        }
        JsonFormatOptions.MergeFrom(other.JsonFormatOptions);
      }
      switch (other.FormatCase) {
        case FormatOneofCase.TextFormat:
          TextFormat = other.TextFormat;
          break;
        case FormatOneofCase.JsonFormat:
          if (JsonFormat == null) {
            JsonFormat = new global::Google.Protobuf.WellKnownTypes.Struct();
          }
          JsonFormat.MergeFrom(other.JsonFormat);
          break;
        case FormatOneofCase.TextFormatSource:
          if (TextFormatSource == null) {
            TextFormatSource = new global::Envoy.Config.Core.V3.DataSource();
          }
          TextFormatSource.MergeFrom(other.TextFormatSource);
          break;
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
            TextFormat = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (formatCase_ == FormatOneofCase.JsonFormat) {
              subBuilder.MergeFrom(JsonFormat);
            }
            input.ReadMessage(subBuilder);
            JsonFormat = subBuilder;
            break;
          }
          case 24: {
            OmitEmptyValues = input.ReadBool();
            break;
          }
          case 34: {
            ContentType = input.ReadString();
            break;
          }
          case 42: {
            global::Envoy.Config.Core.V3.DataSource subBuilder = new global::Envoy.Config.Core.V3.DataSource();
            if (formatCase_ == FormatOneofCase.TextFormatSource) {
              subBuilder.MergeFrom(TextFormatSource);
            }
            input.ReadMessage(subBuilder);
            TextFormatSource = subBuilder;
            break;
          }
          case 50: {
            formatters_.AddEntriesFrom(input, _repeated_formatters_codec);
            break;
          }
          case 58: {
            if (jsonFormatOptions_ == null) {
              JsonFormatOptions = new global::Envoy.Config.Core.V3.JsonFormatOptions();
            }
            input.ReadMessage(JsonFormatOptions);
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
            TextFormat = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (formatCase_ == FormatOneofCase.JsonFormat) {
              subBuilder.MergeFrom(JsonFormat);
            }
            input.ReadMessage(subBuilder);
            JsonFormat = subBuilder;
            break;
          }
          case 24: {
            OmitEmptyValues = input.ReadBool();
            break;
          }
          case 34: {
            ContentType = input.ReadString();
            break;
          }
          case 42: {
            global::Envoy.Config.Core.V3.DataSource subBuilder = new global::Envoy.Config.Core.V3.DataSource();
            if (formatCase_ == FormatOneofCase.TextFormatSource) {
              subBuilder.MergeFrom(TextFormatSource);
            }
            input.ReadMessage(subBuilder);
            TextFormatSource = subBuilder;
            break;
          }
          case 50: {
            formatters_.AddEntriesFrom(ref input, _repeated_formatters_codec);
            break;
          }
          case 58: {
            if (jsonFormatOptions_ == null) {
              JsonFormatOptions = new global::Envoy.Config.Core.V3.JsonFormatOptions();
            }
            input.ReadMessage(JsonFormatOptions);
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
