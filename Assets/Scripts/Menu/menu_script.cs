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
        GUI.skin = menuSkin;
       GUILayout.BeginArea(new Rect(0,0,Screen.width, Screen.height));
        if(GUILayout.Button(language.GetSlovo(jazyk,"menu_startgame"), GUILayout.Width(Screen.width/2), GUILayout.Height(Screen.height/4.5f)))
             {
                
             }
                GUILayout.BeginHorizontal();   
                    GUILayout.FlexibleSpace(); 
         if(GUILayout.Button(language.GetSlovo(jazyk,"menu_loadgame"), GUILayout.Width(Screen.width / 2), GUILayout.Height(Screen.height / 4.5f)))
             {
            
             }
                    GUILayout.FlexibleSpace(); 
                GUILayout.EndHorizontal();  
                GUILayout.BeginHorizontal();   
                    GUILayout.FlexibleSpace(); 
           if(GUILayout.Button(language.GetSlovo(jazyk,"menu_settings"), GUILayout.Width(Screen.width / 2), GUILayout.Height(Screen.height / 4.5f)))
             {
            SceneManager.LoadScene("settings");
             }
                GUILayout.EndHorizontal(); 
          GUI.skin = menuSkinVypinac;
                GUILayout.BeginHorizontal();   
                    GUILayout.FlexibleSpace(); 
           if(GUILayout.Button("", GUILayout.Width(Screen.width / 4.5f), GUILayout.Height(Screen.height / 4.5f)))
              {
                         Application.Quit();
              }
                GUILayout.EndHorizontal();  
       GUILayout.EndArea();
    }
    
}
