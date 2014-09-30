/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace LINE.Datatypes
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SystemConfiguration : TBase
  {
    private string _endpoint;
    private string _endpointSsl;
    private string _updateUrl;
    private string _c2dmAccount;
    private string _nniServer;

    public string Endpoint
    {
      get
      {
        return _endpoint;
      }
      set
      {
        __isset.endpoint = true;
        this._endpoint = value;
      }
    }

    public string EndpointSsl
    {
      get
      {
        return _endpointSsl;
      }
      set
      {
        __isset.endpointSsl = true;
        this._endpointSsl = value;
      }
    }

    public string UpdateUrl
    {
      get
      {
        return _updateUrl;
      }
      set
      {
        __isset.updateUrl = true;
        this._updateUrl = value;
      }
    }

    public string C2dmAccount
    {
      get
      {
        return _c2dmAccount;
      }
      set
      {
        __isset.c2dmAccount = true;
        this._c2dmAccount = value;
      }
    }

    public string NniServer
    {
      get
      {
        return _nniServer;
      }
      set
      {
        __isset.nniServer = true;
        this._nniServer = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool endpoint;
      public bool endpointSsl;
      public bool updateUrl;
      public bool c2dmAccount;
      public bool nniServer;
    }

    public SystemConfiguration() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Endpoint = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              EndpointSsl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              UpdateUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              C2dmAccount = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              NniServer = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SystemConfiguration");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Endpoint != null && __isset.endpoint) {
        field.Name = "endpoint";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Endpoint);
        oprot.WriteFieldEnd();
      }
      if (EndpointSsl != null && __isset.endpointSsl) {
        field.Name = "endpointSsl";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(EndpointSsl);
        oprot.WriteFieldEnd();
      }
      if (UpdateUrl != null && __isset.updateUrl) {
        field.Name = "updateUrl";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(UpdateUrl);
        oprot.WriteFieldEnd();
      }
      if (C2dmAccount != null && __isset.c2dmAccount) {
        field.Name = "c2dmAccount";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(C2dmAccount);
        oprot.WriteFieldEnd();
      }
      if (NniServer != null && __isset.nniServer) {
        field.Name = "nniServer";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NniServer);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SystemConfiguration(");
      sb.Append("Endpoint: ");
      sb.Append(Endpoint);
      sb.Append(",EndpointSsl: ");
      sb.Append(EndpointSsl);
      sb.Append(",UpdateUrl: ");
      sb.Append(UpdateUrl);
      sb.Append(",C2dmAccount: ");
      sb.Append(C2dmAccount);
      sb.Append(",NniServer: ");
      sb.Append(NniServer);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
