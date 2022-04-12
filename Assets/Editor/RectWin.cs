
using UnityEngine;
using UnityEditor;
public class RectWin : EditorWindow
{

    [MenuItem("德玛/Window/RectWin")]
    static void AddWindow()
    {
        //创建窗口
        Rect wr = new Rect(0, 0, 500, 500);
        RectWin window = (RectWin)EditorWindow.GetWindowWithRect(typeof(RectWin), wr, true, "widow name");
        window.Show();

    }
}