using UnityEngine;
public class ContextTesting : MonoBehaviour
{
    /// Add a context menu named "Do Something" in the inspector
    /// of the attached script.
    /// 给当前脚本添加右键内容
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
}