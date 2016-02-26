using UnityEngine;
using System.Collections;

public class setLanguage : MonoBehaviour {
    Languages language = new Languages();
    public GUIStyle style = new GUIStyle();
    public GUISkin menuSkin;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUIStyle style = menuSkin.button;
        
        GUILayout.BeginHorizontal();
        if (GUI.Button(new Rect(Screen.width / 200, Screen.height / 200, Screen.width / 2, Screen.height / 4.5f), language.GetSlovo(jazyk, "menu_startgame"), style))
        {
            language.SetLanguage("cestina");
        }
        if
{
            language.SetLanguage("english");
        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
