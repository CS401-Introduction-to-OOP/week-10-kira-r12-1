using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class EventLog: IEnumerable<Event>
{
    private List<Event> _events = new List<Event>();

    public void AddEvent(Event event_)
    {
        _events.Add(event_);
    }

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var event_ in _events)
        {
            yield return event_;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Event> СhronologicalEvents()
    {
        var sortedEvents = _events.OrderBy(ev => ev.MoveNumber);

        foreach (var event_ in sortedEvents)
        {
            yield return event_;
        }
    }
    public IEnumerable<Event> GetEventsByType(string eventType)
{
    foreach (var event_ in _events) 
    {
        if (event_.TypeOfEvent == eventType)
        {
            yield return event_;
        }
    }
}
}
