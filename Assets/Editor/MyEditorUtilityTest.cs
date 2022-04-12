using UnityEngine;
using UnityEditor;

public class MyEditorUtilityTest : ScriptableObject
{
    [MenuItem("德玛/自定义对话框")]
    static void CreateWizard()
    {
        if (EditorUtility.DisplayDialog("对话框标题", "对话框的消息", "OK", "取消"))
        {
            Debug.Log("OK被点击");
        }
        else
        {
            Debug.Log("您没有点击OK");
        }
    }
}