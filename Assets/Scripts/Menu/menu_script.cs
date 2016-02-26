using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class menu_script : MonoBehaviour {

    public GUISkin menuSkin;
    public GUISkin menuSkinVypinac;
    public string jazyk = "cestina";
    Languages language = new Languages();
	void Start ()
    {
        
    }
	
	
	void Update ()
    {
	   
	  }
    
    void OnGUI()
    {
        GUIStyle style = menuSkin.button;
        style.fontSize = (int)(Mathf.Round(Screen.width / 30));
            if (GUI.Button(new Rect(Screen.width / 200, Screen.height / 200, Screen.width / 2, Screen.height / 4.5f),language.GetSlovo(jazyk, "menu_startgame"),style))
             {
                
             }
        if(GUI.Button(new Rect (Screen.width/4,Screen.height/3.5f,Screen.width/2,Screen.height/4.5f),language.GetSlovo(jazyk,"menu_loadgame"),style))
             {
            
             }
        if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, Screen.width / 2, Screen.height / 4.5f), language.GetSlovo(jazyk, "menu_settings"), style))
            
             {
            SceneManager.LoadScene("settings");
             }
        GUIStyle style_vypinac = menuSkinVypinac.button;
        GUI.skin = menuSkinVypinac; 
           if(GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 1.3f, Screen.width / 4.5f, Screen.height / 4.5f),"", style_vypinac))
        {
                         Application.Quit();
        }
    }
    
}
