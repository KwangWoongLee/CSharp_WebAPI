using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CreateAccountPacketReq
{ 
    public string login_id { get; set; }
    public string password { get; set; }
    public string name { get; set; }
}

public class CreateAccountPacketRes
{ 
    public bool CreateOk { get; set; }
}

public class LoginAccountPacketReq
{
    public string login_id { get; set; }
    public string password { get; set; }
    public string name { get; set; }
}

public class ServerInfo
{
    public string Name { get; set; }
    public string Ip { get; set; }
}

public class LoginAccountPacketRes
{
    public bool LoginOk { get; set; }
    public List<ServerInfo> ServerList { get; set; } = new List<ServerInfo>();
}
