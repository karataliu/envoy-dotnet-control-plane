// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: udpa/annotations/status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Udpa.Annotations {

  /// <summary>Holder for reflection information generated from udpa/annotations/status.proto</summary>
  public static partial class StatusReflection {

    #region Descriptor
    /// <summary>File descriptor for udpa/annotations/status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxIQdWRwYS5hbm5vdGF0",
            "aW9ucxogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8idAoQU3Rh",
            "dHVzQW5ub3RhdGlvbhIYChB3b3JrX2luX3Byb2dyZXNzGAEgASgIEkYKFnBh",
            "Y2thZ2VfdmVyc2lvbl9zdGF0dXMYAiABKA4yJi51ZHBhLmFubm90YXRpb25z",
            "LlBhY2thZ2VWZXJzaW9uU3RhdHVzKl0KFFBhY2thZ2VWZXJzaW9uU3RhdHVz",
            "EgsKB1VOS05PV04QABIKCgZGUk9aRU4QARIKCgZBQ1RJVkUQAhIgChxORVhU",
            "X01BSk9SX1ZFUlNJT05fQ0FORElEQVRFEAM6WAoLZmlsZV9zdGF0dXMSHC5n",
            "b29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYh4CZaiABKAsyIi51ZHBhLmFu",
            "bm90YXRpb25zLlN0YXR1c0Fubm90YXRpb25CJFoiZ2l0aHViLmNvbS9jbmNm",
            "L3hkcy9nby9hbm5vdGF0aW9uc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Udpa.Annotations.PackageVersionStatus), }, new pb::Extension[] { StatusExtensions.FileStatus }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Udpa.Annotations.StatusAnnotation), global::Udpa.Annotations.StatusAnnotation.Parser, new[]{ "WorkInProgress", "PackageVersionStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of udpa/annotations/status.proto</summary>
  public static partial class StatusExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Udpa.Annotations.StatusAnnotation> FileStatus =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Udpa.Annotations.StatusAnnotation>(222707719, pb::FieldCodec.ForMessage(1781661754, global::Udpa.Annotations.StatusAnnotation.Parser));
  }

  #region Enums
  public enum PackageVersionStatus {
    /// <summary>
    /// Unknown package version status.
    /// </summary>
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    /// <summary>
    /// This version of the package is frozen.
    /// </summary>
    [pbr::OriginalName("FROZEN")] Frozen = 1,
    /// <summary>
    /// This version of the package is the active development version.
    /// </summary>
    [pbr::OriginalName("ACTIVE")] Active = 2,
    /// <summary>
    /// This version of the package is the candidate for the next major version. It
    /// is typically machine generated from the active development version.
    /// </summary>
    [pbr::OriginalName("NEXT_MAJOR_VERSION_CANDIDATE")] NextMajorVersionCandidate = 3,
  }

  #endregion

  #region Messages
  public sealed partial class StatusAnnotation : pb::IMessage<StatusAnnotation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StatusAnnotation> _parser = new pb::MessageParser<StatusAnnotation>(() => new StatusAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StatusAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Udpa.Annotations.StatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusAnnotation(StatusAnnotation other) : this() {
      workInProgress_ = other.workInProgress_;
      packageVersionStatus_ = other.packageVersionStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusAnnotation Clone() {
      return new StatusAnnotation(this);
    }

    /// <summary>Field number for the "work_in_progress" field.</summary>
    public const int WorkInProgressFieldNumber = 1;
    private bool workInProgress_;
    /// <summary>
    /// The entity is work-in-progress and subject to breaking changes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool WorkInProgress {
      get { return workInProgress_; }
      set {
        workInProgress_ = value;
      }
    }

    /// <summary>Field number for the "package_version_status" field.</summary>
    public const int PackageVersionStatusFieldNumber = 2;
    private global::Udpa.Annotations.PackageVersionStatus packageVersionStatus_ = global::Udpa.Annotations.PackageVersionStatus.Unknown;
    /// <summary>
    /// The entity belongs to a package with the given version status.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Udpa.Annotations.PackageVersionStatus PackageVersionStatus {
      get { return packageVersionStatus_; }
      set {
        packageVersionStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StatusAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StatusAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorkInProgress != other.WorkInProgress) return false;
      if (PackageVersionStatus != other.PackageVersionStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorkInProgress != false) hash ^= WorkInProgress.GetHashCode();
      if (PackageVersionStatus != global::Udpa.Annotations.PackageVersionStatus.Unknown) hash ^= PackageVersionStatus.GetHashCode();
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
      if (WorkInProgress != false) {
        output.WriteRawTag(8);
        output.WriteBool(WorkInProgress);
      }
      if (PackageVersionStatus != global::Udpa.Annotations.PackageVersionStatus.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PackageVersionStatus);
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
      if (WorkInProgress != false) {
        output.WriteRawTag(8);
        output.WriteBool(WorkInProgress);
      }
      if (PackageVersionStatus != global::Udpa.Annotations.PackageVersionStatus.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PackageVersionStatus);
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
      if (WorkInProgress != false) {
        size += 1 + 1;
      }
      if (PackageVersionStatus != global::Udpa.Annotations.PackageVersionStatus.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PackageVersionStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StatusAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.WorkInProgress != false) {
        WorkInProgress = other.WorkInProgress;
      }
      if (other.PackageVersionStatus != global::Udpa.Annotations.PackageVersionStatus.Unknown) {
        PackageVersionStatus = other.PackageVersionStatus;
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
            WorkInProgress = input.ReadBool();
            break;
          }
          case 16: {
            PackageVersionStatus = (global::Udpa.Annotations.PackageVersionStatus) input.ReadEnum();
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
            WorkInProgress = input.ReadBool();
            break;
          }
          case 16: {
            PackageVersionStatus = (global::Udpa.Annotations.PackageVersionStatus) input.ReadEnum();
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
