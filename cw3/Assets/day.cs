using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day : MonoBehaviour
{
   string heroname = "scotte";
    int hero  = 20;
   string villanname = "jackson";
    int villan = 10;
    bool isstrong = true;
    // Start is called before the first frame update
    void Start()
    {
        if (hero > villan)


        {
            print(hero + heroname + isstrong);
        }
        else if (villan > hero) 
        {
            print(villan +villanname+ isstrong);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
