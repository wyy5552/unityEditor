
//using UnityEditor;
//using UnityEngine;

//[InitializeOnLoad]
//class InitOnLoadTest
//{
//    static InitOnLoadTest()
//    {
//        if (EditorUtility.DisplayDialog("对话框标题", "对话框的消息", "OK", "取消"))
//        {
//            //EditorApplication.update += Update;
//            Debug.Log("OK被点击");
//        }
//        else
//        {
//            Debug.Log("您没有点击OK");
//        }
       
//    }

//    static void Update()
//    {
//        Debug.Log("Updating");
//    }

//    [InitializeOnLoadMethod]
//    static void OnProjectLoadedInEditor()
//    {
//        Debug.Log("自动执行的函数Project loaded in Unity Editor");
//    }

//}
