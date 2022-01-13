using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField InputFieldEingabe1, InputFieldEingabe2;
    [SerializeField] private Text txtResult;
    public bool testing;

    public int  CheckAddition(int summandA, int summandB)
    {
        int result = 0;
        testing = false;
        result = summandA + summandB;
        Debug.Log(result);

        return result;
    }

    void Start()
    {
        int val1=CheckAddition(1, 2);
        int val2=CheckAddition(10, 20); 
        int val3=CheckAddition(100, 200);

        Debug.Log("val1: " + val1 + "val2 + val3" + (val1 + val2));
        Debug.Log("Nach Methodenaufruf sg. call");

       
    }

    public void GetValues()
    {
        string eingabe1, eingabe2;
        eingabe1 = InputFieldEingabe1.text; 
        eingabe2 = InputFieldEingabe2.text;

        Debug.Log("Methode GetValues wird ausgeführt: " + CheckAddition(int.Parse(eingabe1), int.Parse(eingabe2)));

    }

    // Update is called once per frame
    void Update()
    {
        if (testing)
        {
            GetValues();
        }
      
    }    
}
