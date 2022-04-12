using UnityEngine;

// 通过编辑器的Component菜单添加脚本
[RequireComponent(typeof(Rigidbody))]
[HelpURL("https://docs.unity3d.com/ScriptReference/HelpURLAttribute.html")]
[AddComponentMenu("德玛/添加德玛脚本")]
public class ContextTesting : MonoBehaviour
{
    [Header("属性标题")]
    [Multiline(3)]
    public string name2;

    [Space(100)]
    [Tooltip("用于设置性别")]
    public string sex;

    [HideInInspector]
    public int p = 5;

    [Range(1, 100)]
    [Tooltip("Health value between 0 and 100.")]
    public int health = 0;

    /// Add a context menu named "Do Something" in the inspector
    /// of the attached script.
    /// 给当前脚本添加右键内容
    [ContextMenu("德玛西亚")]
    void DoSomething()
    {
        Debug.Log("德玛西亚打印");
    }

    // 给属性添加右键
    [ContextMenuItem("重置属性为空", "ResetBiography")]
    public string playerBiography = "";
    void ResetBiography()
    {
        playerBiography = "";
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}