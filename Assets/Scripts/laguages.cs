using UnityEngine;
using System.Collections;

public class laguages : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	string GetSlovo (string jazyk, string identifikator) {
		if (jazyk == "cestina") {
			switch (identifikator)
			{
			case "menu_startgame":
				return "Nová hra";
				break;
			case "menu_loadgame":
				return "Nahrát hru";
				break;
			case "menu_settings":
				return "Nastavení";
				break;
			}
		}
	}
}
