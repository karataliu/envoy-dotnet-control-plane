// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/http/v3/path_transformation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Http.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/http/v3/path_transformation.proto</summary>
  public static partial class PathTransformationReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/http/v3/path_transformation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PathTransformationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixlbnZveS90eXBlL2h0dHAvdjMvcGF0aF90cmFuc2Zvcm1hdGlvbi5wcm90",
            "bxISZW52b3kudHlwZS5odHRwLnYzGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1",
            "cy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUucHJvdG8i7gIKElBhdGhUcmFu",
            "c2Zvcm1hdGlvbhJECgpvcGVyYXRpb25zGAEgAygLMjAuZW52b3kudHlwZS5o",
            "dHRwLnYzLlBhdGhUcmFuc2Zvcm1hdGlvbi5PcGVyYXRpb24akQIKCU9wZXJh",
            "dGlvbhJoChdub3JtYWxpemVfcGF0aF9yZmNfMzk4NhgCIAEoCzJFLmVudm95",
            "LnR5cGUuaHR0cC52My5QYXRoVHJhbnNmb3JtYXRpb24uT3BlcmF0aW9uLk5v",
            "cm1hbGl6ZVBhdGhSRkMzOTg2SAASVgoNbWVyZ2Vfc2xhc2hlcxgDIAEoCzI9",
            "LmVudm95LnR5cGUuaHR0cC52My5QYXRoVHJhbnNmb3JtYXRpb24uT3BlcmF0",
            "aW9uLk1lcmdlU2xhc2hlc0gAGhYKFE5vcm1hbGl6ZVBhdGhSRkMzOTg2Gg4K",
            "DE1lcmdlU2xhc2hlc0IaChNvcGVyYXRpb25fc3BlY2lmaWVyEgP4QgFChwEK",
            "IGlvLmVudm95cHJveHkuZW52b3kudHlwZS5odHRwLnYzQhdQYXRoVHJhbnNm",
            "b3JtYXRpb25Qcm90b1ABWkBnaXRodWIuY29tL2Vudm95cHJveHkvZ28tY29u",
            "dHJvbC1wbGFuZS9lbnZveS90eXBlL2h0dHAvdjM7aHR0cHYzuoDI0QYCEAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Http.V3.PathTransformation), global::Envoy.Type.Http.V3.PathTransformation.Parser, new[]{ "Operations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Http.V3.PathTransformation.Types.Operation), global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Parser, new[]{ "NormalizePathRfc3986", "MergeSlashes" }, new[]{ "OperationSpecifier" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986), global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes), global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes.Parser, null, null, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PathTransformation : pb::IMessage<PathTransformation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PathTransformation> _parser = new pb::MessageParser<PathTransformation>(() => new PathTransformation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PathTransformation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Http.V3.PathTransformationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathTransformation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathTransformation(PathTransformation other) : this() {
      operations_ = other.operations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathTransformation Clone() {
      return new PathTransformation(this);
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Envoy.Type.Http.V3.PathTransformation.Types.Operation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(10, global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Type.Http.V3.PathTransformation.Types.Operation> operations_ = new pbc::RepeatedField<global::Envoy.Type.Http.V3.PathTransformation.Types.Operation>();
    /// <summary>
    /// A list of operations to apply. Transformations will be performed in the order that they appear.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Type.Http.V3.PathTransformation.Types.Operation> Operations {
      get { return operations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PathTransformation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PathTransformation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!operations_.Equals(other.operations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= operations_.GetHashCode();
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
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      operations_.WriteTo(ref output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PathTransformation other) {
      if (other == null) {
        return;
      }
      operations_.Add(other.operations_);
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
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
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
            operations_.AddEntriesFrom(ref input, _repeated_operations_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PathTransformation message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// A type of operation to alter text.
      /// </summary>
      public sealed partial class Operation : pb::IMessage<Operation>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Operation> _parser = new pb::MessageParser<Operation>(() => new Operation());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Operation> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Type.Http.V3.PathTransformation.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Operation() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Operation(Operation other) : this() {
          switch (other.OperationSpecifierCase) {
            case OperationSpecifierOneofCase.NormalizePathRfc3986:
              NormalizePathRfc3986 = other.NormalizePathRfc3986.Clone();
              break;
            case OperationSpecifierOneofCase.MergeSlashes:
              MergeSlashes = other.MergeSlashes.Clone();
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Operation Clone() {
          return new Operation(this);
        }

        /// <summary>Field number for the "normalize_path_rfc_3986" field.</summary>
        public const int NormalizePathRfc3986FieldNumber = 2;
        /// <summary>
        /// Enable path normalization per RFC 3986.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986 NormalizePathRfc3986 {
          get { return operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986 ? (global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986) operationSpecifier_ : null; }
          set {
            operationSpecifier_ = value;
            operationSpecifierCase_ = value == null ? OperationSpecifierOneofCase.None : OperationSpecifierOneofCase.NormalizePathRfc3986;
          }
        }

        /// <summary>Field number for the "merge_slashes" field.</summary>
        public const int MergeSlashesFieldNumber = 3;
        /// <summary>
        /// Enable merging adjacent slashes.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes MergeSlashes {
          get { return operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes ? (global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes) operationSpecifier_ : null; }
          set {
            operationSpecifier_ = value;
            operationSpecifierCase_ = value == null ? OperationSpecifierOneofCase.None : OperationSpecifierOneofCase.MergeSlashes;
          }
        }

        private object operationSpecifier_;
        /// <summary>Enum of possible cases for the "operation_specifier" oneof.</summary>
        public enum OperationSpecifierOneofCase {
          None = 0,
          NormalizePathRfc3986 = 2,
          MergeSlashes = 3,
        }
        private OperationSpecifierOneofCase operationSpecifierCase_ = OperationSpecifierOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public OperationSpecifierOneofCase OperationSpecifierCase {
          get { return operationSpecifierCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearOperationSpecifier() {
          operationSpecifierCase_ = OperationSpecifierOneofCase.None;
          operationSpecifier_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Operation);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Operation other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(NormalizePathRfc3986, other.NormalizePathRfc3986)) return false;
          if (!object.Equals(MergeSlashes, other.MergeSlashes)) return false;
          if (OperationSpecifierCase != other.OperationSpecifierCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) hash ^= NormalizePathRfc3986.GetHashCode();
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) hash ^= MergeSlashes.GetHashCode();
          hash ^= (int) operationSpecifierCase_;
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
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) {
            output.WriteRawTag(18);
            output.WriteMessage(NormalizePathRfc3986);
          }
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) {
            output.WriteRawTag(26);
            output.WriteMessage(MergeSlashes);
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
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) {
            output.WriteRawTag(18);
            output.WriteMessage(NormalizePathRfc3986);
          }
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) {
            output.WriteRawTag(26);
            output.WriteMessage(MergeSlashes);
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
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(NormalizePathRfc3986);
          }
          if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MergeSlashes);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Operation other) {
          if (other == null) {
            return;
          }
          switch (other.OperationSpecifierCase) {
            case OperationSpecifierOneofCase.NormalizePathRfc3986:
              if (NormalizePathRfc3986 == null) {
                NormalizePathRfc3986 = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986();
              }
              NormalizePathRfc3986.MergeFrom(other.NormalizePathRfc3986);
              break;
            case OperationSpecifierOneofCase.MergeSlashes:
              if (MergeSlashes == null) {
                MergeSlashes = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes();
              }
              MergeSlashes.MergeFrom(other.MergeSlashes);
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
              case 18: {
                global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986 subBuilder = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986();
                if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) {
                  subBuilder.MergeFrom(NormalizePathRfc3986);
                }
                input.ReadMessage(subBuilder);
                NormalizePathRfc3986 = subBuilder;
                break;
              }
              case 26: {
                global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes subBuilder = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes();
                if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) {
                  subBuilder.MergeFrom(MergeSlashes);
                }
                input.ReadMessage(subBuilder);
                MergeSlashes = subBuilder;
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
              case 18: {
                global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986 subBuilder = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.NormalizePathRFC3986();
                if (operationSpecifierCase_ == OperationSpecifierOneofCase.NormalizePathRfc3986) {
                  subBuilder.MergeFrom(NormalizePathRfc3986);
                }
                input.ReadMessage(subBuilder);
                NormalizePathRfc3986 = subBuilder;
                break;
              }
              case 26: {
                global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes subBuilder = new global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Types.MergeSlashes();
                if (operationSpecifierCase_ == OperationSpecifierOneofCase.MergeSlashes) {
                  subBuilder.MergeFrom(MergeSlashes);
                }
                input.ReadMessage(subBuilder);
                MergeSlashes = subBuilder;
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the Operation message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// Should text be normalized according to RFC 3986? This typically is used for path headers
          /// before any processing of requests by HTTP filters or routing. This applies percent-encoded
          /// normalization and path segment normalization. Fails on characters disallowed in URLs
          /// (e.g. NULLs). See `Normalization and Comparison
          /// &lt;https://tools.ietf.org/html/rfc3986#section-6>`_ for details of normalization. Note that
          /// this options does not perform `case normalization
          /// &lt;https://tools.ietf.org/html/rfc3986#section-6.2.2.1>`_
          /// </summary>
          public sealed partial class NormalizePathRFC3986 : pb::IMessage<NormalizePathRFC3986>
          #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              , pb::IBufferMessage
          #endif
          {
            private static readonly pb::MessageParser<NormalizePathRFC3986> _parser = new pb::MessageParser<NormalizePathRFC3986>(() => new NormalizePathRFC3986());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pb::MessageParser<NormalizePathRFC3986> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public NormalizePathRFC3986() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public NormalizePathRFC3986(NormalizePathRFC3986 other) : this() {
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public NormalizePathRFC3986 Clone() {
              return new NormalizePathRFC3986(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override bool Equals(object other) {
              return Equals(other as NormalizePathRFC3986);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool Equals(NormalizePathRFC3986 other) {
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
            public void MergeFrom(NormalizePathRFC3986 other) {
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

          /// <summary>
          /// Determines if adjacent slashes are merged into one. A common use case is for a request path
          /// header. Using this option in ``:ref: PathNormalizationOptions
          /// &lt;envoy_v3_api_msg_extensions.filters.network.http_connection_manager.v3.HttpConnectionManager.PathNormalizationOptions>``
          /// will allow incoming requests with path ``//dir///file`` to match against route with ``prefix``
          /// match set to ``/dir``. When using for header transformations, note that slash merging is not
          /// part of `HTTP spec &lt;https://tools.ietf.org/html/rfc3986>`_ and is provided for convenience.
          /// </summary>
          public sealed partial class MergeSlashes : pb::IMessage<MergeSlashes>
          #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              , pb::IBufferMessage
          #endif
          {
            private static readonly pb::MessageParser<MergeSlashes> _parser = new pb::MessageParser<MergeSlashes>(() => new MergeSlashes());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pb::MessageParser<MergeSlashes> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Envoy.Type.Http.V3.PathTransformation.Types.Operation.Descriptor.NestedTypes[1]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public MergeSlashes() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public MergeSlashes(MergeSlashes other) : this() {
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public MergeSlashes Clone() {
              return new MergeSlashes(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override bool Equals(object other) {
              return Equals(other as MergeSlashes);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool Equals(MergeSlashes other) {
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
            public void MergeFrom(MergeSlashes other) {
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

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code