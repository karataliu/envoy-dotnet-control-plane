// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/v3/semantic_version.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/v3/semantic_version.proto</summary>
  public static partial class SemanticVersionReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/v3/semantic_version.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SemanticVersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRlbnZveS90eXBlL3YzL3NlbWFudGljX3ZlcnNpb24ucHJvdG8SDWVudm95",
            "LnR5cGUudjMaHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGiF1ZHBh",
            "L2Fubm90YXRpb25zL3ZlcnNpb25pbmcucHJvdG8ibwoPU2VtYW50aWNWZXJz",
            "aW9uEhQKDG1ham9yX251bWJlchgBIAEoDRIUCgxtaW5vcl9udW1iZXIYAiAB",
            "KA0SDQoFcGF0Y2gYAyABKA06IZrFiB4cChplbnZveS50eXBlLlNlbWFudGlj",
            "VmVyc2lvbkJ6Chtpby5lbnZveXByb3h5LmVudm95LnR5cGUudjNCFFNlbWFu",
            "dGljVmVyc2lvblByb3RvUAFaO2dpdGh1Yi5jb20vZW52b3lwcm94eS9nby1j",
            "b250cm9sLXBsYW5lL2Vudm95L3R5cGUvdjM7dHlwZXYzuoDI0QYCEAJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.V3.SemanticVersion), global::Envoy.Type.V3.SemanticVersion.Parser, new[]{ "MajorNumber", "MinorNumber", "Patch" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Envoy uses SemVer (https://semver.org/). Major/minor versions indicate
  /// expected behaviors and APIs, the patch version field is used only
  /// for security fixes and can be generally ignored.
  /// </summary>
  public sealed partial class SemanticVersion : pb::IMessage<SemanticVersion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SemanticVersion> _parser = new pb::MessageParser<SemanticVersion>(() => new SemanticVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SemanticVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.V3.SemanticVersionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SemanticVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SemanticVersion(SemanticVersion other) : this() {
      majorNumber_ = other.majorNumber_;
      minorNumber_ = other.minorNumber_;
      patch_ = other.patch_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SemanticVersion Clone() {
      return new SemanticVersion(this);
    }

    /// <summary>Field number for the "major_number" field.</summary>
    public const int MajorNumberFieldNumber = 1;
    private uint majorNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MajorNumber {
      get { return majorNumber_; }
      set {
        majorNumber_ = value;
      }
    }

    /// <summary>Field number for the "minor_number" field.</summary>
    public const int MinorNumberFieldNumber = 2;
    private uint minorNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinorNumber {
      get { return minorNumber_; }
      set {
        minorNumber_ = value;
      }
    }

    /// <summary>Field number for the "patch" field.</summary>
    public const int PatchFieldNumber = 3;
    private uint patch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Patch {
      get { return patch_; }
      set {
        patch_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SemanticVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SemanticVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MajorNumber != other.MajorNumber) return false;
      if (MinorNumber != other.MinorNumber) return false;
      if (Patch != other.Patch) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MajorNumber != 0) hash ^= MajorNumber.GetHashCode();
      if (MinorNumber != 0) hash ^= MinorNumber.GetHashCode();
      if (Patch != 0) hash ^= Patch.GetHashCode();
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
      if (MajorNumber != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MajorNumber);
      }
      if (MinorNumber != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MinorNumber);
      }
      if (Patch != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Patch);
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
      if (MajorNumber != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MajorNumber);
      }
      if (MinorNumber != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MinorNumber);
      }
      if (Patch != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Patch);
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
      if (MajorNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MajorNumber);
      }
      if (MinorNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinorNumber);
      }
      if (Patch != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Patch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SemanticVersion other) {
      if (other == null) {
        return;
      }
      if (other.MajorNumber != 0) {
        MajorNumber = other.MajorNumber;
      }
      if (other.MinorNumber != 0) {
        MinorNumber = other.MinorNumber;
      }
      if (other.Patch != 0) {
        Patch = other.Patch;
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
            MajorNumber = input.ReadUInt32();
            break;
          }
          case 16: {
            MinorNumber = input.ReadUInt32();
            break;
          }
          case 24: {
            Patch = input.ReadUInt32();
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
            MajorNumber = input.ReadUInt32();
            break;
          }
          case 16: {
            MinorNumber = input.ReadUInt32();
            break;
          }
          case 24: {
            Patch = input.ReadUInt32();
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
