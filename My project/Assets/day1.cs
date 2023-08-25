using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class day1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string HeroName = "Bader";
        int HeroAge = 15;
        bool is_hero = true;
        float herospeed = 20f;
        string heroSuperPower = "RastnGan";

        string villainName = "fahd";
        int villainAge = 10;
        float villainSpeed = 15f;
        string villainSuperPower = "RenGan";

        int ageDifference = 15 - 10;






        print("My Name is " + HeroName);
        print("my speed is" + herospeed);
        print("my age is" + HeroAge);
        print("my Super Power is" + heroSuperPower);
        print("my name is" + villainName);
        print("my age is" + villainAge);
        print("my speed is" + villainSpeed);
        print("my super bower is" + villainSuperPower);
        print(ageDifference);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
