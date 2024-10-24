using UnityEngine;

[CreateAssetMenu]
public class Dialogueasset : ScriptableObject
{

    [TextArea(3, 6)]
    public string[] dialogue;

}
