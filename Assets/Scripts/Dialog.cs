using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Dialog", menuName = "Dialog/Dialogs")]
public class Dialog : ScriptableObject
{
    public string text;
    public List<Answer> answers;
    
}
