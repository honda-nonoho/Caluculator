using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainController : MonoBehaviour
{
    //123...string型
    private string StringNumber = "";
    //TextUI 
    public Text TextNumber;
    //数字の型(float:小数)
    private float FloatNumber = 0.0f;
    
    //enum(列挙型)
    private CALCULATOR Calculator;
    private enum CALCULATOR
    {
         NONE = 0,
        PLUS = 1,
        MINUS = 2,
        TIMES = 3,
        DIVIDED = 4
    }

    public void OnClickNumber(int n = 0)
    {
        //Text.text = String += int.ToString
        TextNumber.text = StringNumber += n.ToString();
        Debug.Log(TextNumber);
    }
    //足し算
    public void OnClickPlus()
    {
        Calculator = CALCULATOR.PLUS;  //このCalculatorは、enum[CALCULATOR]の PLUS(1)
        CalculatorType();
    }

    //引き算
    public void OnClickMinus()
    {
        Calculator = CALCULATOR.MINUS;  //このCalculatorは、enum[CALCULATOR]の MINUS(2)
        CalculatorType();
    }

    //掛け算
    public void OnClickTimes()
    {
        Calculator = CALCULATOR.TIMES;  //このCalculatorは、enum[CALCULATOR]の TIMES(3)
        CalculatorType();
    }

    //割り算
    public void OnClickDivided()
    {
        Calculator = CALCULATOR.DIVIDED;  //このCalculatorは、enum[CALCULATOR]の DIVIDED(4)
        CalculatorType();
    }

    //条件分岐
    public void CalculatorType()
    {
        switch(Calculator)
        {
            case CALCULATOR.PLUS:
            if(StringNumber == "") StringNumber = "0"; //もしstring肩にテキストがなにも入らないのなら０と表示する
            FloatNumber += float.Parse(StringNumber);  //float型 += float.Parse(String型)  //Parse 
            break;



        }
    }
}
