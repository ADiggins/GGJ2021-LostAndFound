using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Zone : MonoBehaviour
{
    public bool finished = false;
    public GameObject Player;
    private TimedText tt;

    public Animator endGameAnimator;

    private void Awake()
    {
        if (Player.GetComponent<TimedText>())
            tt = Player.GetComponent<TimedText>();
    }

    public void Finish()
    {
        if (finished == true)
        {
            endGameAnimator.SetTrigger("End");
        }

        else
        {
            if (tt != null)
            {
                tt.ShowText("You are not appealing enough to be adopted yet", 5.0f);
            }
        }
    }
}
