using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Dialog/Answer")]
public class Answer : ScriptableObject
{
	public string text;
    public Dialog dialog;
}
