using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControler 
{
    float Forta_tezba_kamen;
    float Forta_tezba_zelezo;
    float Forta_tezba_ropa;
    float Forta_tezba_uran;
    float Forta_tezba_potraviny;

    float Gajuta_tezba_kamen;
    float Gajuta_tezba_zelezo;
    float Gajuta_tezba_ropa;
    float Gajuta_tezba_uran;
    float Gajuta_tezba_potraviny;

    float Koila_tezba_kamen;
    float Koila_tezba_zelezo;
    float Koila_tezba_ropa;
    float Koila_tezba_uran;
    float Koila_tezba_potraviny;

    float Omaron_tezba_kamen;
    float Omaron_tezba_zelezo;
    float Omaron_tezba_ropa;
    float Omaron_tezba_uran;
    float Omaron_tezba_potraviny;

    float Pountedal_tezba_kamen;
    float Pountedal_tezba_zelezo;
    float Pountedal_tezba_ropa;
    float Pountedal_tezba_uran;
    float Pountedal_tezba_potraviny;

    float Rontha_tezba_kamen;
    float Rontha_tezba_zelezo;
    float Rontha_tezba_ropa;
    float Rontha_tezba_uran;
    float Rontha_tezba_potraviny;

    int Player_suroviny_kamen;
    int Player_suroviny_zelezo;
    int Player_suroviny_ropa;
    int Player_suroviny_uran;
    int Player_suroviny_potraviny;
    int Player_suroviny_obyvatele;

    int Ai_suroviny_kamen;
    int Ai_suroviny_zelezo;
    int Ai_suroviny_ropa;
    int Ai_suroviny_uran;
    int Ai_suroviny_potraviny;
    int Ai_suroviny_obyvatele;

    float Player_suroviny_kamen_actual;
    float Player_suroviny_zelezo_actual;
    float Player_suroviny_ropa_actual;
    float Player_suroviny_uran_actual;
    float Player_suroviny_potraviny_actual;
    float Player_suroviny_obyvatele_actual;

    float Ai_suroviny_kamen_actual;
    float Ai_suroviny_zelezo_actual;
    float Ai_suroviny_ropa_actual;
    float Ai_suroviny_uran_actual;
    float Ai_suroviny_potraviny_actual;
    float Ai_suroviny_obyvatele_actual;

    string Forta_owner = "";
    string Gajuta_owner = "";
    string Koila_owner = "";
    string Omaron_owner = "";
    string Pountedal_owner = "";
    string Rontha_owner = "";

    float Player_tezba_kamen;
    float Player_tezba_zelezo;
    float Player_tezba_ropa;
    float Player_tezba_uran;
    float Player_tezba_potraviny;
    float Ai_tezba_kamen;
    float Ai_tezba_zelezo;
    float Ai_tezba_ropa;
    float Ai_tezba_uran;
    float Ai_tezba_potraviny;

    int multiplier;

    void Declare() {
        Forta_tezba_kamen = Random.Range(2,17);
        Forta_tezba_zelezo = Random.Range( 1, 7);
        Forta_tezba_ropa = (Forta_tezba_kamen * 4 + Forta_tezba_zelezo * 8 + Forta_tezba_potraviny * 120 / 24);
        Forta_tezba_uran = (16.3f - (Forta_tezba_kamen+ Forta_tezba_zelezo+ Forta_tezba_potraviny+ Forta_tezba_ropa));
        Forta_tezba_potraviny = Random.Range(0.13f , 0.4f);

        Gajuta_tezba_kamen = Random.Range(2, 17);
        Gajuta_tezba_zelezo = Random.Range(1, 7);
        Gajuta_tezba_ropa = (Gajuta_tezba_kamen * 4 + Gajuta_tezba_zelezo * 8 + Gajuta_tezba_potraviny * 120 / 24);
        Gajuta_tezba_uran = (16.3f - (Gajuta_tezba_kamen + Gajuta_tezba_zelezo + Gajuta_tezba_potraviny + Gajuta_tezba_ropa));
        Gajuta_tezba_potraviny = Random.Range(0.13f, 0.4f);

        Koila_tezba_kamen = Random.Range(2, 17);
        Koila_tezba_zelezo = Random.Range(1, 7);
        Koila_tezba_ropa = (Koila_tezba_kamen * 4 + Koila_tezba_zelezo * 8 + Koila_tezba_potraviny * 120 / 24);
        Koila_tezba_uran =
        Koila_tezba_potraviny = Random.Range(0.13f, 0.4f);

        Omaron_tezba_kamen = Random.Range(2, 17); 
        Omaron_tezba_zelezo = Random.Range(1, 7);
        Omaron_tezba_ropa = (Omaron_tezba_kamen * 4 + Omaron_tezba_zelezo * 8 + Omaron_tezba_potraviny * 120 / 24);
        Omaron_tezba_uran = (16.3f - (Omaron_tezba_kamen + Omaron_tezba_zelezo + Omaron_tezba_potraviny + Omaron_tezba_ropa));
        Omaron_tezba_potraviny = Random.Range(0.13f, 0.4f);

        Pountedal_tezba_kamen = Random.Range(2, 17);
        Pountedal_tezba_zelezo = Random.Range(1, 7);
        Pountedal_tezba_ropa = (Pountedal_tezba_kamen * 4 + Pountedal_tezba_zelezo * 8 + Pountedal_tezba_potraviny * 120 / 24);
        Pountedal_tezba_uran = (16.3f - (Pountedal_tezba_kamen + Pountedal_tezba_zelezo + Pountedal_tezba_potraviny + Pountedal_tezba_ropa));
        Pountedal_tezba_potraviny = Random.Range(0.13f, 0.4f);

        Rontha_tezba_kamen = Random.Range(2, 17);
        Rontha_tezba_zelezo = Random.Range(1, 7);
        Rontha_tezba_ropa = (Rontha_tezba_kamen * 4 + Rontha_tezba_zelezo * 8 + Rontha_tezba_potraviny * 120 / 24);
        Rontha_tezba_uran = (16.3f - (Rontha_tezba_kamen + Rontha_tezba_zelezo + Rontha_tezba_potraviny + Rontha_tezba_ropa));
        Rontha_tezba_potraviny = Random.Range(0.13f, 0.4f);

        Player_suroviny_kamen_actual = 5;
        Player_suroviny_zelezo_actual = 0;
        Player_suroviny_ropa_actual = 0;
        Player_suroviny_uran_actual = 0;
        Player_suroviny_potraviny_actual = 10;
        Player_suroviny_obyvatele_actual = 5;

        Ai_suroviny_kamen_actual = 5;
        Ai_suroviny_zelezo_actual = 0;
        Ai_suroviny_ropa_actual = 0;
        Ai_suroviny_uran_actual = 0;
        Ai_suroviny_potraviny_actual = 10;
        Ai_suroviny_obyvatele_actual = 5;



    }

    float GetTezba(string oblast, string surovina) {
        if (oblast == "Forta") {
            if (surovina == "kamen") {
                return Forta_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Forta_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Forta_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Forta_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Forta_tezba_potraviny;
            }
        }
        if (oblast == "Gajuta")
        {
            if (surovina == "kamen")
            {
                return Gajuta_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Gajuta_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Gajuta_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Gajuta_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Gajuta_tezba_potraviny;
            }

        }

        if (oblast == "Koila")
        {
            if (surovina == "kamen")
            {
                return Koila_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Koila_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Koila_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Koila_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Koila_tezba_potraviny;
            }
        }

        if (oblast == "Omaron")
        {
            if (surovina == "kamen")
            {
                return Omaron_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Omaron_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Omaron_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Omaron_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Omaron_tezba_potraviny;
            }
        }

        if (oblast == "Pountedal")
        {
            if (surovina == "kamen")
            {
                return Pountedal_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Pountedal_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Pountedal_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Pountedal_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Pountedal_tezba_potraviny;
            }
        }

        if (oblast == "Rontha")
        {
            if (surovina == "kamen")
            {
                return Rontha_tezba_kamen;
            }
            if (surovina == "zelezo")
            {
                return Rontha_tezba_zelezo;
            }
            if (surovina == "ropa")
            {
                return Rontha_tezba_ropa;
            }
            if (surovina == "uran")
            {
                return Rontha_tezba_uran;
            }
            if (surovina == "potraviny")
            {
                return Rontha_tezba_potraviny;
            }
        }
        return 0;
    }

    int GetMnozstvi( string Kdo, string surovina) {
        if (Kdo == "player") {
            if (surovina == "kamen") {
                return Player_suroviny_kamen;
            }

            if (surovina == "zelezo")
            {
                return Player_suroviny_zelezo;
            }

            if (surovina == "ropa")
            {
                return Player_suroviny_ropa;
            }

            if (surovina == "uran")
            {
                return Player_suroviny_uran;
            }

            if (surovina == "potraviny")
            {
                return Player_suroviny_potraviny;
            }

            if (surovina == "obyvatele")
            {
                return Player_suroviny_obyvatele;
            }
        }

        if (Kdo == "Ai")
        {
            if (surovina == "kamen")
            {
                return Ai_suroviny_kamen;
            }

            if (surovina == "zelezo")
            {
                return Ai_suroviny_zelezo;
            }

            if (surovina == "ropa")
            {
                return Ai_suroviny_ropa;
            }

            if (surovina == "uran")
            {
                return Ai_suroviny_uran;
            }

            if (surovina == "potraviny")
            {
                return Ai_suroviny_potraviny;
            }

            if (surovina == "obyvatele")
            {
                return Ai_suroviny_obyvatele;
            }
        }

        return 0;
    }

    void SetMnozstvi(string Kdo, string surovina, int pocet) {

        if (Kdo == "player")
        {
            if (surovina == "kamen")
            {
                Player_suroviny_kamen_actual -= Player_suroviny_kamen - pocet;
            }

            if (surovina == "zelezo")
            {
                Player_suroviny_zelezo_actual -= Player_suroviny_zelezo - pocet;
            }

            if (surovina == "ropa")
            {
                Player_suroviny_ropa_actual -= Player_suroviny_ropa - pocet;
            }

            if (surovina == "uran")
            {
                Player_suroviny_uran_actual -= Player_suroviny_uran - pocet;
            }

            if (surovina == "potraviny")
            {
                Player_suroviny_potraviny_actual -= Player_suroviny_potraviny - pocet;
            }

            if (surovina == "obyvatele")
            {
                Player_suroviny_obyvatele_actual -= Player_suroviny_obyvatele - pocet;
            }
        }

        if (Kdo == "Ai")
        {
            if (surovina == "kamen")
            {
                Ai_suroviny_kamen_actual -= Ai_suroviny_kamen - pocet;
            }

            if (surovina == "zelezo")
            {
                Ai_suroviny_zelezo_actual -= Ai_suroviny_zelezo - pocet;
            }

            if (surovina == "ropa")
            {
                Ai_suroviny_ropa_actual -= Ai_suroviny_ropa - pocet;
            }

            if (surovina == "uran")
            {
                Ai_suroviny_uran_actual -= Ai_suroviny_uran - pocet;
            }

            if (surovina == "potraviny")
            {
                Ai_suroviny_potraviny_actual -= Ai_suroviny_potraviny - pocet;
            }

            if (surovina == "obyvatele")
            {
                Ai_suroviny_obyvatele_actual -= Ai_suroviny_obyvatele - pocet;
            }
        }
    }

    void Refresh(float Player_kamen,float Player_zelezo, float Player_ropa, float Player_uran, float Player_potraviny, float Ai_kamen, float Ai_zelezo, float Ai_ropa, float Ai_uran, float Ai_potraviny) {
        Player_tezba_kamen = 0;
        Player_tezba_zelezo = 0;
        Player_tezba_ropa = 0;
        Player_tezba_uran = 0;
        Player_tezba_potraviny = 0;
        if (Forta_owner == "Player") {
            Player_tezba_kamen += Forta_tezba_kamen;
            Player_tezba_zelezo += Forta_tezba_zelezo;
            Player_tezba_ropa += Forta_tezba_ropa;
            Player_tezba_uran += Forta_tezba_uran;
            Player_tezba_potraviny += Forta_tezba_potraviny;
        }
        if (Gajuta_owner == "Player")
        {
            Player_tezba_kamen += Gajuta_tezba_kamen;
            Player_tezba_zelezo += Gajuta_tezba_zelezo;
            Player_tezba_ropa += Gajuta_tezba_ropa;
            Player_tezba_uran += Gajuta_tezba_uran;
            Player_tezba_potraviny += Gajuta_tezba_potraviny;
        }
        if (Koila_owner == "Player")
        {
            Player_tezba_kamen += Koila_tezba_kamen;
            Player_tezba_zelezo += Koila_tezba_zelezo;
            Player_tezba_ropa += Koila_tezba_ropa;
            Player_tezba_uran += Koila_tezba_uran;
            Player_tezba_potraviny += Koila_tezba_potraviny;
        }
        if (Omaron_owner == "Player")
        {
            Player_tezba_kamen += Omaron_tezba_kamen;
            Player_tezba_zelezo += Omaron_tezba_zelezo;
            Player_tezba_ropa += Omaron_tezba_ropa;
            Player_tezba_uran += Omaron_tezba_uran;
            Player_tezba_potraviny += Omaron_tezba_potraviny;
        }
        if (Pountedal_owner == "Player")
        {
            Player_tezba_kamen += Pountedal_tezba_kamen;
            Player_tezba_zelezo += Pountedal_tezba_zelezo;
            Player_tezba_ropa += Pountedal_tezba_ropa;
            Player_tezba_uran += Pountedal_tezba_uran;
            Player_tezba_potraviny += Pountedal_tezba_potraviny;
        }
        if (Rontha_owner == "Player")
        {
            Player_tezba_kamen += Rontha_tezba_kamen;
            Player_tezba_zelezo += Rontha_tezba_zelezo;
            Player_tezba_ropa += Rontha_tezba_ropa;
            Player_tezba_uran += Rontha_tezba_uran;
            Player_tezba_potraviny += Rontha_tezba_potraviny;
        }

        if (Forta_owner == "Ai")
        {
            Ai_tezba_kamen += Forta_tezba_kamen;
            Ai_tezba_zelezo += Forta_tezba_zelezo;
            Ai_tezba_ropa += Forta_tezba_ropa;
            Ai_tezba_uran += Forta_tezba_uran;
            Ai_tezba_potraviny += Forta_tezba_potraviny;
        }
        if (Gajuta_owner == "Ai")
        {
            Ai_tezba_kamen += Gajuta_tezba_kamen;
            Ai_tezba_zelezo += Gajuta_tezba_zelezo;
            Ai_tezba_ropa += Gajuta_tezba_ropa;
            Ai_tezba_uran += Gajuta_tezba_uran;
            Ai_tezba_potraviny += Gajuta_tezba_potraviny;
        }
        if (Koila_owner == "Ai")
        {
            Ai_tezba_kamen += Koila_tezba_kamen;
            Ai_tezba_zelezo += Koila_tezba_zelezo;
            Ai_tezba_ropa += Koila_tezba_ropa;
            Ai_tezba_uran += Koila_tezba_uran;
            Ai_tezba_potraviny += Koila_tezba_potraviny;
        }
        if (Omaron_owner == "Ai")
        {
            Ai_tezba_kamen += Omaron_tezba_kamen;
            Ai_tezba_zelezo += Omaron_tezba_zelezo;
            Ai_tezba_ropa += Omaron_tezba_ropa;
            Ai_tezba_uran += Omaron_tezba_uran;
            Ai_tezba_potraviny += Omaron_tezba_potraviny;
        }
        if (Pountedal_owner == "Ai")
        {
            Ai_tezba_kamen += Pountedal_tezba_kamen;
            Ai_tezba_zelezo += Pountedal_tezba_zelezo;
            Ai_tezba_ropa += Pountedal_tezba_ropa;
            Ai_tezba_uran += Pountedal_tezba_uran;
            Ai_tezba_potraviny += Pountedal_tezba_potraviny;
        }
        if (Rontha_owner == "Ai")
        {
            Ai_tezba_kamen += Rontha_tezba_kamen;
            Ai_tezba_zelezo += Rontha_tezba_zelezo;
            Ai_tezba_ropa += Rontha_tezba_ropa;
            Ai_tezba_uran += Rontha_tezba_uran;
            Ai_tezba_potraviny += Rontha_tezba_potraviny;
        }
        multiplier = (int)Mathf.Floor(Player_suroviny_potraviny / Player_suroviny_obyvatele);
        if (Player_suroviny_potraviny > Player_suroviny_obyvatele)
        {
            Player_suroviny_potraviny -= Player_suroviny_obyvatele;
        }
        else {
            Player_suroviny_obyvatele = Player_suroviny_potraviny;
            Player_suroviny_potraviny = 0;
        }
        Player_suroviny_obyvatele += multiplier;
        Player_suroviny_kamen = (int)Mathf.Floor(Player_suroviny_kamen_actual += Player_tezba_kamen * Player_kamen * Player_suroviny_obyvatele / 10);
        Player_suroviny_zelezo = (int)Mathf.Floor(Player_suroviny_zelezo_actual += Player_tezba_zelezo * Player_zelezo * Player_suroviny_obyvatele / 10);
        Player_suroviny_ropa = (int)Mathf.Floor(Player_suroviny_ropa_actual += Player_tezba_ropa * Player_ropa * Player_suroviny_obyvatele / 10);
        Player_suroviny_uran = (int)Mathf.Floor(Player_suroviny_uran_actual += Player_tezba_uran * Player_uran * Player_suroviny_obyvatele / 10);
        Player_suroviny_potraviny = (int)Mathf.Floor(Player_suroviny_potraviny_actual += Player_tezba_potraviny * Player_potraviny * Player_suroviny_obyvatele / 10);

        multiplier = (int)Mathf.Floor(Ai_suroviny_potraviny / Ai_suroviny_obyvatele);
        if (Ai_suroviny_potraviny > Ai_suroviny_obyvatele)
        {
            Ai_suroviny_potraviny -= Ai_suroviny_obyvatele;
        }
        else {
            Ai_suroviny_obyvatele = Ai_suroviny_potraviny;
            Ai_suroviny_potraviny = 0;
        }
        Ai_suroviny_obyvatele += multiplier;
        Ai_suroviny_kamen = (int)Mathf.Floor(Ai_suroviny_kamen_actual += Ai_tezba_kamen * Ai_kamen * Ai_suroviny_obyvatele / 10);
        Ai_suroviny_zelezo = (int)Mathf.Floor(Ai_suroviny_zelezo_actual += Ai_tezba_zelezo * Ai_zelezo * Ai_suroviny_obyvatele / 10);
        Ai_suroviny_ropa = (int)Mathf.Floor(Ai_suroviny_ropa_actual += Ai_tezba_ropa * Ai_ropa * Ai_suroviny_obyvatele / 10);
        Ai_suroviny_uran = (int)Mathf.Floor(Ai_suroviny_uran_actual += Ai_tezba_uran * Ai_uran * Ai_suroviny_obyvatele / 10);
        Ai_suroviny_potraviny = (int)Mathf.Floor(Ai_suroviny_potraviny_actual += Ai_tezba_potraviny * Ai_potraviny * Ai_suroviny_obyvatele / 10);


    }

    void SetOwner(string Oblast, string Kdo)
    {
        if (Oblast == "Forta") {
            Forta_owner = Kdo;
        }
        if (Oblast == "Gajuta")
        {
            Gajuta_owner = Kdo;
        }
        if (Oblast == "Koila")
        {
            Koila_owner = Kdo;
        }
        if (Oblast == "Omaron")
        {
            Omaron_owner = Kdo;
        }
        if (Oblast == "Pountedal")
        {
            Pountedal_owner = Kdo;
        }
        if (Oblast == "Rontha")
        {
            Rontha_owner = Kdo;
        }
    }
}