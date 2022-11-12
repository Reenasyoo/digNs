using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LekcijaDivi : MonoBehaviour
{

    private int guesableNumber = 0;

    [SerializeField] private int inputNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Method7(40);
        // Method7(15);
        // Method7(90);

        guesableNumber = Random.Range(0, 100);
    }

    private void Method1()
    {
        if (1 < 2)
        {
            Debug.Log("yes");
        }
    }
    
    private void Method2()
    {
        int x = 5;
        int y = 4;
        
        if (x < y)
        {
            Debug.Log("yes");
        }
    }
    
    private void Method3()
    {
        int x = 5;
        int y = 4;
        
        if (x < y)
        {
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("no");
        }
    }
    
    private void Method4()
    {
        int x = 5;
        int y = 4;
        
        if (x < y)
        {
            Debug.Log("yes");
        }
        else if (x == y)
        {
            Debug.Log("equal");
        }
        else
        {
            Debug.Log("no");
        }
    }

    private void Method5()
    {
        bool canJump = false;
        bool isGrouned = true;

        if (isGrouned)
        {
            canJump = true;
        }

        if (canJump)
        {
            Debug.Log("can");
        }
    }
    
    private void Method6()
    {
        bool canJump = false;
        bool isGrouned = true;

        if (isGrouned && !canJump)
        {
            Debug.Log("can");
        }
        if (isGrouned || !canJump)
        {
            Debug.Log("can");
        }
    }

    private void Method7(int age)
    {
        Printsmth(age.ToString());
        
        if (age < 18)
        {
            Debug.Log("free candy");
        }
        else if( age > 70)
        {
            Debug.Log("too old");
        }
        else
        {
            Debug.Log("propper");
        }
    }

    private void Printsmth(string smth)
    {
        Debug.Log(smth);
    }

    public void GuessingGame()
    {
        if (guesableNumber == inputNumber)
        {
            Debug.Log("You won");
        }
        else
        {
            if (guesableNumber > inputNumber)
            {
                Debug.Log("too low");
            }
            else
            {
                Debug.Log("to high");
            }
        }
    }
    
}
/*
1. Divisible by 2 or 3
Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, 
otherwise returns their sum.
Expected input and output
DivisibleBy2Or3(15, 30) → 450
if (( x % 2) == 0) 
if(( x % 3) == 0 )


2. If greater than third one
Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers 
is greater than third one.
Expected input and output
IfGreaterThanThirdOne([2, 7, 12]) → true


3. If number is even
Given an integer, write a method that checks if it is even.
Expected input and output
IfNumberIsEven(721) → false

--- if(( x % 2 ) == 0)
*/

// > < >= <= == !=