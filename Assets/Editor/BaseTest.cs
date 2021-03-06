using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BaseTest : MonoBehaviour
{
    [MenuItem("德玛/test")]
    static void debugLog()
    {
        Debug.Log("我是一个menuItem");
        Selection.selectionChanged += DidCallBackReturnTrue;
    }
    static void DidCallBackReturnTrue()
    {
        Debug.Log("选择物品改变");
    }
    // 设置第二个参数
    [MenuItem("德玛/two", false)]
    static void testSecondParam()
    {
        Vector3 p = Selection.activeTransform.position;
        Vector3 v3 = new Vector3(p.x+1, p.y, p.z);
        Instantiate(Selection.activeTransform, v3, Quaternion.identity);
    }
    [MenuItem("德玛/two", true)]
    static bool testSecondParam2()
    {
        return Selection.activeGameObject != null;
    }
    // 文件夹右键菜单
    [MenuItem("GameObject/德玛/德玛Custom Game Object", false, 10)]
    static void CreateCustomGameObject(MenuCommand menuCommand)
    {
        // Create a custom game object
        GameObject go = new GameObject("Custom Game Object");
        // Ensure it gets reparented if this was a context click (otherwise does nothing)
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }

    // 给inspector的component添加右键菜单
    [MenuItem("CONTEXT/Rigidbody/德玛")]
    static void DoSomething(MenuCommand command)
    {
        // Rigidbody body = (Rigidbody)command.context;
        Rigidbody body = (Rigidbody)command.context as Rigidbody;
        body.mass = 5;
        Debug.Log("Changed Rigidbody's Mass to " + body.mass + " from Context Menu...");
    }

    //添加菜单
    [MenuItem(@"德玛/获取选中的节点")]
    public static void GetTransforms()
    {
        Dictionary<string, Vector3> dic = new Dictionary<string, Vector3>();
        //transforms是Selection类的静态字段，其返回的是选中的对象的Transform数组
        Transform[] transforms = Selection.transforms;

        //将选中的对象的postion保存在字典中
        for (int i = 0; i < transforms.Length; i++)
        {
            dic.Add(transforms[i].name, transforms[i].position);
        }

        //将字典中的信息打印出来
        foreach (Transform item in transforms)
        {
            Debug.Log(item.name + ":" + item.position);
        }
    }

    [MenuItem("德玛/过滤选择")]
    static void debugSelections()
    {
        Object[] activeGos = Selection.GetFiltered(typeof(GameObject), SelectionMode.Editable | SelectionMode.TopLevel);
        for(int i = 0; i < activeGos.Length; i++)
        {
            Debug.Log(activeGos[i].name);
        }
    }


}
