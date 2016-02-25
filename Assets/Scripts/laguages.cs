using UnityEngine;
using System.Collections;

public class laguages : MonoBehaviour {
		
	string returnString = "";
	
	void Start () {
		
	}
	
	
	void Update () {
	
	}

	string GetSlovo (string jazyk, string identifikator) {
		if (jazyk == "cestina") {
			switch (identifikator)
			{
			case "menu_startgame":
				returnString = "Nová hra";
				break;
			case "menu_loadgame":
				returnString = "Nahrát hru";
				break;
			case "menu_settings":
				returnString = "Nastavení";
				break;

			}
		} return returnString;
	}
}
