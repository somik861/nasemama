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
    public GUISkin ingameGUI;
    public GUISkin ingameGUI_menu;
    public GUISkin ingameGUI_fps;
    public GUISkin ingameGUI_layout;
    public GUISkin ingame_menu_layout;
    GUIStyle style_ingame_menu_layout;
    GUIStyle style_ingameGUI_layout;
    GUIStyle style_suroviny;
    GUIStyle text;
    GUIStyle style_ingameGUI_menu;
    GUIStyle style_ingameGUI_fps;
    string selected;
    string zakladna = "";
    string time;
    int fps = 0;
    int mezifps = 0;
    float deltatime;
    int sec = 0;
    int min = 0;
    bool pauza = false;
    Languages language = new Languages();
    string Jazyk;

    // Use this for initialization
    void Start () {
        style_mapa_Forta = skin_mapa_Forta.button;
        style_mapa_Gajuta = skin_mapa_Gajuta.button;
        style_mapa_Koila = skin_mapa_Koila.button;
        style_mapa_Omaron = skin_mapa_Omaron.button;
        style_mapa_Pountedal = skin_mapa_Pountedal.button;
        style_mapa_Rountha = skin_mapa_Rountha.button;
        Jazyk = setLanguage.global_jazyk;

        zakladna = Before1v1Game.zakladna;
        if (zakladna == "") {
            zakladna = "Forta";
        }
        selected = zakladna;
        text = ingameGUI.button;
        text.fontSize = (int)(Mathf.Round(Screen.width / 30));
        style_suroviny = suroviny.button;
        style_suroviny.fontSize = (int)(Mathf.Round(Screen.width / 30));
        style_ingameGUI_menu = ingameGUI_menu.button;
        style_ingameGUI_fps = ingameGUI_fps.button;
        style_ingameGUI_fps.fontSize = (int)(Mathf.Round(Screen.width / 30));
        style_ingameGUI_layout = ingameGUI_layout.button;
        style_ingame_menu_layout = ingame_menu_layout.button;
    }
	
	// Update is called once per frame
	void Update () {
        if (pauza == false) {  // pokud není pauza (inGame menu)
            mezifps += 1;
            deltatime = deltatime + Time.deltaTime;
            if (deltatime > 1) {
                fps = mezifps;
                mezifps = 0;
                sec += 1;
                deltatime -= 1;
            }
            if (sec > 59) {
                min += 1;
                sec -= 60;
            }
            time = (min + " : " + sec + " FPS: " + fps);
        }
	}

    void OnGUI() {
        if (pauza == false)
        {
            if (GUI.Button(new Rect(Screen.width / 2.25f, Screen.height / 9, Screen.width / 4, Screen.height / 5), "", style_mapa_Forta))
            {
                selected = "Forta";
            }

            if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 2.5f, Screen.width / 4, Screen.height / 3.5f), "", style_mapa_Gajuta))
            {
                selected = "Gajuta";
            }

            if (GUI.Button(new Rect(Screen.width / 5, Screen.height / 10, Screen.width / 5, Screen.height / 5), "", style_mapa_Koila))
            {
                selected = "Koila";
            }

            if (GUI.Button(new Rect(Screen.width / 1.5f, Screen.height / 1.5f, Screen.width / 8, Screen.height / 9), "", style_mapa_Omaron))
            {
                selected = "Omaron";
            }

            if (GUI.Button(new Rect(Screen.width / 9, Screen.height / 1.35f, Screen.width / 6, Screen.height / 7), "", style_mapa_Pountedal))
            {
                selected = "Pountedal";
            }

            if (GUI.Button(new Rect(Screen.width / 1.35f, Screen.height / 2.25f, Screen.width / 4, Screen.height / 5), "", style_mapa_Rountha))
            {
                selected = "Rountha";
            }
        }
        if (pauza == true) {
            GUI.Label(new Rect(Screen.width / 2.25f, Screen.height / 9, Screen.width / 4, Screen.height / 5), "", style_mapa_Forta);
            GUI.Label(new Rect(Screen.width / 2.5f, Screen.height / 2.5f, Screen.width / 4, Screen.height / 3.5f), "", style_mapa_Gajuta);
            GUI.Label(new Rect(Screen.width / 5, Screen.height / 10, Screen.width / 5, Screen.height / 5), "", style_mapa_Koila);
            GUI.Label(new Rect(Screen.width / 1.5f, Screen.height / 1.5f, Screen.width / 8, Screen.height / 9), "", style_mapa_Omaron);
            GUI.Label(new Rect(Screen.width / 9, Screen.height / 1.35f, Screen.width / 6, Screen.height / 7), "", style_mapa_Pountedal);
            GUI.Label(new Rect(Screen.width / 1.35f, Screen.height / 2.25f, Screen.width / 4, Screen.height / 5), "", style_mapa_Rountha);
        }



        // tady se vykresluje horní menu
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 9), "", style_ingameGUI_layout);
        GUI.Label(new Rect(0, 0, Screen.width / 4, Screen.height / 9), time, style_ingameGUI_fps);
        if (GUI.Button(new Rect(Screen.width / 4, 0, Screen.width/2 + Screen.width /4 - Screen.width /16, Screen.height / 9), "", style_suroviny))
        {

        }
        if (GUI.Button(new Rect((Screen.width - Screen.width/16), 0, Screen.width/16, Screen.height / 9), "",style_ingameGUI_menu))
        {
            // Zde se vykreslí INGame Menu
            pauza = true;
            
        }
        
        
        
        // tady se vykresluje dolní menu
        if (GUI.Button(new Rect(0,Screen.height-Screen.height/9,Screen.width/4, Screen.height/9),"moje")){
          
        }   
        if (GUI.Button(new Rect(Screen.width/4,Screen.height-Screen.height/9,Screen.width/2, Screen.height/9),selected,text)){
          
        }
        if (GUI.Button(new Rect(Screen.width/2 + Screen.width/4,Screen.height-Screen.height/9,Screen.width/4, Screen.height/9),"moje")){
          
        }
        if (pauza == true) {
            GUI.Label(new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), "", style_ingame_menu_layout);
            if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 3, Screen.width / 3, Screen.height / 6), language.GetSlovo(Jazyk, "ingame_menu_saveandquit"), style_ingameGUI_fps))
            {

            }
            if (GUI.Button(new Rect(Screen.width / 3, 1.5f*Screen.height / 3, Screen.width / 3, Screen.height / 6), language.GetSlovo(Jazyk, "ingame_menu_continue"), style_ingameGUI_fps))
            {
                pauza = false;
            }
        }
    }
}
