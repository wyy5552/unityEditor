using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    [ContextMenuItem("Reset", "ResetBiography")]
    [Multiline(8)]
    public string playerBiography = "";
    void ResetBiography()
    {
        playerBiography = "";
    }
}