using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TypeChooser : MonoBehaviour {
    public GUISkin ChooserSkin;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI (){
        GUIStyle style = ChooserSkin.button;
        if (GUI.Button(new Rect(Screen.width/3, Screen.height / 8, Screen.width / 3, Screen.height / 1.25f), "", style)){
            SceneManager.LoadScene("Before1v1Game");
        }
    }
}
