// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PBMapLayerData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BigHead.protocol {

  /// <summary>Holder for reflection information generated from PBMapLayerData.proto</summary>
  public static partial class PBMapLayerDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PBMapLayerData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PBMapLayerDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQQk1hcExheWVyRGF0YS5wcm90byJ7Cg5QQk1hcExheWVyRGF0YRINCgVp",
            "bmRleBgBIAEoBRINCgV3aWR0aBgCIAEoBRIOCgZoZWlnaHQYAyABKAUSEwoL",
            "cG9pbnRfdHlwZXMYBCADKAUSEQoJcG9pbnRfaWRzGAUgAygFEhMKC3BvaW50",
            "X3N0YXRlGAYgAygFQkoKHWNvbS53aGFsZWlzbGFuZC5nYW1lLnByb3RvY29s",
            "QhZQQk1hcExheWVyRGF0YVByb3RvY29sqgIQQmlnSGVhZC5wcm90b2NvbGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BigHead.protocol.PBMapLayerData), global::BigHead.protocol.PBMapLayerData.Parser, new[]{ "Index", "Width", "Height", "PointTypes", "PointIds", "PointState" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// map layer data
  /// </summary>
  public sealed partial class PBMapLayerData : pb::IMessage<PBMapLayerData> {
    private static readonly pb::MessageParser<PBMapLayerData> _parser = new pb::MessageParser<PBMapLayerData>(() => new PBMapLayerData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PBMapLayerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BigHead.protocol.PBMapLayerDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapLayerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapLayerData(PBMapLayerData other) : this() {
      index_ = other.index_;
      width_ = other.width_;
      height_ = other.height_;
      pointTypes_ = other.pointTypes_.Clone();
      pointIds_ = other.pointIds_.Clone();
      pointState_ = other.pointState_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBMapLayerData Clone() {
      return new PBMapLayerData(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 2;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "point_types" field.</summary>
    public const int PointTypesFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_pointTypes_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> pointTypes_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> PointTypes {
      get { return pointTypes_; }
    }

    /// <summary>Field number for the "point_ids" field.</summary>
    public const int PointIdsFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_pointIds_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> pointIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> PointIds {
      get { return pointIds_; }
    }

    /// <summary>Field number for the "point_state" field.</summary>
    public const int PointStateFieldNumber = 6;
    private static readonly pb::FieldCodec<int> _repeated_pointState_codec
        = pb::FieldCodec.ForInt32(50);
    private readonly pbc::RepeatedField<int> pointState_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///0没有走过,1走过了
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> PointState {
      get { return pointState_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PBMapLayerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PBMapLayerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      if(!pointTypes_.Equals(other.pointTypes_)) return false;
      if(!pointIds_.Equals(other.pointIds_)) return false;
      if(!pointState_.Equals(other.pointState_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      hash ^= pointTypes_.GetHashCode();
      hash ^= pointIds_.GetHashCode();
      hash ^= pointState_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (Width != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Height);
      }
      pointTypes_.WriteTo(output, _repeated_pointTypes_codec);
      pointIds_.WriteTo(output, _repeated_pointIds_codec);
      pointState_.WriteTo(output, _repeated_pointState_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      size += pointTypes_.CalculateSize(_repeated_pointTypes_codec);
      size += pointIds_.CalculateSize(_repeated_pointIds_codec);
      size += pointState_.CalculateSize(_repeated_pointState_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PBMapLayerData other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      pointTypes_.Add(other.pointTypes_);
      pointIds_.Add(other.pointIds_);
      pointState_.Add(other.pointState_);
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
            Index = input.ReadInt32();
            break;
          }
          case 16: {
            Width = input.ReadInt32();
            break;
          }
          case 24: {
            Height = input.ReadInt32();
            break;
          }
          case 34:
          case 32: {
            pointTypes_.AddEntriesFrom(input, _repeated_pointTypes_codec);
            break;
          }
          case 42:
          case 40: {
            pointIds_.AddEntriesFrom(input, _repeated_pointIds_codec);
            break;
          }
          case 50:
          case 48: {
            pointState_.AddEntriesFrom(input, _repeated_pointState_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code