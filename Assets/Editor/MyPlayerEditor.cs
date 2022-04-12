using UnityEngine;
using UnityEditor;
using System.Collections;
[CustomEditor(typeof(MyPlayer))]
public class MyPlayerEditor : Editor
{
    SerializedProperty attack;
    void OnEnable()
    {
        attack = serializedObject.FindProperty("attack");
    }
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.IntSlider(attack, 0, 100, new GUIContent("攻击力"));
        ProgressBar(attack.intValue / 100, "攻击力");
        serializedObject.ApplyModifiedProperties();
    }
    private void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }
}

//using UnityEngine;
//using UnityEditor;
//using System.Collections;

//[CustomEditor(typeof(MyPlayer))]
//public class MyPlayerEditor : Editor
//{
//    [System.Obsolete]
//    public override void OnInspectorGUI()
//    {
//        var target = (MyPlayer)(serializedObject.targetObject);
//        target.attack = EditorGUILayout.IntSlider("攻击力", target.attack, 0, 100);
//        ProgressBar(target.attack, "攻击力");

//        target.equipment = (GameObject)EditorGUILayout.ObjectField("装备", target.equipment, typeof(GameObject));
//    }
//    private void ProgressBar(float value, string label)
//    {
//        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
//        EditorGUI.ProgressBar(rect, value, label);
//        EditorGUILayout.Space();
//    }
//}
