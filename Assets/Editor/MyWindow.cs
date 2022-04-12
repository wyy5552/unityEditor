using UnityEngine;
using System.Collections;
using UnityEditor;		//注意要引用
public class MyWindow : EditorWindow
{
	private static int windowType = 0;

    [MenuItem("德玛/Window/NormalWindow")]//在unity菜单Window下有MyWindow选项
    static void NormalWindow()
    {
		windowType = 1;
        MyWindow myWindow = (MyWindow)EditorWindow.GetWindow(typeof(MyWindow), true, "德玛标题", true);//创建窗口
        myWindow.Show();//展示
    }

	private int param1 = -1;
	private float param2 = 0;
	private string testName = "";
	private int id = 0;

	[MenuItem("德玛/Window/Edit", false, 1)]
	private static void Init()
	{
		windowType = 3;
		MyWindow editor = (MyWindow)EditorWindow.GetWindow(typeof(MyWindow), true);
		editor.Show();
	}

	//输入文字的内容
	private string text;
	//选择贴图的对象
	private Texture texture;

	[MenuItem("德玛/Window/RectWindow")]
	static void RectWindow()
	{
		windowType = 2;
		//创建窗口
		Rect wr = new Rect(0, 0, 500, 500);
		MyWindow window = (MyWindow)EditorWindow.GetWindowWithRect(typeof(MyWindow), wr, true, "widow name");
		window.Show();

	}

	public void Awake()
	{
		//在资源中读取一张贴图
		texture = Resources.Load("1") as Texture;
	}

	//绘制窗口时调用
	void OnGUI()
	{

		if(windowType == 1)
        {
			//输入框控件
			text = EditorGUILayout.TextField("输入文字:", text);

			if (GUILayout.Button("打开通知", GUILayout.Width(200)))
			{
				//打开一个通知栏
				this.ShowNotification(new GUIContent("This is a Notification"));
			}

			if (GUILayout.Button("关闭通知", GUILayout.Width(200)))
			{
				//关闭通知栏
				this.RemoveNotification();
			}

			//文本框显示鼠标在窗口的位置
			EditorGUILayout.LabelField("鼠标在窗口的位置", Event.current.mousePosition.ToString());

			//选择贴图
			texture = EditorGUILayout.ObjectField("添加贴图", texture, typeof(Texture), true) as Texture;

			if (GUILayout.Button("关闭窗口", GUILayout.Width(200)))
			{
				//关闭窗口
				this.Close();
			}
		}

		if (windowType == 2)
		{
			EditorGUILayout.LabelField("选中");
			EditorGUILayout.LabelField(EditorWindow.focusedWindow.ToString());
			EditorGUILayout.LabelField("划入");
			EditorGUILayout.LabelField(EditorWindow.mouseOverWindow.ToString());
			return;
		}


		if (windowType == 3)
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

	//更新
	void Update()
	{

	}

	void OnFocus()
	{
		Debug.Log("当窗口获得焦点时调用一次");
	}

	void OnLostFocus()
	{
		Debug.Log("当窗口丢失焦点时调用一次");
	}

	void OnHierarchyChange()
	{
		Debug.Log("当Hierarchy视图中的任何对象发生改变时调用一次");
	}

	void OnProjectChange()
	{
		Debug.Log("当Project视图中的资源发生改变时调用一次");
	}

	void OnInspectorUpdate()
	{
		//Debug.Log("窗口面板的更新");
		//这里开启窗口的重绘，不然窗口信息不会刷新
		this.Repaint();
	}

	void OnSelectionChange()
	{
		//当窗口出去开启状态，并且在Hierarchy视图中选择某游戏对象时调用
		foreach (Transform t in Selection.transforms)
		{
			//有可能是多选，这里开启一个循环打印选中游戏对象的名称
			Debug.Log("OnSelectionChange" + t.name);
		}
	}

	void OnDestroy()
	{
		Debug.Log("当窗口关闭时调用");
	}
}