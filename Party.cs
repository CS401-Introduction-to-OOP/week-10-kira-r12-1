using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Party: IEnumerable<Character>
{
    private List<Character> _characters = new List<Character>();

    public void Add(Character character)
    {
        _characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in _characters)
        {
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var character in _characters)
        {
            if (character.Status == "Active")
            {
                yield return character;
            }
        }
    }
    public IEnumerable<Character> GetCharactersBelowCertainValue(int certainValue)
    {
    foreach (var character in _characters)
    {
        if (character.Health < certainValue)
        {
            yield return character;
        }
    }
    }
    public IEnumerable<string> GetHeroNames()
    {
        return _characters.Select(ch => ch.Name);
    }
}