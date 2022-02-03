using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField InputFieldEingabe1, InputFieldEingabe2;
    [SerializeField] private Text textResult;
    [SerializeField] private GameObject resetBtn;
    private int termA, termB;





    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;


        result = summandA + summandB;


        textResult.text = string.Format("{0}", result);

        return result;
    }



    public void GetValues()
    {
        try
        {
            termA = int.Parse(InputFieldEingabe1.text);
        }
        catch (System.Exception)
        {
            InputFieldEingabe1.GetComponent<InputField>().image.color = Color.red;
            InputFieldEingabe1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            InputFieldEingabe1.text = "";
        }

        try
        {
            termB = int.Parse(InputFieldEingabe2.text);
        }
        catch (System.Exception)
        {
            InputFieldEingabe2.GetComponent<InputField>().image.color = Color.red;
            InputFieldEingabe2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            InputFieldEingabe2.text = "";
        }
        termA = int.Parse(InputFieldEingabe1.text);
        termB = int.Parse(InputFieldEingabe2.text);

        textResult.text = CheckAddition(termA, termB).ToString();


        Debug.Log("Methode GetValues wird ausgeführt:" + CheckAddition(termA, termB));
    }

    public void ResetBtn()
    {

        InputFieldEingabe1.text = "";
        InputFieldEingabe2.text = "";
        textResult.text = "result";
        termA = 0;
        termB = 0;
        InputFieldEingabe1.GetComponent<InputField>().image.color = Color.white;
        InputFieldEingabe2.GetComponent<InputField>().image.color = Color.white;
        InputFieldEingabe1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben...";
        InputFieldEingabe2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben...";
    }


}

