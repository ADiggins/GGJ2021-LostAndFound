using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Zone : MonoBehaviour
{
    public bool finished = false;
    public GameObject Player;
    private TimedText tt;

    private void Awake()
    {
        if (Player.GetComponent<TimedText>())
            tt = Player.GetComponent<TimedText>();
    }

    public void Finish()
    {
        if (finished == true)
        {
            if (tt != null)
            {
                tt.ShowText("Congradulations, you have been successfully adopted", 5.0f);
            }
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
