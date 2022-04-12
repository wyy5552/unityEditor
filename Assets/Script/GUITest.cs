//C#
using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour
{
    //private float hSliderValue = 0.0f;
    //private Vector2 scrollViewVector = Vector2.zero;
    //private string innerText = "I am inside the ScrollView";


    //void OnGUI()
    //{
    //    //Debug.Log("OnGUI-------");
    //    // Make a background box
    //    //GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");

    //    //// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
    //    //if (GUI.Button(new Rect(20, 40, 80, 20), "Level 1"))
    //    //{
    //    //    Application.LoadLevel(1);
    //    //}

    //    //// Make the second button.
    //    //if (GUI.Button(new Rect(20, 70, 80, 20), "Level 2"))
    //    //{
    //    //    Application.LoadLevel(2);
    //    //}

    //    //GUI.Box(new Rect(0, 0, 100, 50), "Top-left");
    //    //GUI.Box(new Rect(Screen.width - 100, 0, 100, 50), "Top-right");
    //    //GUI.Box(new Rect(0, Screen.height - 50, 100, 50), "Bottom-left");
    //    //GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Bottom-right");

    //    //GUI.Label(new Rect(0, 0, 100, 50), "This is the text string for a Label Control");

    //    //if (GUI.Button(new Rect(10, 70, 100, 20), "This is text"))
    //    //{
    //    //    print("you clicked the text button");
    //    //}

    //    //GUI.Label(new Rect(25, 25, 100, 30), "Label");

    //    //if (GUI.RepeatButton(new Rect(25, 25, 100, 30), "RepeatButton"))
    //    //{
    //    //    print("you clicked the text RepeatButton");
    //    //    // This code is executed every frame that the RepeatButton remains clicked
    //    //}

    //    //hSliderValue = GUI.HorizontalSlider(new Rect(225, 25, 100, 30), hSliderValue, 0.0f, 10.0f);

    //    // Begin the ScrollView
    //    scrollViewVector = GUI.BeginScrollView(new Rect(25, 25, 100, 100), scrollViewVector, new Rect(0, 0, 400, 400));

    //    // Put something inside the ScrollView
    //    innerText = GUI.TextArea(new Rect(0, 0, 400, 400), innerText);

    //    // End the ScrollView
    //    GUI.EndScrollView();
    //}


    //private Rect windowRect = new Rect(20, 20, 120, 50);

    //void OnGUI()
    //{
    //    windowRect = GUI.Window(0, windowRect, WindowFunction, "My Window");
    //}

    //void WindowFunction(int windowID)
    //{
    //    // Draw any Controls inside the window here
    //}

    private int selectedToolbar = 0;
    private string[] toolbarStrings = { "One", "Two" };

    void OnGUI()
    {
        // Determine which button is active, whether it was clicked this frame or not
        selectedToolbar = GUI.Toolbar(new Rect(50, 10, Screen.width - 100, 30), selectedToolbar, toolbarStrings);

        // If the user clicked a new Toolbar button this frame, we'll process their input
        if (GUI.changed)
        {
            Debug.Log("The toolbar was clicked");

            if (0 == selectedToolbar)
            {
                Debug.Log("First button was clicked");
            }
            else
            {
                Debug.Log("Second button was clicked");
            }
        }
    }
}