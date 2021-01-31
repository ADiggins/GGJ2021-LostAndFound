using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Task", menuName = "Skunky/Task")]
public class CompletedTask : ScriptableObject
{
    public bool Completed;

    private void OnEnable()
    {
        Completed = false;
    }
}
