using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PublicJoin
/// </summary>
public class PublicJoin : Room.JoinFunction 
{
    public PublicJoin(Room room)
    {
        this.room = room;
    }

    public PublicJoin(Room.JoinFunction parent) : base(parent)
    {

    }

    public override bool joinRoom(string player, ICallBackPlayer callback)
    {
        if (this.parent == null)
            return base.joinRoom(player, callback);
        else
            return this.parent.joinRoom(player, callback);
    }

}