// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/v3/http_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/v3/http_status.proto</summary>
  public static partial class HttpStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/v3/http_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HttpStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9lbnZveS90eXBlL3YzL2h0dHBfc3RhdHVzLnByb3RvEg1lbnZveS50eXBl",
            "LnYzGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9hbm5v",
            "dGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5w",
            "cm90byJfCgpIdHRwU3RhdHVzEjMKBGNvZGUYASABKA4yGS5lbnZveS50eXBl",
            "LnYzLlN0YXR1c0NvZGVCCvpCB4IBBBABIAA6HJrFiB4XChVlbnZveS50eXBl",
            "Lkh0dHBTdGF0dXMqtQkKClN0YXR1c0NvZGUSCQoFRW1wdHkQABIMCghDb250",
            "aW51ZRBkEgcKAk9LEMgBEgwKB0NyZWF0ZWQQyQESDQoIQWNjZXB0ZWQQygES",
            "IAobTm9uQXV0aG9yaXRhdGl2ZUluZm9ybWF0aW9uEMsBEg4KCU5vQ29udGVu",
            "dBDMARIRCgxSZXNldENvbnRlbnQQzQESEwoOUGFydGlhbENvbnRlbnQQzgES",
            "EAoLTXVsdGlTdGF0dXMQzwESFAoPQWxyZWFkeVJlcG9ydGVkENABEgsKBklN",
            "VXNlZBDiARIUCg9NdWx0aXBsZUNob2ljZXMQrAISFQoQTW92ZWRQZXJtYW5l",
            "bnRseRCtAhIKCgVGb3VuZBCuAhINCghTZWVPdGhlchCvAhIQCgtOb3RNb2Rp",
            "ZmllZBCwAhINCghVc2VQcm94eRCxAhIWChFUZW1wb3JhcnlSZWRpcmVjdBCz",
            "AhIWChFQZXJtYW5lbnRSZWRpcmVjdBC0AhIPCgpCYWRSZXF1ZXN0EJADEhEK",
            "DFVuYXV0aG9yaXplZBCRAxIUCg9QYXltZW50UmVxdWlyZWQQkgMSDgoJRm9y",
            "YmlkZGVuEJMDEg0KCE5vdEZvdW5kEJQDEhUKEE1ldGhvZE5vdEFsbG93ZWQQ",
            "lQMSEgoNTm90QWNjZXB0YWJsZRCWAxIgChtQcm94eUF1dGhlbnRpY2F0aW9u",
            "UmVxdWlyZWQQlwMSEwoOUmVxdWVzdFRpbWVvdXQQmAMSDQoIQ29uZmxpY3QQ",
            "mQMSCQoER29uZRCaAxITCg5MZW5ndGhSZXF1aXJlZBCbAxIXChJQcmVjb25k",
            "aXRpb25GYWlsZWQQnAMSFAoPUGF5bG9hZFRvb0xhcmdlEJ0DEg8KClVSSVRv",
            "b0xvbmcQngMSGQoUVW5zdXBwb3J0ZWRNZWRpYVR5cGUQnwMSGAoTUmFuZ2VO",
            "b3RTYXRpc2ZpYWJsZRCgAxIWChFFeHBlY3RhdGlvbkZhaWxlZBChAxIXChJN",
            "aXNkaXJlY3RlZFJlcXVlc3QQpQMSGAoTVW5wcm9jZXNzYWJsZUVudGl0eRCm",
            "AxILCgZMb2NrZWQQpwMSFQoQRmFpbGVkRGVwZW5kZW5jeRCoAxIUCg9VcGdy",
            "YWRlUmVxdWlyZWQQqgMSGQoUUHJlY29uZGl0aW9uUmVxdWlyZWQQrAMSFAoP",
            "VG9vTWFueVJlcXVlc3RzEK0DEiAKG1JlcXVlc3RIZWFkZXJGaWVsZHNUb29M",
            "YXJnZRCvAxIYChNJbnRlcm5hbFNlcnZlckVycm9yEPQDEhMKDk5vdEltcGxl",
            "bWVudGVkEPUDEg8KCkJhZEdhdGV3YXkQ9gMSFwoSU2VydmljZVVuYXZhaWxh",
            "YmxlEPcDEhMKDkdhdGV3YXlUaW1lb3V0EPgDEhwKF0hUVFBWZXJzaW9uTm90",
            "U3VwcG9ydGVkEPkDEhoKFVZhcmlhbnRBbHNvTmVnb3RpYXRlcxD6AxIYChNJ",
            "bnN1ZmZpY2llbnRTdG9yYWdlEPsDEhEKDExvb3BEZXRlY3RlZBD8AxIQCgtO",
            "b3RFeHRlbmRlZBD+AxIiCh1OZXR3b3JrQXV0aGVudGljYXRpb25SZXF1aXJl",
            "ZBD/A0J1Chtpby5lbnZveXByb3h5LmVudm95LnR5cGUudjNCD0h0dHBTdGF0",
            "dXNQcm90b1ABWjtnaXRodWIuY29tL2Vudm95cHJveHkvZ28tY29udHJvbC1w",
            "bGFuZS9lbnZveS90eXBlL3YzO3R5cGV2M7qAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Envoy.Type.V3.StatusCode), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.V3.HttpStatus), global::Envoy.Type.V3.HttpStatus.Parser, new[]{ "Code" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// HTTP response codes supported in Envoy.
  /// For more details: https://www.iana.org/assignments/http-status-codes/http-status-codes.xhtml
  /// </summary>
  public enum StatusCode {
    /// <summary>
    /// Empty - This code not part of the HTTP status code specification, but it is needed for proto
    /// `enum` type.
    /// </summary>
    [pbr::OriginalName("Empty")] Empty = 0,
    [pbr::OriginalName("Continue")] Continue = 100,
    [pbr::OriginalName("OK")] Ok = 200,
    [pbr::OriginalName("Created")] Created = 201,
    [pbr::OriginalName("Accepted")] Accepted = 202,
    [pbr::OriginalName("NonAuthoritativeInformation")] NonAuthoritativeInformation = 203,
    [pbr::OriginalName("NoContent")] NoContent = 204,
    [pbr::OriginalName("ResetContent")] ResetContent = 205,
    [pbr::OriginalName("PartialContent")] PartialContent = 206,
    [pbr::OriginalName("MultiStatus")] MultiStatus = 207,
    [pbr::OriginalName("AlreadyReported")] AlreadyReported = 208,
    [pbr::OriginalName("IMUsed")] Imused = 226,
    [pbr::OriginalName("MultipleChoices")] MultipleChoices = 300,
    [pbr::OriginalName("MovedPermanently")] MovedPermanently = 301,
    [pbr::OriginalName("Found")] Found = 302,
    [pbr::OriginalName("SeeOther")] SeeOther = 303,
    [pbr::OriginalName("NotModified")] NotModified = 304,
    [pbr::OriginalName("UseProxy")] UseProxy = 305,
    [pbr::OriginalName("TemporaryRedirect")] TemporaryRedirect = 307,
    [pbr::OriginalName("PermanentRedirect")] PermanentRedirect = 308,
    [pbr::OriginalName("BadRequest")] BadRequest = 400,
    [pbr::OriginalName("Unauthorized")] Unauthorized = 401,
    [pbr::OriginalName("PaymentRequired")] PaymentRequired = 402,
    [pbr::OriginalName("Forbidden")] Forbidden = 403,
    [pbr::OriginalName("NotFound")] NotFound = 404,
    [pbr::OriginalName("MethodNotAllowed")] MethodNotAllowed = 405,
    [pbr::OriginalName("NotAcceptable")] NotAcceptable = 406,
    [pbr::OriginalName("ProxyAuthenticationRequired")] ProxyAuthenticationRequired = 407,
    [pbr::OriginalName("RequestTimeout")] RequestTimeout = 408,
    [pbr::OriginalName("Conflict")] Conflict = 409,
    [pbr::OriginalName("Gone")] Gone = 410,
    [pbr::OriginalName("LengthRequired")] LengthRequired = 411,
    [pbr::OriginalName("PreconditionFailed")] PreconditionFailed = 412,
    [pbr::OriginalName("PayloadTooLarge")] PayloadTooLarge = 413,
    [pbr::OriginalName("URITooLong")] UritooLong = 414,
    [pbr::OriginalName("UnsupportedMediaType")] UnsupportedMediaType = 415,
    [pbr::OriginalName("RangeNotSatisfiable")] RangeNotSatisfiable = 416,
    [pbr::OriginalName("ExpectationFailed")] ExpectationFailed = 417,
    [pbr::OriginalName("MisdirectedRequest")] MisdirectedRequest = 421,
    [pbr::OriginalName("UnprocessableEntity")] UnprocessableEntity = 422,
    [pbr::OriginalName("Locked")] Locked = 423,
    [pbr::OriginalName("FailedDependency")] FailedDependency = 424,
    [pbr::OriginalName("UpgradeRequired")] UpgradeRequired = 426,
    [pbr::OriginalName("PreconditionRequired")] PreconditionRequired = 428,
    [pbr::OriginalName("TooManyRequests")] TooManyRequests = 429,
    [pbr::OriginalName("RequestHeaderFieldsTooLarge")] RequestHeaderFieldsTooLarge = 431,
    [pbr::OriginalName("InternalServerError")] InternalServerError = 500,
    [pbr::OriginalName("NotImplemented")] NotImplemented = 501,
    [pbr::OriginalName("BadGateway")] BadGateway = 502,
    [pbr::OriginalName("ServiceUnavailable")] ServiceUnavailable = 503,
    [pbr::OriginalName("GatewayTimeout")] GatewayTimeout = 504,
    [pbr::OriginalName("HTTPVersionNotSupported")] HttpversionNotSupported = 505,
    [pbr::OriginalName("VariantAlsoNegotiates")] VariantAlsoNegotiates = 506,
    [pbr::OriginalName("InsufficientStorage")] InsufficientStorage = 507,
    [pbr::OriginalName("LoopDetected")] LoopDetected = 508,
    [pbr::OriginalName("NotExtended")] NotExtended = 510,
    [pbr::OriginalName("NetworkAuthenticationRequired")] NetworkAuthenticationRequired = 511,
  }

  #endregion

  #region Messages
  /// <summary>
  /// HTTP status.
  /// </summary>
  public sealed partial class HttpStatus : pb::IMessage<HttpStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HttpStatus> _parser = new pb::MessageParser<HttpStatus>(() => new HttpStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HttpStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.V3.HttpStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpStatus(HttpStatus other) : this() {
      code_ = other.code_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HttpStatus Clone() {
      return new HttpStatus(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Envoy.Type.V3.StatusCode code_ = global::Envoy.Type.V3.StatusCode.Empty;
    /// <summary>
    /// Supplies HTTP response code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.V3.StatusCode Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HttpStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HttpStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::Envoy.Type.V3.StatusCode.Empty) hash ^= Code.GetHashCode();
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
      if (Code != global::Envoy.Type.V3.StatusCode.Empty) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
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
      if (Code != global::Envoy.Type.V3.StatusCode.Empty) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
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
      if (Code != global::Envoy.Type.V3.StatusCode.Empty) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HttpStatus other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::Envoy.Type.V3.StatusCode.Empty) {
        Code = other.Code;
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
            Code = (global::Envoy.Type.V3.StatusCode) input.ReadEnum();
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
            Code = (global::Envoy.Type.V3.StatusCode) input.ReadEnum();
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
