using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{

    private static readonly string MAT_PARAM_FILL = "_Fill";

    private Material progressBarMat;
    private void Awake()
    {
        progressBarMat = GetComponent<Renderer>().material;
    }

    public void SetCompletion(float completion)
    {
        progressBarMat.SetFloat(MAT_PARAM_FILL, completion);
    }

}
