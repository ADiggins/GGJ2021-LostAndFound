using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedText : MonoBehaviour
{
	[SerializeField]
	private PromptFollowPlayer playerPromptUI;
	//public string content;
	//public float timer;

	private float timer;
	private string content;

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ShowText(string c, float t)
	{
		content = c;
		timer = t;
		Invoke("ShowText", 0.1f);
	}

	public void ShowText()
	{
		playerPromptUI.DisplayPrompt(content);
		Invoke("HideText", timer);
	}

	public void HideText()
	{
		playerPromptUI.Clear();
	}
}
