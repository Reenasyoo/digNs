using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LekcijaCetri : MonoBehaviour
{
    void Start()
    {
        // MethodOne();
        // MethodTwo();
        // MethodThree();
        // MethodSeven();
        // MethodEight();
        // MethodNine();
        // MethodTen();
        MethodEleven();
    }

    private void MethodOne()
    {
        int loop = 0;

        while(loop < 5)
        {
            Debug.Log(loop);
            loop++;
            // loop +=2;
        }
    }

    private void MethodTwo()
    {
        int loop = 0;

        do
        {
            Debug.Log(loop);
            loop++;
        } while ( loop < 5);
    }

    private void MethodThree()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    private void MethodFour()
    {
        int i;

        for(i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    private void MethodFive()
    {
        int i;
        int lenght = 5;

        for(i = 0; i < lenght; i++)
        {
            Debug.Log(i);
        }
    }

    private void MethodSix()
    {
        int i;
        int lenght = 5;

        for(i = 0; i < lenght; i += 2)
        {
            Debug.Log(i);
        }
    }

    private void MethodSeven()
    {
        for(int i = 5; i > 0; i--)
        {
            Debug.Log(i);
        }
    }

    private void MethodEight()
    {
        for(int i = 0; i < 10; i++)
        {
            if( i == 3)
            {
                continue;
            }

            Debug.Log(i);
        }
    }

    private void MethodNine()
    {
        for(int i = 0; i < 10; i++)
        {
            if( i == 5)
            {
                break;
            }

            Debug.Log(i);
        }
    }

    private void MethodTen()
    {
        int[] intBox = {0,2,5,6};
        Debug.Log("Lenght: " + intBox.Length);

        for(int i = 0; i < intBox.Length; i++)
        {
            Debug.Log(intBox[i]);
        }

        // Debug.Log(intBox[3]);
    }

    private void MethodEleven()
    {
        int[] intBox = {0,2,5,6};
        Debug.Log("Lenght: " + intBox.Length);

        foreach(int index in intBox)
        {
            Debug.Log(index);
        }
    }

    private void MethodTwelve()
    {
        // List<int> intBox2 = new List<int>();
        List<int> intBox = new List<int> {0,2,5,6};
        Debug.Log("Lenght: " + intBox.Count);

        foreach(int index in intBox)
        {
            Debug.Log(index);
        }
    }
}

/*
1 . Print the numbers in the following format up to a given number .
2 4 6 8 10( ar while loop)

2. Write a program in C# Sharp to display the first 10 natural numbers. 

Expected Output :
1 2 3 4 5 6 7 8 9 10 ( ar for loop )


3. Write a C# Sharp program to find the sum of first 10 natural numbers.

Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55 ( ar for loop )
*/

/*
 loop ++;
 loop += 1;
 loop = loop +1;

 loop += 2;
 loop = loop +2;

*/
