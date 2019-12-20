[System.Flags]
public enum RoomSettings { 
    None = 0,
    Hidden = 1,
    PasswordProtected = 2 << 1,
    EloRestricted = 2 << 2,

}
