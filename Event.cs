public class Event
{
    public int MoveNumber {get; set;}
    public string Description { get; set;}
    public string TypeOfEvent {get; set;}
    public int ChangeCharacteristic {get; set;}
    
    public Event(int moveNumber, string description, string typeOfEvent, int changeCharacteristic)
    {
        MoveNumber = moveNumber;
        Description = description;
        TypeOfEvent = typeOfEvent;
        ChangeCharacteristic = changeCharacteristic;
    }
}