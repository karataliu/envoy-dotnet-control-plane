// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/matcher/v3/metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Matcher.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/matcher/v3/metadata.proto</summary>
  public static partial class MetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/matcher/v3/metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRlbnZveS90eXBlL21hdGNoZXIvdjMvbWV0YWRhdGEucHJvdG8SFWVudm95",
            "LnR5cGUubWF0Y2hlci52MxohZW52b3kvdHlwZS9tYXRjaGVyL3YzL3ZhbHVl",
            "LnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9h",
            "bm5vdGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0",
            "ZS5wcm90byLdAgoPTWV0YWRhdGFNYXRjaGVyEhcKBmZpbHRlchgBIAEoCUIH",
            "+kIEcgIQARJKCgRwYXRoGAIgAygLMjIuZW52b3kudHlwZS5tYXRjaGVyLnYz",
            "Lk1ldGFkYXRhTWF0Y2hlci5QYXRoU2VnbWVudEII+kIFkgECCAESPAoFdmFs",
            "dWUYAyABKAsyIy5lbnZveS50eXBlLm1hdGNoZXIudjMuVmFsdWVNYXRjaGVy",
            "Qgj6QgWKAQIQARIOCgZpbnZlcnQYBCABKAgabAoLUGF0aFNlZ21lbnQSFgoD",
            "a2V5GAEgASgJQgf6QgRyAhABSAA6NZrFiB4wCi5lbnZveS50eXBlLm1hdGNo",
            "ZXIuTWV0YWRhdGFNYXRjaGVyLlBhdGhTZWdtZW50Qg4KB3NlZ21lbnQSA/hC",
            "ATopmsWIHiQKImVudm95LnR5cGUubWF0Y2hlci5NZXRhZGF0YU1hdGNoZXJC",
            "hgEKI2lvLmVudm95cHJveHkuZW52b3kudHlwZS5tYXRjaGVyLnYzQg1NZXRh",
            "ZGF0YVByb3RvUAFaRmdpdGh1Yi5jb20vZW52b3lwcm94eS9nby1jb250cm9s",
            "LXBsYW5lL2Vudm95L3R5cGUvbWF0Y2hlci92MzttYXRjaGVydjO6gMjRBgIQ",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Type.Matcher.V3.ValueReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.V3.MetadataMatcher), global::Envoy.Type.Matcher.V3.MetadataMatcher.Parser, new[]{ "Filter", "Path", "Value", "Invert" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment), global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment.Parser, new[]{ "Key" }, new[]{ "Segment" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-major-version: MetadataMatcher should use StructMatcher]
  /// </summary>
  public sealed partial class MetadataMatcher : pb::IMessage<MetadataMatcher>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MetadataMatcher> _parser = new pb::MessageParser<MetadataMatcher>(() => new MetadataMatcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MetadataMatcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.V3.MetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataMatcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataMatcher(MetadataMatcher other) : this() {
      filter_ = other.filter_;
      path_ = other.path_.Clone();
      value_ = other.value_ != null ? other.value_.Clone() : null;
      invert_ = other.invert_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetadataMatcher Clone() {
      return new MetadataMatcher(this);
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 1;
    private string filter_ = "";
    /// <summary>
    /// The filter name to retrieve the Struct from the Metadata.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment> _repeated_path_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment> path_ = new pbc::RepeatedField<global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment>();
    /// <summary>
    /// The path to retrieve the Value from the Struct.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Type.Matcher.V3.MetadataMatcher.Types.PathSegment> Path {
      get { return path_; }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private global::Envoy.Type.Matcher.V3.ValueMatcher value_;
    /// <summary>
    /// The MetadataMatcher is matched if the value retrieved by path is matched to this value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.Matcher.V3.ValueMatcher Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "invert" field.</summary>
    public const int InvertFieldNumber = 4;
    private bool invert_;
    /// <summary>
    /// If true, the match result will be inverted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Invert {
      get { return invert_; }
      set {
        invert_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MetadataMatcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MetadataMatcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Filter != other.Filter) return false;
      if(!path_.Equals(other.path_)) return false;
      if (!object.Equals(Value, other.Value)) return false;
      if (Invert != other.Invert) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      hash ^= path_.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      if (Invert != false) hash ^= Invert.GetHashCode();
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
      if (Filter.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filter);
      }
      path_.WriteTo(output, _repeated_path_codec);
      if (value_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Value);
      }
      if (Invert != false) {
        output.WriteRawTag(32);
        output.WriteBool(Invert);
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
      if (Filter.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Filter);
      }
      path_.WriteTo(ref output, _repeated_path_codec);
      if (value_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Value);
      }
      if (Invert != false) {
        output.WriteRawTag(32);
        output.WriteBool(Invert);
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
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      size += path_.CalculateSize(_repeated_path_codec);
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (Invert != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MetadataMatcher other) {
      if (other == null) {
        return;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      path_.Add(other.path_);
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Envoy.Type.Matcher.V3.ValueMatcher();
        }
        Value.MergeFrom(other.Value);
      }
      if (other.Invert != false) {
        Invert = other.Invert;
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
            Filter = input.ReadString();
            break;
          }
          case 18: {
            path_.AddEntriesFrom(input, _repeated_path_codec);
            break;
          }
          case 26: {
            if (value_ == null) {
              Value = new global::Envoy.Type.Matcher.V3.ValueMatcher();
            }
            input.ReadMessage(Value);
            break;
          }
          case 32: {
            Invert = input.ReadBool();
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
            Filter = input.ReadString();
            break;
          }
          case 18: {
            path_.AddEntriesFrom(ref input, _repeated_path_codec);
            break;
          }
          case 26: {
            if (value_ == null) {
              Value = new global::Envoy.Type.Matcher.V3.ValueMatcher();
            }
            input.ReadMessage(Value);
            break;
          }
          case 32: {
            Invert = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MetadataMatcher message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Specifies the segment in a path to retrieve value from Metadata.
      /// Note: Currently it's not supported to retrieve a value from a list in Metadata. This means that
      /// if the segment key refers to a list, it has to be the last segment in a path.
      /// </summary>
      public sealed partial class PathSegment : pb::IMessage<PathSegment>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PathSegment> _parser = new pb::MessageParser<PathSegment>(() => new PathSegment());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PathSegment> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Type.Matcher.V3.MetadataMatcher.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment(PathSegment other) : this() {
          switch (other.SegmentCase) {
            case SegmentOneofCase.Key:
              Key = other.Key;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment Clone() {
          return new PathSegment(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        /// <summary>
        /// If specified, use the key to retrieve the value in a Struct.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Key {
          get { return HasKey ? (string) segment_ : ""; }
          set {
            segment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            segmentCase_ = SegmentOneofCase.Key;
          }
        }
        /// <summary>Gets whether the "key" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasKey {
          get { return segmentCase_ == SegmentOneofCase.Key; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "key" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearKey() {
          if (HasKey) {
            ClearSegment();
          }
        }

        private object segment_;
        /// <summary>Enum of possible cases for the "segment" oneof.</summary>
        public enum SegmentOneofCase {
          None = 0,
          Key = 1,
        }
        private SegmentOneofCase segmentCase_ = SegmentOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SegmentOneofCase SegmentCase {
          get { return segmentCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearSegment() {
          segmentCase_ = SegmentOneofCase.None;
          segment_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PathSegment);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PathSegment other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (SegmentCase != other.SegmentCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasKey) hash ^= Key.GetHashCode();
          hash ^= (int) segmentCase_;
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
          if (HasKey) {
            output.WriteRawTag(10);
            output.WriteString(Key);
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
          if (HasKey) {
            output.WriteRawTag(10);
            output.WriteString(Key);
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
          if (HasKey) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PathSegment other) {
          if (other == null) {
            return;
          }
          switch (other.SegmentCase) {
            case SegmentOneofCase.Key:
              Key = other.Key;
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
                Key = input.ReadString();
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
                Key = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
