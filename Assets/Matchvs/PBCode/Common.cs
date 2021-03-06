// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: common.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Matchvs {

  /// <summary>Holder for reflection information generated from common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgxjb21tb24ucHJvdG8SBnN0cmVhbSI+CghBdWRpZW5jZRIOCgZ1c2VySUQY",
            "ASABKA0SDwoHcHJvZmlsZRgCIAEoDBIRCgllbnRlclRpbWUYAyABKA0ixgEK",
            "DUxpdmVXYXRjaEluZm8SEgoGcm9vbUlEGAEgASgEQgIwARITCgdzdGFydFRT",
            "GAIgASgEQgIwARIPCgdkZWxheU1TGAMgASgNEg8KB2NhY2hlTVMYBCABKA0S",
            "FAoMbWF4QXVkaWVuY2VzGAUgASgNEhQKDGN1ckF1ZGllbmNlcxgGIAEoDRIV",
            "Cg1wZWFrQXVkaWVuY2VzGAcgASgNEicKDWxhc3RBdWRpZW5jZXMYCCADKAsy",
            "EC5zdHJlYW0uQXVkaWVuY2UikgEKC1dhdGNoUGFyYW1zEhAKCGNhbldhdGNo",
            "GAEgASgIEhQKDG1heEF1ZGllbmNlcxgCIAEoDRIPCgdkZWxheU1TGAMgASgN",
            "Eg8KB2NhY2hlTVMYBCABKA0SEwoLYnVmZmVyQnl0ZXMYBSABKA0SEAoIbGFz",
            "dFNpemUYBiABKA0SEgoKbmVlZFJlcGxheRgHIAEoCCJfCg1XYXRjaEJvb2tJ",
            "bmZvEg4KBmJvb2tJRBgBIAEoCRIOCgZ0aWNrZXQYAiABKAkSDQoFc2V0SUQY",
            "AyABKA0SDQoFbGl2ZXMYBCADKAkSEAoId3NzUHJveHkYBSABKAlCCqoCB01h",
            "dGNodnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Matchvs.Audience), global::Matchvs.Audience.Parser, new[]{ "UserID", "Profile", "EnterTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Matchvs.LiveWatchInfo), global::Matchvs.LiveWatchInfo.Parser, new[]{ "RoomID", "StartTS", "DelayMS", "CacheMS", "MaxAudiences", "CurAudiences", "PeakAudiences", "LastAudiences" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Matchvs.WatchParams), global::Matchvs.WatchParams.Parser, new[]{ "CanWatch", "MaxAudiences", "DelayMS", "CacheMS", "BufferBytes", "LastSize", "NeedReplay" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Matchvs.WatchBookInfo), global::Matchvs.WatchBookInfo.Parser, new[]{ "BookID", "Ticket", "SetID", "Lives", "WssProxy" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Audience : pb::IMessage<Audience> {
    private static readonly pb::MessageParser<Audience> _parser = new pb::MessageParser<Audience>(() => new Audience());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Audience> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Matchvs.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Audience() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Audience(Audience other) : this() {
      userID_ = other.userID_;
      profile_ = other.profile_;
      enterTime_ = other.enterTime_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Audience Clone() {
      return new Audience(this);
    }

    /// <summary>Field number for the "userID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private uint userID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UserID {
      get { return userID_; }
      set {
        userID_ = value;
      }
    }

    /// <summary>Field number for the "profile" field.</summary>
    public const int ProfileFieldNumber = 2;
    private pb::ByteString profile_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Profile {
      get { return profile_; }
      set {
        profile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enterTime" field.</summary>
    public const int EnterTimeFieldNumber = 3;
    private uint enterTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint EnterTime {
      get { return enterTime_; }
      set {
        enterTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Audience);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Audience other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserID != other.UserID) return false;
      if (Profile != other.Profile) return false;
      if (EnterTime != other.EnterTime) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID != 0) hash ^= UserID.GetHashCode();
      if (Profile.Length != 0) hash ^= Profile.GetHashCode();
      if (EnterTime != 0) hash ^= EnterTime.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserID != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UserID);
      }
      if (Profile.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Profile);
      }
      if (EnterTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EnterTime);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserID);
      }
      if (Profile.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Profile);
      }
      if (EnterTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterTime);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Audience other) {
      if (other == null) {
        return;
      }
      if (other.UserID != 0) {
        UserID = other.UserID;
      }
      if (other.Profile.Length != 0) {
        Profile = other.Profile;
      }
      if (other.EnterTime != 0) {
        EnterTime = other.EnterTime;
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
            UserID = input.ReadUInt32();
            break;
          }
          case 18: {
            Profile = input.ReadBytes();
            break;
          }
          case 24: {
            EnterTime = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LiveWatchInfo : pb::IMessage<LiveWatchInfo> {
    private static readonly pb::MessageParser<LiveWatchInfo> _parser = new pb::MessageParser<LiveWatchInfo>(() => new LiveWatchInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LiveWatchInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Matchvs.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveWatchInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveWatchInfo(LiveWatchInfo other) : this() {
      roomID_ = other.roomID_;
      startTS_ = other.startTS_;
      delayMS_ = other.delayMS_;
      cacheMS_ = other.cacheMS_;
      maxAudiences_ = other.maxAudiences_;
      curAudiences_ = other.curAudiences_;
      peakAudiences_ = other.peakAudiences_;
      lastAudiences_ = other.lastAudiences_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveWatchInfo Clone() {
      return new LiveWatchInfo(this);
    }

    /// <summary>Field number for the "roomID" field.</summary>
    public const int RoomIDFieldNumber = 1;
    private ulong roomID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RoomID {
      get { return roomID_; }
      set {
        roomID_ = value;
      }
    }

    /// <summary>Field number for the "startTS" field.</summary>
    public const int StartTSFieldNumber = 2;
    private ulong startTS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong StartTS {
      get { return startTS_; }
      set {
        startTS_ = value;
      }
    }

    /// <summary>Field number for the "delayMS" field.</summary>
    public const int DelayMSFieldNumber = 3;
    private uint delayMS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DelayMS {
      get { return delayMS_; }
      set {
        delayMS_ = value;
      }
    }

    /// <summary>Field number for the "cacheMS" field.</summary>
    public const int CacheMSFieldNumber = 4;
    private uint cacheMS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CacheMS {
      get { return cacheMS_; }
      set {
        cacheMS_ = value;
      }
    }

    /// <summary>Field number for the "maxAudiences" field.</summary>
    public const int MaxAudiencesFieldNumber = 5;
    private uint maxAudiences_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MaxAudiences {
      get { return maxAudiences_; }
      set {
        maxAudiences_ = value;
      }
    }

    /// <summary>Field number for the "curAudiences" field.</summary>
    public const int CurAudiencesFieldNumber = 6;
    private uint curAudiences_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CurAudiences {
      get { return curAudiences_; }
      set {
        curAudiences_ = value;
      }
    }

    /// <summary>Field number for the "peakAudiences" field.</summary>
    public const int PeakAudiencesFieldNumber = 7;
    private uint peakAudiences_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint PeakAudiences {
      get { return peakAudiences_; }
      set {
        peakAudiences_ = value;
      }
    }

    /// <summary>Field number for the "lastAudiences" field.</summary>
    public const int LastAudiencesFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Matchvs.Audience> _repeated_lastAudiences_codec
        = pb::FieldCodec.ForMessage(66, global::Matchvs.Audience.Parser);
    private readonly pbc::RepeatedField<global::Matchvs.Audience> lastAudiences_ = new pbc::RepeatedField<global::Matchvs.Audience>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Matchvs.Audience> LastAudiences {
      get { return lastAudiences_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LiveWatchInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LiveWatchInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomID != other.RoomID) return false;
      if (StartTS != other.StartTS) return false;
      if (DelayMS != other.DelayMS) return false;
      if (CacheMS != other.CacheMS) return false;
      if (MaxAudiences != other.MaxAudiences) return false;
      if (CurAudiences != other.CurAudiences) return false;
      if (PeakAudiences != other.PeakAudiences) return false;
      if(!lastAudiences_.Equals(other.lastAudiences_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomID != 0UL) hash ^= RoomID.GetHashCode();
      if (StartTS != 0UL) hash ^= StartTS.GetHashCode();
      if (DelayMS != 0) hash ^= DelayMS.GetHashCode();
      if (CacheMS != 0) hash ^= CacheMS.GetHashCode();
      if (MaxAudiences != 0) hash ^= MaxAudiences.GetHashCode();
      if (CurAudiences != 0) hash ^= CurAudiences.GetHashCode();
      if (PeakAudiences != 0) hash ^= PeakAudiences.GetHashCode();
      hash ^= lastAudiences_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomID != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(RoomID);
      }
      if (StartTS != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(StartTS);
      }
      if (DelayMS != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DelayMS);
      }
      if (CacheMS != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CacheMS);
      }
      if (MaxAudiences != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxAudiences);
      }
      if (CurAudiences != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurAudiences);
      }
      if (PeakAudiences != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PeakAudiences);
      }
      lastAudiences_.WriteTo(output, _repeated_lastAudiences_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RoomID);
      }
      if (StartTS != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(StartTS);
      }
      if (DelayMS != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DelayMS);
      }
      if (CacheMS != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CacheMS);
      }
      if (MaxAudiences != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxAudiences);
      }
      if (CurAudiences != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurAudiences);
      }
      if (PeakAudiences != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PeakAudiences);
      }
      size += lastAudiences_.CalculateSize(_repeated_lastAudiences_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LiveWatchInfo other) {
      if (other == null) {
        return;
      }
      if (other.RoomID != 0UL) {
        RoomID = other.RoomID;
      }
      if (other.StartTS != 0UL) {
        StartTS = other.StartTS;
      }
      if (other.DelayMS != 0) {
        DelayMS = other.DelayMS;
      }
      if (other.CacheMS != 0) {
        CacheMS = other.CacheMS;
      }
      if (other.MaxAudiences != 0) {
        MaxAudiences = other.MaxAudiences;
      }
      if (other.CurAudiences != 0) {
        CurAudiences = other.CurAudiences;
      }
      if (other.PeakAudiences != 0) {
        PeakAudiences = other.PeakAudiences;
      }
      lastAudiences_.Add(other.lastAudiences_);
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
            RoomID = input.ReadUInt64();
            break;
          }
          case 16: {
            StartTS = input.ReadUInt64();
            break;
          }
          case 24: {
            DelayMS = input.ReadUInt32();
            break;
          }
          case 32: {
            CacheMS = input.ReadUInt32();
            break;
          }
          case 40: {
            MaxAudiences = input.ReadUInt32();
            break;
          }
          case 48: {
            CurAudiences = input.ReadUInt32();
            break;
          }
          case 56: {
            PeakAudiences = input.ReadUInt32();
            break;
          }
          case 66: {
            lastAudiences_.AddEntriesFrom(input, _repeated_lastAudiences_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class WatchParams : pb::IMessage<WatchParams> {
    private static readonly pb::MessageParser<WatchParams> _parser = new pb::MessageParser<WatchParams>(() => new WatchParams());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WatchParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Matchvs.CommonReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchParams(WatchParams other) : this() {
      canWatch_ = other.canWatch_;
      maxAudiences_ = other.maxAudiences_;
      delayMS_ = other.delayMS_;
      cacheMS_ = other.cacheMS_;
      bufferBytes_ = other.bufferBytes_;
      lastSize_ = other.lastSize_;
      needReplay_ = other.needReplay_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchParams Clone() {
      return new WatchParams(this);
    }

    /// <summary>Field number for the "canWatch" field.</summary>
    public const int CanWatchFieldNumber = 1;
    private bool canWatch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CanWatch {
      get { return canWatch_; }
      set {
        canWatch_ = value;
      }
    }

    /// <summary>Field number for the "maxAudiences" field.</summary>
    public const int MaxAudiencesFieldNumber = 2;
    private uint maxAudiences_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MaxAudiences {
      get { return maxAudiences_; }
      set {
        maxAudiences_ = value;
      }
    }

    /// <summary>Field number for the "delayMS" field.</summary>
    public const int DelayMSFieldNumber = 3;
    private uint delayMS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DelayMS {
      get { return delayMS_; }
      set {
        delayMS_ = value;
      }
    }

    /// <summary>Field number for the "cacheMS" field.</summary>
    public const int CacheMSFieldNumber = 4;
    private uint cacheMS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CacheMS {
      get { return cacheMS_; }
      set {
        cacheMS_ = value;
      }
    }

    /// <summary>Field number for the "bufferBytes" field.</summary>
    public const int BufferBytesFieldNumber = 5;
    private uint bufferBytes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint BufferBytes {
      get { return bufferBytes_; }
      set {
        bufferBytes_ = value;
      }
    }

    /// <summary>Field number for the "lastSize" field.</summary>
    public const int LastSizeFieldNumber = 6;
    private uint lastSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint LastSize {
      get { return lastSize_; }
      set {
        lastSize_ = value;
      }
    }

    /// <summary>Field number for the "needReplay" field.</summary>
    public const int NeedReplayFieldNumber = 7;
    private bool needReplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NeedReplay {
      get { return needReplay_; }
      set {
        needReplay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WatchParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WatchParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CanWatch != other.CanWatch) return false;
      if (MaxAudiences != other.MaxAudiences) return false;
      if (DelayMS != other.DelayMS) return false;
      if (CacheMS != other.CacheMS) return false;
      if (BufferBytes != other.BufferBytes) return false;
      if (LastSize != other.LastSize) return false;
      if (NeedReplay != other.NeedReplay) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CanWatch != false) hash ^= CanWatch.GetHashCode();
      if (MaxAudiences != 0) hash ^= MaxAudiences.GetHashCode();
      if (DelayMS != 0) hash ^= DelayMS.GetHashCode();
      if (CacheMS != 0) hash ^= CacheMS.GetHashCode();
      if (BufferBytes != 0) hash ^= BufferBytes.GetHashCode();
      if (LastSize != 0) hash ^= LastSize.GetHashCode();
      if (NeedReplay != false) hash ^= NeedReplay.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CanWatch != false) {
        output.WriteRawTag(8);
        output.WriteBool(CanWatch);
      }
      if (MaxAudiences != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaxAudiences);
      }
      if (DelayMS != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DelayMS);
      }
      if (CacheMS != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CacheMS);
      }
      if (BufferBytes != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BufferBytes);
      }
      if (LastSize != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastSize);
      }
      if (NeedReplay != false) {
        output.WriteRawTag(56);
        output.WriteBool(NeedReplay);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CanWatch != false) {
        size += 1 + 1;
      }
      if (MaxAudiences != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxAudiences);
      }
      if (DelayMS != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DelayMS);
      }
      if (CacheMS != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CacheMS);
      }
      if (BufferBytes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BufferBytes);
      }
      if (LastSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastSize);
      }
      if (NeedReplay != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WatchParams other) {
      if (other == null) {
        return;
      }
      if (other.CanWatch != false) {
        CanWatch = other.CanWatch;
      }
      if (other.MaxAudiences != 0) {
        MaxAudiences = other.MaxAudiences;
      }
      if (other.DelayMS != 0) {
        DelayMS = other.DelayMS;
      }
      if (other.CacheMS != 0) {
        CacheMS = other.CacheMS;
      }
      if (other.BufferBytes != 0) {
        BufferBytes = other.BufferBytes;
      }
      if (other.LastSize != 0) {
        LastSize = other.LastSize;
      }
      if (other.NeedReplay != false) {
        NeedReplay = other.NeedReplay;
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
            CanWatch = input.ReadBool();
            break;
          }
          case 16: {
            MaxAudiences = input.ReadUInt32();
            break;
          }
          case 24: {
            DelayMS = input.ReadUInt32();
            break;
          }
          case 32: {
            CacheMS = input.ReadUInt32();
            break;
          }
          case 40: {
            BufferBytes = input.ReadUInt32();
            break;
          }
          case 48: {
            LastSize = input.ReadUInt32();
            break;
          }
          case 56: {
            NeedReplay = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class WatchBookInfo : pb::IMessage<WatchBookInfo> {
    private static readonly pb::MessageParser<WatchBookInfo> _parser = new pb::MessageParser<WatchBookInfo>(() => new WatchBookInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WatchBookInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Matchvs.CommonReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchBookInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchBookInfo(WatchBookInfo other) : this() {
      bookID_ = other.bookID_;
      ticket_ = other.ticket_;
      setID_ = other.setID_;
      lives_ = other.lives_.Clone();
      wssProxy_ = other.wssProxy_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WatchBookInfo Clone() {
      return new WatchBookInfo(this);
    }

    /// <summary>Field number for the "bookID" field.</summary>
    public const int BookIDFieldNumber = 1;
    private string bookID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BookID {
      get { return bookID_; }
      set {
        bookID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ticket" field.</summary>
    public const int TicketFieldNumber = 2;
    private string ticket_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ticket {
      get { return ticket_; }
      set {
        ticket_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "setID" field.</summary>
    public const int SetIDFieldNumber = 3;
    private uint setID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SetID {
      get { return setID_; }
      set {
        setID_ = value;
      }
    }

    /// <summary>Field number for the "lives" field.</summary>
    public const int LivesFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_lives_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> lives_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Lives {
      get { return lives_; }
    }

    /// <summary>Field number for the "wssProxy" field.</summary>
    public const int WssProxyFieldNumber = 5;
    private string wssProxy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WssProxy {
      get { return wssProxy_; }
      set {
        wssProxy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WatchBookInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WatchBookInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BookID != other.BookID) return false;
      if (Ticket != other.Ticket) return false;
      if (SetID != other.SetID) return false;
      if(!lives_.Equals(other.lives_)) return false;
      if (WssProxy != other.WssProxy) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BookID.Length != 0) hash ^= BookID.GetHashCode();
      if (Ticket.Length != 0) hash ^= Ticket.GetHashCode();
      if (SetID != 0) hash ^= SetID.GetHashCode();
      hash ^= lives_.GetHashCode();
      if (WssProxy.Length != 0) hash ^= WssProxy.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BookID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BookID);
      }
      if (Ticket.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Ticket);
      }
      if (SetID != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SetID);
      }
      lives_.WriteTo(output, _repeated_lives_codec);
      if (WssProxy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(WssProxy);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BookID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BookID);
      }
      if (Ticket.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ticket);
      }
      if (SetID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SetID);
      }
      size += lives_.CalculateSize(_repeated_lives_codec);
      if (WssProxy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WssProxy);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WatchBookInfo other) {
      if (other == null) {
        return;
      }
      if (other.BookID.Length != 0) {
        BookID = other.BookID;
      }
      if (other.Ticket.Length != 0) {
        Ticket = other.Ticket;
      }
      if (other.SetID != 0) {
        SetID = other.SetID;
      }
      lives_.Add(other.lives_);
      if (other.WssProxy.Length != 0) {
        WssProxy = other.WssProxy;
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
          case 10: {
            BookID = input.ReadString();
            break;
          }
          case 18: {
            Ticket = input.ReadString();
            break;
          }
          case 24: {
            SetID = input.ReadUInt32();
            break;
          }
          case 34: {
            lives_.AddEntriesFrom(input, _repeated_lives_codec);
            break;
          }
          case 42: {
            WssProxy = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
