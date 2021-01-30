using System;
using UnityEngine;

[Serializable]
public class TrainingExercise
{


    [SerializeField]
    public KeyCode InteractionKey;

    [SerializeField]
    public float Duration;

    [SerializeField]
    [TextArea]
    public string PromptText;

}
