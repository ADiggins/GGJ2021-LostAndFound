using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedText : MonoBehaviour
{
	[SerializeField]
	private PromptFollowPlayer playerPromptUI;
	//public string content;
	//public float timer;

	private float timeSync;

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ShowText(string c, float t)
	{
		playerPromptUI.DisplayPrompt(c);
		Invoke("HideText", t);
	}

	public void HideText()
	{
		playerPromptUI.Clear();
	}
}
