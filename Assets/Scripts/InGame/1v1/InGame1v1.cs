using UnityEngine;
using System.Collections;

public class InGame1v1 : MonoBehaviour {
    public GUISkin skin_mapa_Forta;
    public GUISkin skin_mapa_Koila;
    public GUISkin skin_mapa_Gajuta;
    public GUISkin skin_mapa_Omaron;
    public GUISkin skin_mapa_Pountedal;
    public GUISkin skin_mapa_Rountha;

    GUIStyle style_mapa_Forta;
    GUIStyle style_mapa_Koila;
    GUIStyle style_mapa_Gajuta;
    GUIStyle style_mapa_Omaron;
    GUIStyle style_mapa_Pountedal;
    GUIStyle style_mapa_Rountha;

    public GUISkin suroviny;
    public GUISkin menuSkin;
    GUIStyle style_suroviny;
    GUIStyle text;
    string selected;
    string zakladna = "";
    string time;
    int fps = 0;
    int mezifps = 0;
    float deltatime;
    int sec = 0;
    int min = 0;
      
	// Use this for initialization
	void Start () {
        style_mapa_Forta = skin_mapa_Forta.button;
        style_mapa_Gajuta = skin_mapa_Gajuta.button;
        style_mapa_Koila = skin_mapa_Koila.button;
        style_mapa_Omaron = skin_mapa_Omaron.button;
        style_mapa_Pountedal = skin_mapa_Pountedal.button;
        style_mapa_Rountha = skin_mapa_Rountha.button;
        
        zakladna = Before1v1Game.zakladna;
        selected = zakladna;
        text = menuSkin.button;
        text.fontSize = (int)(Mathf.Round(Screen.width / 30));
        style_suroviny = suroviny.button;
        style_suroviny.fontSize = (int)(Mathf.Round(Screen.width / 30));
    }
	
	// Update is called once per frame
	void Update () {
        mezifps +=1;
	      deltatime = deltatime + Time.deltaTime;
        if (deltatime > 1) {
            fps = mezifps;
            mezifps = 0;
            sec += 1;
            deltatime -=1;
        }
        if (sec > 59) {
            min += 1;
            sec -= 60;
        }
        time = (min + " : " + sec + " FPS: " + fps);
	}

    void OnGUI() {
        if (GUI.Button(new Rect(Screen.width/2.25f, Screen.height/9, Screen.width/4, Screen.height/5), "", style_mapa_Forta)) {
            selected = "Forta";
        }
        
        if (GUI.Button(new Rect(Screen.width/2.5f, Screen.height/2.5f, Screen.width/4, Screen.height/3.5f), "", style_mapa_Gajuta)) {
            selected = "Gajuta";
        }
        
        if (GUI.Button(new Rect(Screen.width/5, Screen.height/10, Screen.width/5, Screen.height/5), "", style_mapa_Koila)) {
            selected = "Koila";
        }
        
        if (GUI.Button(new Rect(Screen.width/1.5f, Screen.height/1.5f, Screen.width/8, Screen.height/9), "", style_mapa_Omaron)) {
            selected = "Omaron";
        }
        
        if (GUI.Button(new Rect(Screen.width/9, Screen.height/1.35f, Screen.width/6, Screen.height/7), "", style_mapa_Pountedal)) {
            selected = "Pountedal";
        }
        
        if (GUI.Button(new Rect(Screen.width/1.35f, Screen.height/2.25f, Screen.width/4, Screen.height/5), "", style_mapa_Rountha)) {
            selected = "Rountha";
        }
        
        
        
        // tady se vykresluje horní menu
        if (GUI.Button(new Rect(0,0, Screen.width / 4, Screen.height/9),time,text)){
                  
        }
        if (GUI.Button(new Rect(Screen.width / 4, 0, Screen.width/2, Screen.height / 9), "", style_suroviny))
        {

        }
        if (GUI.Button(new Rect((Screen.width / 2 + Screen.width / 4), 0, Screen.width/4, Screen.height / 9), "moje"))
        {

        }
        
        
        
        // tady se vykresluje dolní menu
        if (GUI.Button(new Rect(0,Screen.height-Screen.height/9,Screen.width/4, Screen.height/9),"moje")){
          
        }   
        if (GUI.Button(new Rect(Screen.width/4,Screen.height-Screen.height/9,Screen.width/2, Screen.height/9),selected,text)){
          
        }
        if (GUI.Button(new Rect((Screen.width/2+Screen.width/4),Screen.height-Screen.height/9,Screen.width/4, Screen.height/9),"moje")){
          
        }
    }
}
