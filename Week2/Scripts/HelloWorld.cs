using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class HelloWorld : MonoBehaviour
{

    void BolenleriBul(int numOne, int numTwo)
    {
        ArrayList listOne = new ArrayList();
        ArrayList listTwo = new ArrayList();
        ArrayList listThree = new ArrayList();
        ArrayList listFour = new ArrayList();
        ArrayList listFive = new ArrayList();
        for (int i = numOne; i <= numTwo; i++)
        {
            if (i % 1 == 0)
            {
                listOne.Add(i);
            }
            if (i % 2 == 0) 
            {
                listTwo.Add(i);
            }
            if (i % 3 == 0)
            {
                listThree.Add(i);
            }
            if (i % 4 == 0)
            {
                listFour.Add(i);
            }
            if (i % 5 == 0)
            {
                listFive.Add(i);
            }
        }
        string resultStringOne = "1'e bölünenler: ";
        foreach (int i in listOne)
             {
                resultStringOne += i + "-";
             }
        print(resultStringOne);
        
        string resultStringTwo = "2'ye bölünenler: ";
        foreach (int i in listTwo)
        {
            resultStringTwo += i + "-";
        }
        print(resultStringTwo);

        string resultStringThree = "3'e bölünenler: ";
        foreach (int i in listThree)
        {
            resultStringThree += i + "-";
        }
        print(resultStringThree);

        string resultStringFour = "4'e bölünenler: ";
        foreach (int i in listFour)
        {
            resultStringFour += i + "-";
        }
        print(resultStringFour);

        string resultStringFive = "5'e bölünenler: ";
        foreach (int i in listFive)
        {
            resultStringFive += i + "-";
        }
        print(resultStringFive);

    }
   
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {

        BolenleriBul(21, 55);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
