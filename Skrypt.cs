using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrypt : MonoBehaviour
{
    void Start()
    {
        // typ zmiennej i nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;

        //sposób drugi
        int b = 40;

        Debug.Log(a);       //pokazuje, co chcę wyświetlić na konsoli

        {
            int c = 30;                      //c widoczne teraz tylko w obrębie klamerek
        }

        float d = 1.5f;
        d = 20.0f;

        bool e = true; //albo true, albo false

        string f = "cośtamcośtam";  //napisy

        Debug.Log("d: " + d + " e: " + e + " f: " + f);

        //operacje na zmiennych + - * /
        Debug.Log(a / b);
        Debug.Log(a / d);
        Debug.Log(Mathf.Sqrt(2));          //wyświetlenie pierwiastka :p

        //operacje logiczne
        Debug.Log(a == b);    //rowne
        Debug.Log(a != b);    //rozne
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);


        //if (warunek logicznyy){}

        if (a == b)
        {
            Debug.Log("Tak, jest taka sama");
            Koniunkcja(a, b);
        }
        else if (a > b)
        {
            Debug.Log("a > b");
            Alternatywa(a, b);

        }
        else
        {
            Koniunkcja(a, b);
            Alternatywa(a, b);
            Debug.Log("żadne z wymienionych");
        }

        Koniunkcja(a, b);

        Alternatywa(a,b);
            

}

    public void Koniunkcja(int a, int b)
    {
        Debug.Log((a != b) && (a > 0));

        // if(a != b)                 BRZYDKA WERSJA! :c
        // {
        //    if(a > 0)
        //     {
        //jakiś tam kod
        //     }
        // }

        if ((a != b) && (a > 0))        //ŁADNA WERSJA C:
        {
            //jakiś tam kod
        }
    }
      
        public void Alternatywa(int a, int b)
        {
            //brzydka wersja
            int hp = 2, time = 1;
            bool amulet = true;

            if (hp <= 0)
            {
                if (!amulet)
                {  // wykrzyknik znaczy, że sprawdzamy czy amulet = false

                }
                else
                { // }
                }
                if (time <= 0)
                {
                    if (!amulet)
                    {  // wykrzyknik znaczy, że sprawdzamy czy amulet = false

                    }
                    else
                    { // }
                    }
                    //ładna wersja c:
                }
            }

            if ((hp <= 0) || (time <= 0))
            {
                if (!amulet)
                {  // wykrzyknik znaczy, że sprawdzamy czy amulet = false

                }
                else
                { // } }
                }
            }
        }
    







    void Update()
    {
        
    }
}
