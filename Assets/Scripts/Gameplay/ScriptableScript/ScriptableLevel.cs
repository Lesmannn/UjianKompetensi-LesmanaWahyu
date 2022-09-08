using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableLevel : ScriptableObject
{
	public string question;
	public string[] answer;
	public Sprite hintImage;
	public int indexCorrect;
	private bool firstTime;
}