// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/matcher/v3/number.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Matcher.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/matcher/v3/number.proto</summary>
  public static partial class NumberReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/matcher/v3/number.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NumberReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJlbnZveS90eXBlL21hdGNoZXIvdjMvbnVtYmVyLnByb3RvEhVlbnZveS50",
            "eXBlLm1hdGNoZXIudjMaGWVudm95L3R5cGUvdjMvcmFuZ2UucHJvdG8aHXVk",
            "cGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGiF1ZHBhL2Fubm90YXRpb25z",
            "L3ZlcnNpb25pbmcucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIowB",
            "Cg1Eb3VibGVNYXRjaGVyEisKBXJhbmdlGAEgASgLMhouZW52b3kudHlwZS52",
            "My5Eb3VibGVSYW5nZUgAEg8KBWV4YWN0GAIgASgBSAA6J5rFiB4iCiBlbnZv",
            "eS50eXBlLm1hdGNoZXIuRG91YmxlTWF0Y2hlckIUCg1tYXRjaF9wYXR0ZXJu",
            "EgP4QgFChAEKI2lvLmVudm95cHJveHkuZW52b3kudHlwZS5tYXRjaGVyLnYz",
            "QgtOdW1iZXJQcm90b1ABWkZnaXRodWIuY29tL2Vudm95cHJveHkvZ28tY29u",
            "dHJvbC1wbGFuZS9lbnZveS90eXBlL21hdGNoZXIvdjM7bWF0Y2hlcnYzuoDI",
            "0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Type.V3.RangeReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.V3.DoubleMatcher), global::Envoy.Type.Matcher.V3.DoubleMatcher.Parser, new[]{ "Range", "Exact" }, new[]{ "MatchPattern" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specifies the way to match a double value.
  /// </summary>
  public sealed partial class DoubleMatcher : pb::IMessage<DoubleMatcher>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoubleMatcher> _parser = new pb::MessageParser<DoubleMatcher>(() => new DoubleMatcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoubleMatcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.V3.NumberReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher(DoubleMatcher other) : this() {
      switch (other.MatchPatternCase) {
        case MatchPatternOneofCase.Range:
          Range = other.Range.Clone();
          break;
        case MatchPatternOneofCase.Exact:
          Exact = other.Exact;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher Clone() {
      return new DoubleMatcher(this);
    }

    /// <summary>Field number for the "range" field.</summary>
    public const int RangeFieldNumber = 1;
    /// <summary>
    /// If specified, the input double value must be in the range specified here.
    /// Note: The range is using half-open interval semantics [start, end).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.V3.DoubleRange Range {
      get { return matchPatternCase_ == MatchPatternOneofCase.Range ? (global::Envoy.Type.V3.DoubleRange) matchPattern_ : null; }
      set {
        matchPattern_ = value;
        matchPatternCase_ = value == null ? MatchPatternOneofCase.None : MatchPatternOneofCase.Range;
      }
    }

    /// <summary>Field number for the "exact" field.</summary>
    public const int ExactFieldNumber = 2;
    /// <summary>
    /// If specified, the input double value must be equal to the value specified here.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Exact {
      get { return HasExact ? (double) matchPattern_ : 0D; }
      set {
        matchPattern_ = value;
        matchPatternCase_ = MatchPatternOneofCase.Exact;
      }
    }
    /// <summary>Gets whether the "exact" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExact {
      get { return matchPatternCase_ == MatchPatternOneofCase.Exact; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "exact" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearExact() {
      if (HasExact) {
        ClearMatchPattern();
      }
    }

    private object matchPattern_;
    /// <summary>Enum of possible cases for the "match_pattern" oneof.</summary>
    public enum MatchPatternOneofCase {
      None = 0,
      Range = 1,
      Exact = 2,
    }
    private MatchPatternOneofCase matchPatternCase_ = MatchPatternOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchPatternOneofCase MatchPatternCase {
      get { return matchPatternCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMatchPattern() {
      matchPatternCase_ = MatchPatternOneofCase.None;
      matchPattern_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoubleMatcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoubleMatcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Range, other.Range)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Exact, other.Exact)) return false;
      if (MatchPatternCase != other.MatchPatternCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (matchPatternCase_ == MatchPatternOneofCase.Range) hash ^= Range.GetHashCode();
      if (HasExact) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Exact);
      hash ^= (int) matchPatternCase_;
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (HasExact) {
        output.WriteRawTag(17);
        output.WriteDouble(Exact);
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (HasExact) {
        output.WriteRawTag(17);
        output.WriteDouble(Exact);
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Range);
      }
      if (HasExact) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoubleMatcher other) {
      if (other == null) {
        return;
      }
      switch (other.MatchPatternCase) {
        case MatchPatternOneofCase.Range:
          if (Range == null) {
            Range = new global::Envoy.Type.V3.DoubleRange();
          }
          Range.MergeFrom(other.Range);
          break;
        case MatchPatternOneofCase.Exact:
          Exact = other.Exact;
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
            global::Envoy.Type.V3.DoubleRange subBuilder = new global::Envoy.Type.V3.DoubleRange();
            if (matchPatternCase_ == MatchPatternOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 17: {
            Exact = input.ReadDouble();
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
            global::Envoy.Type.V3.DoubleRange subBuilder = new global::Envoy.Type.V3.DoubleRange();
            if (matchPatternCase_ == MatchPatternOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 17: {
            Exact = input.ReadDouble();
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
