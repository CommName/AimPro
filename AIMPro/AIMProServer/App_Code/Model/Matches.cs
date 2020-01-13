using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Matches
/// </summary>
public class Matches
{
    // TODO:: ADD match modes enum
    public int ID { get; set; }
    public ICollection<UserMatch> UserCollection  { get; set; }
    public int TypeOfMatch { get; set; }
    public int GameSeed { get; set; }
    public int TargetsUsed { get; set; }
    public int CursorUsed { get; set; }

}