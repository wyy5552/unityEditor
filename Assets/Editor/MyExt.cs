using UnityEditor;
using UnityEngine;

public class MyExt : EditorWindow
{
    private int param1 = -1;
    private float param2 = 0;
    private string testName = "";
    private int id = 0;

    [MenuItem("德玛/Window/Edit", false, 1)]
    private static void Init()
    {
        MyExt editor = (MyExt)EditorWindow.GetWindow(typeof(MyExt),true);
        editor.Show();
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField(EditorWindow.focusedWindow.ToString());
        GUILayout.Label("Section1", EditorStyles.boldLabel);
        param1 = EditorGUILayout.IntField("param1 int", param1);
        if (GUILayout.Button("Load"))
        {
            Debug.Log("Load");
        }

        GUILayout.Label("Section2", EditorStyles.boldLabel);
        param2 = EditorGUILayout.FloatField("param2 float", param2);
        testName = EditorGUILayout.TextField("testName", testName);
        id = EditorGUILayout.IntSlider("id 0~8", id, 0, 100);
    }
}