using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Languages 
{
    string returnString = "";
    string language;
    public string GetSlovo(string jazyk, string identifikator)
    {
        if (jazyk == "cestina")
        {
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
                case "settings_setlanguage":
                    returnString = "Nastavit jazyk";
                    break;
                case "settings_backtomenu":
                    returnString = "Zpět do menu";
                    break;
                case "ingame_selectarea":
                    returnString = "Vyberte oblast"; 
                    break;
                case "ingame_selected":
                    returnString = "Vybráno:";
                    break;
                case "ingame_accept:":
                    returnString = "Potvrdit";
                    break;

            }
        }
        if (jazyk == "english")
        {
            switch (identifikator)
            {
                case "menu_startgame":
                    returnString = "Start game";
                    break;
                case "menu_loadgame":
                    returnString = "Load game";
                    break;
                case "menu_settings":
                    returnString = "Settings";
                    break;
                case "settings_setlanguage":
                    returnString = "Set language";
                    break;
                case "settings_backtomenu":
                    returnString = "Back to menu";
                    break;
                case "ingame_selectarea":
                    returnString = "Select location";
                    break;
                case "ingame_selected":
                    returnString = "Selected:";
                    break;
                case "ingame_accept:":
                    returnString = "Accept";
                    break;
            }
        }
        return returnString;
    }
}