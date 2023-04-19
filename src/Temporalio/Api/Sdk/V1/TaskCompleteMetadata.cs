// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/sdk/v1/task_complete_metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Sdk.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/sdk/v1/task_complete_metadata.proto</summary>
  public static partial class TaskCompleteMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/sdk/v1/task_complete_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskCompleteMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjB0ZW1wb3JhbC9hcGkvc2RrL3YxL3Rhc2tfY29tcGxldGVfbWV0YWRhdGEu",
            "cHJvdG8SE3RlbXBvcmFsLmFwaS5zZGsudjEiUQodV29ya2Zsb3dUYXNrQ29t",
            "cGxldGVkTWV0YWRhdGESFwoPY29yZV91c2VkX2ZsYWdzGAEgAygNEhcKD2xh",
            "bmdfdXNlZF9mbGFncxgCIAMoDUKHAQoWaW8udGVtcG9yYWwuYXBpLnNkay52",
            "MUIZVGFza0NvbXBsZXRlTWV0YWRhdGFQcm90b1ABWh1nby50ZW1wb3JhbC5p",
            "by9hcGkvc2RrL3YxO3Nka6oCFVRlbXBvcmFsaW8uQXBpLlNkay5WMeoCGFRl",
            "bXBvcmFsaW86OkFwaTo6U2RrOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Temporalio.Api.Sdk.V1.WorkflowTaskCompletedMetadata), global::Temporalio.Api.Sdk.V1.WorkflowTaskCompletedMetadata.Parser, new[]{ "CoreUsedFlags", "LangUsedFlags" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WorkflowTaskCompletedMetadata : pb::IMessage<WorkflowTaskCompletedMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorkflowTaskCompletedMetadata> _parser = new pb::MessageParser<WorkflowTaskCompletedMetadata>(() => new WorkflowTaskCompletedMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorkflowTaskCompletedMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Temporalio.Api.Sdk.V1.TaskCompleteMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkflowTaskCompletedMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkflowTaskCompletedMetadata(WorkflowTaskCompletedMetadata other) : this() {
      coreUsedFlags_ = other.coreUsedFlags_.Clone();
      langUsedFlags_ = other.langUsedFlags_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorkflowTaskCompletedMetadata Clone() {
      return new WorkflowTaskCompletedMetadata(this);
    }

    /// <summary>Field number for the "core_used_flags" field.</summary>
    public const int CoreUsedFlagsFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_coreUsedFlags_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> coreUsedFlags_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// Internal flags used by the core SDK. SDKs using flags must comply with the following behavior:
    ///
    /// During replay:
    /// * If a flag is not recognized (value is too high or not defined), it must fail the workflow
    ///   task.
    /// * If a flag is recognized, it is stored in a set of used flags for the run. Code checks for
    ///   that flag during and after this WFT are allowed to assume that the flag is present.
    /// * If a code check for a flag does not find the flag in the set of used flags, it must take
    ///   the branch corresponding to the absence of that flag.
    ///
    /// During non-replay execution of new WFTs:
    /// * The SDK is free to use all flags it knows about. It must record any newly-used (IE: not
    ///   previously recorded) flags when completing the WFT.
    ///
    /// SDKs which are too old to even know about this field at all are considered to produce
    /// undefined behavior if they replay workflows which used this mechanism.
    ///
    /// (-- api-linter: core::0141::forbidden-types=disabled
    ///     aip.dev/not-precedent: These really shouldn't have negative values. --)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CoreUsedFlags {
      get { return coreUsedFlags_; }
    }

    /// <summary>Field number for the "lang_used_flags" field.</summary>
    public const int LangUsedFlagsFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_langUsedFlags_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> langUsedFlags_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// Flags used by the SDK lang. No attempt is made to distinguish between different SDK languages
    /// here as processing a workflow with a different language than the one which authored it is
    /// already undefined behavior. See `core_used_patches` for more.
    ///
    /// (-- api-linter: core::0141::forbidden-types=disabled
    ///     aip.dev/not-precedent: These really shouldn't have negative values. --)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LangUsedFlags {
      get { return langUsedFlags_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorkflowTaskCompletedMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorkflowTaskCompletedMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!coreUsedFlags_.Equals(other.coreUsedFlags_)) return false;
      if(!langUsedFlags_.Equals(other.langUsedFlags_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= coreUsedFlags_.GetHashCode();
      hash ^= langUsedFlags_.GetHashCode();
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
      coreUsedFlags_.WriteTo(output, _repeated_coreUsedFlags_codec);
      langUsedFlags_.WriteTo(output, _repeated_langUsedFlags_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      coreUsedFlags_.WriteTo(ref output, _repeated_coreUsedFlags_codec);
      langUsedFlags_.WriteTo(ref output, _repeated_langUsedFlags_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += coreUsedFlags_.CalculateSize(_repeated_coreUsedFlags_codec);
      size += langUsedFlags_.CalculateSize(_repeated_langUsedFlags_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorkflowTaskCompletedMetadata other) {
      if (other == null) {
        return;
      }
      coreUsedFlags_.Add(other.coreUsedFlags_);
      langUsedFlags_.Add(other.langUsedFlags_);
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
          case 10:
          case 8: {
            coreUsedFlags_.AddEntriesFrom(input, _repeated_coreUsedFlags_codec);
            break;
          }
          case 18:
          case 16: {
            langUsedFlags_.AddEntriesFrom(input, _repeated_langUsedFlags_codec);
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
          case 10:
          case 8: {
            coreUsedFlags_.AddEntriesFrom(ref input, _repeated_coreUsedFlags_codec);
            break;
          }
          case 18:
          case 16: {
            langUsedFlags_.AddEntriesFrom(ref input, _repeated_langUsedFlags_codec);
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
