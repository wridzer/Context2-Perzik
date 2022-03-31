using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JSONReader
{
    public static List<string> GetDialogue(string _name)
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("Dialogue/" + _name);
        Dialogues dialoguesInJson = JsonUtility.FromJson<Dialogues>(jsonFile.text);
        List<string> lines = new List<string>();

        foreach (Line line in dialoguesInJson.dialogues)
        {
            lines.Add(line.line);
        }

        if(lines.Count == 0)
        {
            lines.Add("Designer probably made a typo in the JSON file or the NPC name for NPC: ");
            lines.Add(_name);
            Debug.LogError("Designer probably made a typo in the JSON file or the NPC name for NPC: " + _name);
        }

        return lines;
    }
}
