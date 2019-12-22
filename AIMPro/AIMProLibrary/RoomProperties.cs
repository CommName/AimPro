using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AIMProLibrary
{
    [DataContract]
    public class RoomProperties
    {
        [DataMember]
        public byte[] seed { get; set; }
        
        [DataMember]
        public GameMode GameMode { get; set; }
        
        [DataMember]
        public TargetTypes TargetTypesAllowed { get; set; }
        
        [DataMember]
        public CursorType CursorType { get; set; }

        [DataMember]
        public int maxPlayers { get; set; }

        [DataMember]
        public RoomSettings Settings { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public int numberOfTargets { get; set; }
        
        public RoomProperties()
        {
            this.GameMode = GameMode.None;
            this.TargetTypesAllowed = TargetTypes.None;
            this.CursorType = CursorType.None;
            this.Settings = RoomSettings.None;
            this.numberOfTargets = 20;
            this.Name = "Proba";
        }

    }
}
