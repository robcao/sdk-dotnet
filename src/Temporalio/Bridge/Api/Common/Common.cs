// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/sdk/core/common/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Bridge.Api.Common {

  /// <summary>Holder for reflection information generated from temporal/sdk/core/common/common.proto</summary>
  internal static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/sdk/core/common/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV0ZW1wb3JhbC9zZGsvY29yZS9jb21tb24vY29tbW9uLnByb3RvEg5jb3Jl",
            "c2RrLmNvbW1vbhoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvIlUK",
            "G05hbWVzcGFjZWRXb3JrZmxvd0V4ZWN1dGlvbhIRCgluYW1lc3BhY2UYASAB",
            "KAkSEwoLd29ya2Zsb3dfaWQYAiABKAkSDgoGcnVuX2lkGAMgASgJKkAKEFZl",
            "cnNpb25pbmdJbnRlbnQSDwoLVU5TUEVDSUZJRUQQABIOCgpDT01QQVRJQkxF",
            "EAESCwoHREVGQVVMVBACQizqAilUZW1wb3JhbGlvOjpJbnRlcm5hbDo6QnJp",
            "ZGdlOjpBcGk6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Bridge.Api.Common.VersioningIntent), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Temporalio.Bridge.Api.Common.NamespacedWorkflowExecution), global::Temporalio.Bridge.Api.Common.NamespacedWorkflowExecution.Parser, new[]{ "Namespace", "WorkflowId", "RunId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// An indication of user's intent concerning what Build ID versioning approach should be used for
  /// a specific command
  /// </summary>
  internal enum VersioningIntent {
    /// <summary>
    /// Indicates that core should choose the most sensible default behavior for the type of
    /// command, accounting for whether the command will be run on the same task queue as the current
    /// worker.
    /// </summary>
    [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Indicates that the command should run on a worker with compatible version if possible. It may
    /// not be possible if the target task queue does not also have knowledge of the current worker's
    /// build ID.
    /// </summary>
    [pbr::OriginalName("COMPATIBLE")] Compatible = 1,
    /// <summary>
    /// Indicates that the command should run on the target task queue's current overall-default
    /// build ID.
    /// </summary>
    [pbr::OriginalName("DEFAULT")] Default = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Identifying information about a particular workflow execution, including namespace
  /// </summary>
  internal sealed partial class NamespacedWorkflowExecution : pb::IMessage<NamespacedWorkflowExecution>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NamespacedWorkflowExecution> _parser = new pb::MessageParser<NamespacedWorkflowExecution>(() => new NamespacedWorkflowExecution());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NamespacedWorkflowExecution> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Temporalio.Bridge.Api.Common.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespacedWorkflowExecution() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespacedWorkflowExecution(NamespacedWorkflowExecution other) : this() {
      namespace_ = other.namespace_;
      workflowId_ = other.workflowId_;
      runId_ = other.runId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NamespacedWorkflowExecution Clone() {
      return new NamespacedWorkflowExecution(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 1;
    private string namespace_ = "";
    /// <summary>
    /// Namespace the workflow run is located in
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Namespace {
      get { return namespace_; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "workflow_id" field.</summary>
    public const int WorkflowIdFieldNumber = 2;
    private string workflowId_ = "";
    /// <summary>
    /// Can never be empty
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string WorkflowId {
      get { return workflowId_; }
      set {
        workflowId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "run_id" field.</summary>
    public const int RunIdFieldNumber = 3;
    private string runId_ = "";
    /// <summary>
    /// May be empty if the most recent run of the workflow with the given ID is being targeted
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RunId {
      get { return runId_; }
      set {
        runId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NamespacedWorkflowExecution);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NamespacedWorkflowExecution other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (WorkflowId != other.WorkflowId) return false;
      if (RunId != other.RunId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Namespace.Length != 0) hash ^= Namespace.GetHashCode();
      if (WorkflowId.Length != 0) hash ^= WorkflowId.GetHashCode();
      if (RunId.Length != 0) hash ^= RunId.GetHashCode();
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (WorkflowId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(WorkflowId);
      }
      if (RunId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RunId);
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (WorkflowId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(WorkflowId);
      }
      if (RunId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RunId);
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
      if (Namespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (WorkflowId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WorkflowId);
      }
      if (RunId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RunId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NamespacedWorkflowExecution other) {
      if (other == null) {
        return;
      }
      if (other.Namespace.Length != 0) {
        Namespace = other.Namespace;
      }
      if (other.WorkflowId.Length != 0) {
        WorkflowId = other.WorkflowId;
      }
      if (other.RunId.Length != 0) {
        RunId = other.RunId;
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
            Namespace = input.ReadString();
            break;
          }
          case 18: {
            WorkflowId = input.ReadString();
            break;
          }
          case 26: {
            RunId = input.ReadString();
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
            Namespace = input.ReadString();
            break;
          }
          case 18: {
            WorkflowId = input.ReadString();
            break;
          }
          case 26: {
            RunId = input.ReadString();
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
