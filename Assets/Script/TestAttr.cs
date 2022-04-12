using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
[HelpURL("https://docs.unity3d.com/ScriptReference/HelpURLAttribute.html")]
public class TestAttr : MonoBehaviour
{
    [HideInInspector]
    public int p = 5;
    [Tooltip("Health value between 0 and 100.")]
    public int health = 0;

    [Range(1,100)]
    [Tooltip("Health value between 0 and 100.")]
    public int health2 = 0;



    [Header("BaseInfo")]
    [Multiline(5)]
    public string name;
    [Range(-2, 2)]
    public int age;

    [Space(100)]
    [Tooltip("用于设置性别")]
    public string sex;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("德玛Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
}
