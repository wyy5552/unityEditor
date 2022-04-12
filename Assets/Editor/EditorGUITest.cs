using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorGUITest : EditorWindow {

    public float f1 = 100.0f;
    public float f2 = 50.0f;

    Color matColor = Color.green;

    int cloneTimesX = 1;
    bool showClose = true;
    bool showToggleLeft = true;
    string textfieldtest = "textfieldtest";
    string password = "pwd123456";

    float minVal = -10.0f;
    float minLimit = -20.0f;
    float maxVal = 10.0f;
    float maxLimit = 20.0f;

    AnimationCurve curveX = AnimationCurve.Linear(0, 0, 1, 0);
    AnimationCurve curveY = AnimationCurve.Linear(0, 0, 1, 1);
    AnimationCurve curveZ = AnimationCurve.Linear(0, 0, 1, 0);

    [MenuItem("德玛/Window/EditorGUITest")]
    static void Init()
    {
        EditorGUITest window = (EditorGUITest)EditorWindow.GetWindow(typeof(EditorGUITest));
        window.Show();
    }

    void OnGUI()
    {
        if (GUILayout.Button("Close"))
            this.Close();

        //是否开启禁用功能
        // Disable the jumping height control if canJump is false:
        EditorGUI.BeginDisabledGroup(false);        //false表示禁用关闭，true表示开启禁用--灰色状态
        f1 = EditorGUILayout.FloatField("FloatField", f1);
        EditorGUI.EndDisabledGroup();
        f2 = EditorGUILayout.FloatField("FloatField", f2);

        //Bounds输入框
        EditorGUILayout.BoundsField("BoundsField", new Bounds(new Vector3(50, 50, 50), new Vector3(150, 150, 150)));

        //带有阴影的Label
        EditorGUI.DropShadowLabel(new Rect(30, 120, position.width, 20), "China 带有阴影的Label");

        //Vector2 ~ Vector4
        EditorGUI.Vector2Field(new Rect(30, 140, position.width - 60, 20), "Vector2Field", new Vector2(2, 2));
        EditorGUI.Vector3Field(new Rect(30, 180, position.width - 60, 20), "Vector3Field", new Vector3(3, 3, 3));
        EditorGUI.Vector4Field(new Rect(30, 210, position.width - 60, 20), "Vector4Field", new Vector4(4, 4, 4, 4));

        //颜色选择框
        matColor = EditorGUI.ColorField(new Rect(0, 260, 250, 25), "颜色:", matColor);

        //动画曲线
        curveX = EditorGUI.CurveField(new Rect(3, 320, position.width - 6, 50), "Animation on X", curveX);
        curveY = EditorGUI.CurveField(new Rect(3, 370, position.width - 6, 50), "Animation on Y", curveY);
        curveZ = EditorGUI.CurveField(new Rect(3, 420, position.width - 6, 50), "Animation on Z", curveZ);

        //数字输入
        EditorGUI.DelayedDoubleField(new Rect(3, 480, position.width - 6, 20), "DelayedDoubleField1", 25.011);
        EditorGUI.DelayedFloatField(new Rect(3, 500, position.width - 6, 20), "DelayedFloatField", 25.4f);
        EditorGUI.DelayedIntField(new Rect(3, 520, position.width - 6, 20), "DelayedIntField", 25);
        EditorGUI.DelayedTextField(new Rect(3, 540, position.width - 6, 20), "DelayedTextField");

        //绘画矩形
        EditorGUI.DrawRect(new Rect(3, 570, position.width - 60, 20), Color.green);

        //输入框(值不能滑动): 注意左边必须要有值接收这个值，否则不能滑动
        cloneTimesX = EditorGUI.IntSlider(new Rect(3, 600, position.width - 60, 30), cloneTimesX, 0, 100);

        //帮助盒子信息框
        EditorGUI.HelpBox(new Rect(3, 645, position.width - 60, 40), "HelpBox帮助盒子", MessageType.Warning);

        //Toggle 开关
        showClose = EditorGUI.Toggle(new Rect(3, 685, position.width - 60, 20), "Toggle", showClose);
        //
        showToggleLeft = EditorGUI.ToggleLeft(new Rect(3, 710, position.width - 60, 20), "ToggleLeft", showToggleLeft);
        textfieldtest = EditorGUI.TextField(new Rect(3, 735, position.width - 60, 20), "TextField", textfieldtest);
        
        password = EditorGUI.PasswordField(new Rect(3, 760, position.width - 60, 20), "密码框:", password);

                //最大值和最小值滑块
        EditorGUI.MinMaxSlider(new Rect(3, 790, position.width - 60, 20), ref minVal, ref maxVal, minLimit, maxLimit);
    }

}
