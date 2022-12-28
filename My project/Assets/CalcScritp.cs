using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.UIElements;

public class CalcScritp : MonoBehaviour
{
    [SerializeField] public Text text_1, text_2;
    [SerializeField] public InputField input_Value_1, input_Value_2, input_Value_3;
    private double answer;

    public void Start()
    {     

    }

    public void onPress(string buttonName)
    {     
       text_2.text = buttonName;
    }

    public void Update()
    {

        if (input_Value_1.text != "" && input_Value_2.text != "" && text_2.text == "?")
        {
            text_1.text = "Осталось выбрать действие";
        }
        else if (input_Value_1.text != "" && input_Value_2.text != "" && text_2.text != "?")
        {
            text_1.text = "Расчет произведен!";
            if (Convert.ToString(text_2.text) == "+")
            {
                answer = Convert.ToDouble(input_Value_1.text) + Convert.ToDouble(input_Value_2.text);
            } 
            else if (Convert.ToString(text_2.text) == "-")
            {
                answer = Convert.ToDouble(input_Value_1.text) - Convert.ToDouble(input_Value_2.text);
            }
            else if (Convert.ToString(text_2.text) == "*")
            {
                answer = Convert.ToDouble(input_Value_1.text) * Convert.ToDouble(input_Value_2.text);
            }
            else if (Convert.ToString(text_2.text) == "/")
            {
                answer = Convert.ToDouble(input_Value_1.text) / Convert.ToDouble(input_Value_2.text);
            }

            input_Value_3.text = Convert.ToString(answer);
        }
        else if ((input_Value_1.text == "" || input_Value_2.text == "") && text_2.text != "?")
        {
            text_1.text = "Осталось заполнить поля (десятичные через , )";
        }
    }
}
