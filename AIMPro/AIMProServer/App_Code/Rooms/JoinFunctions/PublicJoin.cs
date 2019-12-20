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


}