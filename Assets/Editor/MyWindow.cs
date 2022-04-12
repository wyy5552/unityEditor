using UnityEngine;
using System.Collections;
using UnityEditor;		//注意要引用
public class MyWindow : EditorWindow
{
    [MenuItem("德玛/Window/MyWindow")]//在unity菜单Window下有MyWindow选项
    static void Init()
    {
        MyWindow myWindow = (MyWindow)EditorWindow.GetWindow(typeof(MyWindow), true, "德玛标题", true);//创建窗口
        myWindow.Show();//展示
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("选中");
        EditorGUILayout.LabelField(EditorWindow.focusedWindow.ToString());
        EditorGUILayout.LabelField("划入");
        EditorGUILayout.LabelField(EditorWindow.mouseOverWindow.ToString());
    }

    //OnDestroy() :关闭窗口时调用
    // OnFocus():窗口被选中时调用
    // OnLostFocus():窗口不再被选中时调用

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnFocus()
    {
        Debug.Log("OnFocus");
    }

    private void OnLostFocus()
    {
        Debug.Log("OnLostFocus");
    }

    void OnInspectorUpdate()
    {
        //Debug.Log("窗口面板的更新");
        //这里开启窗口的重绘，不然窗口信息不会刷新
        this.Repaint();
    }
}