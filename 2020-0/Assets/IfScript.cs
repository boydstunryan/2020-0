using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OUB12";
    private bool canRun;

    void Start()
    {
        if (a+b != c)
        {
            print(message:"that is true");
        }

        if (password != "OUB12")
        {
            print(message: "That is the correct password");
        }

        if (!canRun)
        {
            print(message: "we cant run");
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(message: "that is the correct password");
    }
}
