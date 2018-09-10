// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: 1000_GCLogin.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from 1000_GCLogin.proto</summary>
  public static partial class GCLoginReflection {

    #region Descriptor
    /// <summary>File descriptor for 1000_GCLogin.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCLoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChIxMDAwX0dDTG9naW4ucHJvdG8aE1BCQWNjb3VudERhdGEucHJvdG8iPwoH",
            "R0NMb2dpbhIOCgZyZXN1bHQYASABKAUSJAoMYWNjb3VudF9kYXRhGAIgASgL",
            "Mg4uUEJBY2NvdW50RGF0YUJDCh1jb20ud2hhbGVpc2xhbmQuZ2FtZS5wcm90",
            "b2NvbEIPR0NMb2dpblByb3RvY29sqgIQQmlnSGVhZC5wcm90b2NvbGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::BigHead.protocol.PBAccountDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.GCLogin), global::BigHead.protocol.GCLogin.Parser, new[]{ "Result", "AccountData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCLogin : pb::IMessage<GCLogin> {
    private static readonly pb::MessageParser<GCLogin> _parser = new pb::MessageParser<GCLogin>(() => new GCLogin());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GCLogin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.GCLoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCLogin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCLogin(GCLogin other) : this() {
      result_ = other.result_;
      AccountData = other.accountData_ != null ? other.AccountData.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GCLogin Clone() {
      return new GCLogin(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "account_data" field.</summary>
    public const int AccountDataFieldNumber = 2;
    private global::BigHead.protocol.PBAccountData accountData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BigHead.protocol.PBAccountData AccountData {
      get { return accountData_; }
      set {
        accountData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GCLogin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GCLogin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(AccountData, other.AccountData)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (accountData_ != null) hash ^= AccountData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
      if (accountData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccountData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (accountData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccountData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GCLogin other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.accountData_ != null) {
        if (accountData_ == null) {
          accountData_ = new global::BigHead.protocol.PBAccountData();
        }
        AccountData.MergeFrom(other.AccountData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Result = input.ReadInt32();
            break;
          }
          case 18: {
            if (accountData_ == null) {
              accountData_ = new global::BigHead.protocol.PBAccountData();
            }
            input.ReadMessage(accountData_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code