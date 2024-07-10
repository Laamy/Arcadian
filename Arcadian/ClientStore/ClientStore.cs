using System.Collections.Generic;
using System.Security;

class ClientStore
{
    public List<ClientBase> Clients = new List<ClientBase>();

    //public override string ToString()
    //{
    //    string result = "ClientStore\n{\n\t[";
    //
    //    foreach (var client in Clients)
    //    {
    //        result += "\n\t\t{" +
    //            "\n\t\t\ttDownload:" + client.Download +
    //            "\n\t\t\tImage:" + client.Image +
    //            "\n\t\t\tName:" + client.Name +
    //            "\n\t\t\tVersion:" + client.Version + "\n\t\t}";
    //    }
    //
    //    result += "\n\t]\n}";
    //
    //    return result;
    //}
}