using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class menu_script : MonoBehaviour {
    void Awake() {
        
    }
    public GUISkin menuSkin;
    public GUISkin menuSkinVypinac;
    Languages language = new Languages();
    string Jazyk;
	void Start ()
    {
        Jazyk = setLanguage.global_jazyk;
    }
	
	
	void Update ()
    {
	  }
    
    void OnGUI()
    {
        GUIStyle style = menuSkin.button;
        style.fontSize = (int)(Mathf.Round(Screen.width / 30));
            if (GUI.Button(new Rect(Screen.width / 200, Screen.height / 200, Screen.width / 2, Screen.height / 4.5f),language.GetSlovo(Jazyk, "menu_startgame"),style))
             {
            SceneManager.LoadScene(3);
             }
        if(GUI.Button(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/4.5f),language.GetSlovo(Jazyk,"menu_loadgame"),style))
             {
            
             }
        if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 2, Screen.height / 4.5f), language.GetSlovo(Jazyk, "menu_settings"), style))
            
             {
            SceneManager.LoadScene(1);
             }
        GUIStyle style_vypinac = menuSkinVypinac.button;
        GUI.skin = menuSkinVypinac; 
           if(GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 1.3f, Screen.width / 4.5f, Screen.height / 4.5f),"", style_vypinac))
        {
                         Application.Quit();
        }
    }
    
}
