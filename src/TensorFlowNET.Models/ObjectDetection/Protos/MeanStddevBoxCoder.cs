// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object_detection/protos/mean_stddev_box_coder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Models.ObjectDetection.Protos {

  /// <summary>Holder for reflection information generated from object_detection/protos/mean_stddev_box_coder.proto</summary>
  public static partial class MeanStddevBoxCoderReflection {

    #region Descriptor
    /// <summary>File descriptor for object_detection/protos/mean_stddev_box_coder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MeanStddevBoxCoderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNvYmplY3RfZGV0ZWN0aW9uL3Byb3Rvcy9tZWFuX3N0ZGRldl9ib3hfY29k",
            "ZXIucHJvdG8SF29iamVjdF9kZXRlY3Rpb24ucHJvdG9zIiQKEk1lYW5TdGRk",
            "ZXZCb3hDb2RlchIOCgZzdGRkZXYYASABKAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.MeanStddevBoxCoder), global::Tensorflow.Models.ObjectDetection.Protos.MeanStddevBoxCoder.Parser, new[]{ "Stddev" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration proto for MeanStddevBoxCoder. See
  /// box_coders/mean_stddev_box_coder.py for details.
  /// </summary>
  public sealed partial class MeanStddevBoxCoder : pb::IMessage<MeanStddevBoxCoder> {
    private static readonly pb::MessageParser<MeanStddevBoxCoder> _parser = new pb::MessageParser<MeanStddevBoxCoder>(() => new MeanStddevBoxCoder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MeanStddevBoxCoder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.MeanStddevBoxCoderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MeanStddevBoxCoder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MeanStddevBoxCoder(MeanStddevBoxCoder other) : this() {
      stddev_ = other.stddev_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MeanStddevBoxCoder Clone() {
      return new MeanStddevBoxCoder(this);
    }

    /// <summary>Field number for the "stddev" field.</summary>
    public const int StddevFieldNumber = 1;
    private float stddev_;
    /// <summary>
    /// The standard deviation used to encode and decode boxes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Stddev {
      get { return stddev_; }
      set {
        stddev_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MeanStddevBoxCoder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MeanStddevBoxCoder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Stddev, other.Stddev)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Stddev != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Stddev);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Stddev != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Stddev);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Stddev != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MeanStddevBoxCoder other) {
      if (other == null) {
        return;
      }
      if (other.Stddev != 0F) {
        Stddev = other.Stddev;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            Stddev = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code