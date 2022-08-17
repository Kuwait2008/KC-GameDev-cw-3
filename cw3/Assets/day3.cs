using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    int age1 = 20;
    int age2 = 20;


    // Start is called before the first frame update
    void Start()
    {

        if (age1 > age2)
        {
            print(age1 + " is bigger");
        }
        else if (age1 == age2)
        {
            print("they are equal");
        }
        else
        {
            print(age2 + "is bigger");
        }
        
        




        // Update is called once per frame
        void Update()
        {

        }
    }
}

