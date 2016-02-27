using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class settings_script : MonoBehaviour {
    Languages language = new Languages();
    public GUISkin menuSkin;
    string Jazyk;
    // Use this for initialization
    void Start () {
        Jazyk = setLanguage.global_jazyk;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUIStyle style = menuSkin.button;
        style.fontSize = (int)(Mathf.Round(Screen.width / 30));
        if (GUI.Button(new Rect(Screen.width /4, Screen.height / 5, Screen.width / 2, Screen.height / 4.5f), language.GetSlovo(Jazyk, "settings_setlanguage"), style))
                {
            SceneManager.LoadScene("setLanguage");
                }
        if (GUI.Button(new Rect(Screen.width / 4, Screen.height / 2.5f, Screen.width / 2, Screen.height / 4.5f), language.GetSlovo(Jazyk, "settings_backtomenu"), style))
                {
            SceneManager.LoadScene("menu");
                }
       
    }
}
