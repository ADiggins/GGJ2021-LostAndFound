using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Script : MonoBehaviour
{
    public bool finished = false;

    public void Finish()
    {
        if (finished == true)
        {
            Debug.Log("You have been adopted");
        }

        else
        {
            Debug.Log("You are not appealing enough to get adopted yet");
        }
    }
}
