using UnityEngine;

public class Lekcija_1 : MonoBehaviour
{
    // one line comment
    
    /*
     multiple
     line 
     comment
     */

    // variable type / variable name / variable value
    [SerializeField] private int integer = 0;
    private string name = "vards";
    private float flaoter = 0.3f;
    private bool yesOrNo = true;

    private int a = 1;
    private int b = 2;
    private int d = 0;
    
    public void Method1() // access type / return type / name
    {
        Debug.Log("aaaaaaa");
        int c = a + b;
        Debug.Log(c);
        Debug.Log( "kkas " + c);
        Debug.Log(name);
        Debug.Log(integer);
    }
    
    public int Method2()
    {
        return d = a + b;
    }
    
    public int Method21(int e)
    {
        return d = e + b;
    }

    public void Method3()
    {
        int result = Method2(); // 0 = 1+ 2 ( a + b)
        result = result + 1; // 3 = 3 + 1
        Debug.Log(result); // 4
        Debug.Log(Method2() +2 ); // 1 + 2 + 2
        
        Debug.Log(Method21(integer));
    }

    public void Meth1()
    {
        Debug.Log("Meth1");
    }

    private void Meth2()
    {
        Debug.Log("Meth2");
    }

    void Start()
    {
        // Method3();
        uzd2("john");
        uzd2("karen");
        
        uzd3(4, 5);
        uzd3(5,6);
        uzd3(653,643);
        uzd3(523,325);

        
    }

    private void uzd1()
    {
        Debug.Log("Welcome Friends!");
        Debug.Log("Have a nice day!");
    }
    
    private void uzd2(string name)
    {
        Debug.Log("inputed : " + name);
    }
    
    private void uzd3(int x, int y)
    {
        Debug.Log(x + y);
    }
    
}

/*
1. Write a program in C# Sharp to create a user define function.
    ---Expected Output :
Welcome Friends!
    Have a nice day!

2. Write a program in C# Sharp to create a user 
    define function with parameters
    ---Test Data : Please input a name : John
    ---Expected Output :
Welcome friend John !
Have a nice day!

    3. Write a program in C# Sharp to create a function 
for the sum of two numbers.
    --- Test Data : x : 15 y: 16
    --- Expected Output : The sum of two numbers is : 31
    
*/