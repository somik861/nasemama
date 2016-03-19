using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class setLanguage : MonoBehaviour {
    public static string global_jazyk = "english";
    public GUIStyle style = new GUIStyle();
    public GUISkin menuSkin;
    // Use this for initialization
    void Start() {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUIStyle style = menuSkin.button;
        
        GUILayout.BeginHorizontal();
        if (GUI.Button(new Rect(Screen.width / 200, Screen.height / 200, Screen.width / 3, Screen.height / 4), "English", style))
        {
            global_jazyk = "english";
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 200, Screen.width / 3, Screen.height / 4), "Čeština", style))
        {
            global_jazyk = "cestina";
            SceneManager.LoadScene(1);
        }
    }
}
