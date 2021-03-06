// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: lesson2/messages-features.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace My.Person {

  /// <summary>Holder for reflection information generated from lesson2/messages-features.proto</summary>
  public static partial class MessagesFeaturesReflection {

    #region Descriptor
    /// <summary>File descriptor for lesson2/messages-features.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessagesFeaturesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9sZXNzb24yL21lc3NhZ2VzLWZlYXR1cmVzLnByb3RvEglteS5wZXJzb24a",
            "HGxlc3NvbjIvaW1wb3J0LWV4YW1wbGUucHJvdG8igwIKBlBlcnNvbhISCgpm",
            "aXJzdF9uYW1lGAEgASgJEhQKDG1pZGRsZV9uYW1lcxgCIAMoCRIRCglsYXN0",
            "X25hbWUYAyABKAkSIgoLYmVhcnRoX2RhdGUYBCABKAsyDS5teS5kYXRlLkRh",
            "dGUSLAoJYWRkcmVzc2VzGAUgAygLMhkubXkucGVyc29uLlBlcnNvbi5BZGRy",
            "ZXNzGmoKB0FkZHJlc3MSFgoOYWRkcmVzc19saW5lXzEYASABKAkSFgoOYWRk",
            "cmVzc19saW5lXzIYAiABKAkSEAoIemlwX2NvZGUYAyABKAkSDAoEY2l0eRgE",
            "IAEoCRIPCgdjb3VudHJ5GAUgASgJIk8KBU1vbmV5EhUKDWN1cnJlbmN5X2Nv",
            "ZGUYASABKAkSFwoPaW50ZWdyYWxfYW1vdW50GAIgASgDEhYKDmRlY2ltYWxf",
            "YW1vdW50GAMgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::My.Date.ImportExampleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::My.Person.Person), global::My.Person.Person.Parser, new[]{ "FirstName", "MiddleNames", "LastName", "BearthDate", "Addresses" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::My.Person.Person.Types.Address), global::My.Person.Person.Types.Address.Parser, new[]{ "AddressLine1", "AddressLine2", "ZipCode", "City", "Country" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::My.Person.Money), global::My.Person.Money.Parser, new[]{ "CurrencyCode", "IntegralAmount", "DecimalAmount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Person : pb::IMessage<Person>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::My.Person.MessagesFeaturesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Person(Person other) : this() {
      firstName_ = other.firstName_;
      middleNames_ = other.middleNames_.Clone();
      lastName_ = other.lastName_;
      bearthDate_ = other.bearthDate_ != null ? other.bearthDate_.Clone() : null;
      addresses_ = other.addresses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 1;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "middle_names" field.</summary>
    public const int MiddleNamesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_middleNames_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> middleNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> MiddleNames {
      get { return middleNames_; }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bearth_date" field.</summary>
    public const int BearthDateFieldNumber = 4;
    private global::My.Date.Date bearthDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::My.Date.Date BearthDate {
      get { return bearthDate_; }
      set {
        bearthDate_ = value;
      }
    }

    /// <summary>Field number for the "addresses" field.</summary>
    public const int AddressesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::My.Person.Person.Types.Address> _repeated_addresses_codec
        = pb::FieldCodec.ForMessage(42, global::My.Person.Person.Types.Address.Parser);
    private readonly pbc::RepeatedField<global::My.Person.Person.Types.Address> addresses_ = new pbc::RepeatedField<global::My.Person.Person.Types.Address>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::My.Person.Person.Types.Address> Addresses {
      get { return addresses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstName != other.FirstName) return false;
      if(!middleNames_.Equals(other.middleNames_)) return false;
      if (LastName != other.LastName) return false;
      if (!object.Equals(BearthDate, other.BearthDate)) return false;
      if(!addresses_.Equals(other.addresses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      hash ^= middleNames_.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (bearthDate_ != null) hash ^= BearthDate.GetHashCode();
      hash ^= addresses_.GetHashCode();
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
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      middleNames_.WriteTo(output, _repeated_middleNames_codec);
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (bearthDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BearthDate);
      }
      addresses_.WriteTo(output, _repeated_addresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      middleNames_.WriteTo(ref output, _repeated_middleNames_codec);
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (bearthDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BearthDate);
      }
      addresses_.WriteTo(ref output, _repeated_addresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      size += middleNames_.CalculateSize(_repeated_middleNames_codec);
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (bearthDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BearthDate);
      }
      size += addresses_.CalculateSize(_repeated_addresses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      middleNames_.Add(other.middleNames_);
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.bearthDate_ != null) {
        if (bearthDate_ == null) {
          BearthDate = new global::My.Date.Date();
        }
        BearthDate.MergeFrom(other.BearthDate);
      }
      addresses_.Add(other.addresses_);
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            middleNames_.AddEntriesFrom(input, _repeated_middleNames_codec);
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            if (bearthDate_ == null) {
              BearthDate = new global::My.Date.Date();
            }
            input.ReadMessage(BearthDate);
            break;
          }
          case 42: {
            addresses_.AddEntriesFrom(input, _repeated_addresses_codec);
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            middleNames_.AddEntriesFrom(ref input, _repeated_middleNames_codec);
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            if (bearthDate_ == null) {
              BearthDate = new global::My.Date.Date();
            }
            input.ReadMessage(BearthDate);
            break;
          }
          case 42: {
            addresses_.AddEntriesFrom(ref input, _repeated_addresses_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// full type will be Person.Address
      /// </summary>
      public sealed partial class Address : pb::IMessage<Address>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Address> _parser = new pb::MessageParser<Address>(() => new Address());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Address> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::My.Person.Person.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Address() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Address(Address other) : this() {
          addressLine1_ = other.addressLine1_;
          addressLine2_ = other.addressLine2_;
          zipCode_ = other.zipCode_;
          city_ = other.city_;
          country_ = other.country_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Address Clone() {
          return new Address(this);
        }

        /// <summary>Field number for the "address_line_1" field.</summary>
        public const int AddressLine1FieldNumber = 1;
        private string addressLine1_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string AddressLine1 {
          get { return addressLine1_; }
          set {
            addressLine1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "address_line_2" field.</summary>
        public const int AddressLine2FieldNumber = 2;
        private string addressLine2_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string AddressLine2 {
          get { return addressLine2_; }
          set {
            addressLine2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "zip_code" field.</summary>
        public const int ZipCodeFieldNumber = 3;
        private string zipCode_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ZipCode {
          get { return zipCode_; }
          set {
            zipCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "city" field.</summary>
        public const int CityFieldNumber = 4;
        private string city_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string City {
          get { return city_; }
          set {
            city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "country" field.</summary>
        public const int CountryFieldNumber = 5;
        private string country_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Country {
          get { return country_; }
          set {
            country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Address);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Address other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (AddressLine1 != other.AddressLine1) return false;
          if (AddressLine2 != other.AddressLine2) return false;
          if (ZipCode != other.ZipCode) return false;
          if (City != other.City) return false;
          if (Country != other.Country) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (AddressLine1.Length != 0) hash ^= AddressLine1.GetHashCode();
          if (AddressLine2.Length != 0) hash ^= AddressLine2.GetHashCode();
          if (ZipCode.Length != 0) hash ^= ZipCode.GetHashCode();
          if (City.Length != 0) hash ^= City.GetHashCode();
          if (Country.Length != 0) hash ^= Country.GetHashCode();
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
          if (AddressLine1.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(AddressLine1);
          }
          if (AddressLine2.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(AddressLine2);
          }
          if (ZipCode.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ZipCode);
          }
          if (City.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(City);
          }
          if (Country.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Country);
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
          if (AddressLine1.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(AddressLine1);
          }
          if (AddressLine2.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(AddressLine2);
          }
          if (ZipCode.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ZipCode);
          }
          if (City.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(City);
          }
          if (Country.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Country);
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
          if (AddressLine1.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(AddressLine1);
          }
          if (AddressLine2.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(AddressLine2);
          }
          if (ZipCode.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ZipCode);
          }
          if (City.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
          }
          if (Country.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Address other) {
          if (other == null) {
            return;
          }
          if (other.AddressLine1.Length != 0) {
            AddressLine1 = other.AddressLine1;
          }
          if (other.AddressLine2.Length != 0) {
            AddressLine2 = other.AddressLine2;
          }
          if (other.ZipCode.Length != 0) {
            ZipCode = other.ZipCode;
          }
          if (other.City.Length != 0) {
            City = other.City;
          }
          if (other.Country.Length != 0) {
            Country = other.Country;
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
                AddressLine1 = input.ReadString();
                break;
              }
              case 18: {
                AddressLine2 = input.ReadString();
                break;
              }
              case 26: {
                ZipCode = input.ReadString();
                break;
              }
              case 34: {
                City = input.ReadString();
                break;
              }
              case 42: {
                Country = input.ReadString();
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
                AddressLine1 = input.ReadString();
                break;
              }
              case 18: {
                AddressLine2 = input.ReadString();
                break;
              }
              case 26: {
                ZipCode = input.ReadString();
                break;
              }
              case 34: {
                City = input.ReadString();
                break;
              }
              case 42: {
                Country = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  public sealed partial class Money : pb::IMessage<Money>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Money> _parser = new pb::MessageParser<Money>(() => new Money());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Money> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::My.Person.MessagesFeaturesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money(Money other) : this() {
      currencyCode_ = other.currencyCode_;
      integralAmount_ = other.integralAmount_;
      decimalAmount_ = other.decimalAmount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money Clone() {
      return new Money(this);
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 1;
    private string currencyCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "integral_amount" field.</summary>
    public const int IntegralAmountFieldNumber = 2;
    private long integralAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long IntegralAmount {
      get { return integralAmount_; }
      set {
        integralAmount_ = value;
      }
    }

    /// <summary>Field number for the "decimal_amount" field.</summary>
    public const int DecimalAmountFieldNumber = 3;
    private int decimalAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int DecimalAmount {
      get { return decimalAmount_; }
      set {
        decimalAmount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Money);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Money other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrencyCode != other.CurrencyCode) return false;
      if (IntegralAmount != other.IntegralAmount) return false;
      if (DecimalAmount != other.DecimalAmount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
      if (IntegralAmount != 0L) hash ^= IntegralAmount.GetHashCode();
      if (DecimalAmount != 0) hash ^= DecimalAmount.GetHashCode();
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
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrencyCode);
      }
      if (IntegralAmount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IntegralAmount);
      }
      if (DecimalAmount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(DecimalAmount);
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
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrencyCode);
      }
      if (IntegralAmount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IntegralAmount);
      }
      if (DecimalAmount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(DecimalAmount);
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
      if (CurrencyCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (IntegralAmount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IntegralAmount);
      }
      if (DecimalAmount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DecimalAmount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Money other) {
      if (other == null) {
        return;
      }
      if (other.CurrencyCode.Length != 0) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.IntegralAmount != 0L) {
        IntegralAmount = other.IntegralAmount;
      }
      if (other.DecimalAmount != 0) {
        DecimalAmount = other.DecimalAmount;
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
            CurrencyCode = input.ReadString();
            break;
          }
          case 16: {
            IntegralAmount = input.ReadInt64();
            break;
          }
          case 24: {
            DecimalAmount = input.ReadInt32();
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
            CurrencyCode = input.ReadString();
            break;
          }
          case 16: {
            IntegralAmount = input.ReadInt64();
            break;
          }
          case 24: {
            DecimalAmount = input.ReadInt32();
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
