using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class settings_script : MonoBehaviour {
    Languages language = new Languages();
    public string jazyk = "cestina";
    public GUISkin menuSkin;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.skin = menuSkin;
        GUILayout.BeginArea(new Rect(0, 100, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button(language.GetSlovo(jazyk, "settings_setlanguage"), GUILayout.Width(300), GUILayout.Height(75))) 
                {

                }
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button(language.GetSlovo(jazyk, "settings_backtomenu"), GUILayout.Width(300), GUILayout.Height(75)))
                {
            SceneManager.LoadScene("menu");
                }
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
