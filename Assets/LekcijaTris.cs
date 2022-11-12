using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LekcijaTris : MonoBehaviour
{
    public Option option;

    public enum Option
    {
        ONE,
        TWO,
        THREE
    }

    void Start()
    {
        // MethodFour(option);
        MethodFive();
    }

    private void MethodOne()
    {
        int option = 0;

        switch(option)
        {
            case 0 :
                Debug.Log("case 0");
            break;

            case 1 :
                Debug.Log("case 1");
            break;

            case 2 :
                Debug.Log("case 2");
            break;
        }
    }

    private void MethodTwo()
    {
        int option = 3;

        switch(option)
        {
            case 0 :
                Debug.Log("case 0");
            break;

            case 1 :
                Debug.Log("case 1");
            break;

            case 2 :
                Debug.Log("case 2");
            break;

            default:
                Debug.Log("Default");
            break;
        }
    }

    private void MethodThree()
    {
        string option = "A";

        switch(option)
        {
            case "A" :
                Debug.Log("case 0");
            break;

            case "safdaf" :
                Debug.Log("case 1");
            break;

            case "b" :
                Debug.Log("case 2");
            break;
        }
    }

    private void MethodFour(Option option)
    {
        switch(option)
        {
            case Option.ONE :
                Debug.Log("case 0");
            break;

            case Option.TWO :
                Debug.Log("case 1");
            break;

            case Option.THREE :
                Debug.Log("case 2");
            break;
        }
    }

    private void MethodFive()
    {
        int option = 2;

        switch(option)
        {
            case 0 :
            case 1 :
                Debug.Log("case 1");
            break;

            case 2 :
                Debug.Log("case 2");
            break;
        }
    }

    private void UzdOne(int grade)
    {
        switch(grade)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Debug.Log("F");
                break;
            case 5:
                Debug.Log("D");
                break;
            case 6:
                Debug.Log("C");
                break;
            case 7:
            case 8:
                Debug.Log("B");
                break;
            case 9:
                Debug.Log("A");
                break;
            case 10:
                Debug.Log("A+");
                break;
        }
    }
}

/*
    create function/method that calcualtes students grade from integer

    10 - A+
    9 - A
    7,8 - B // NO 7 LIDZ 8
    6 - C
    5 - D
    0,4 - F // NO 0 LIDZ 4
*/
