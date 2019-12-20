
using System.Runtime.Serialization;

[DataContract]
public class RoomState {
    [DataMember]
    public int ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public RoomSettings RoomSettings { get; set; }
    [DataMember]
    public GameMode gameModes { get; set; }
    [DataMember]
    public int currentNumberOfPlayers { get; set; }
    [DataMember]
    public int maxNumberOfPlayers { get; set; }
}
