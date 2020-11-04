using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainController : MonoBehaviour
{
    //String型(文字)
    private string  ClickNumber = "";
    //Text(表示)
    public Text TextNumber;
    //数字float型(数字)
    private float ResultNumber = 0.0f;

    

    private CALCULATOR Calculator;
    private enum CALCULATOR 
    {
        
    }

    //表示する（ResultObjct) = ClickNumber(String) nはintでToStringメゾットで値を渡す

     public void OnClickNumber(int n = 0)
     {
         TextNumber.text = ClickNumber += n.ToString();
  
        Debug.Log(TextNumber);
    }
    //足し算
    public void OnClickPlus()
    {
        Calculator = CALCULATOR.PLUS;
        CaluculatorType();
        Debug.Log("Plus");
    }

    //引き算
    public void OnClickMinus()
    {
        Calculator = CALCULATOR.MINUS;
        CaluculatorType();
        Debug.Log("ClickNumber : " + ClickNumber);
    }

    //掛け算
    public void OnClickTimes()
    {
        Calculator = CALCULATOR.TIMES;
        CaluculatorType();
        Debug.Log("ClickNumber : " + ClickNumber);
    }

    //割り算
    public void OnClickDivied()
    {
        Calculator = CALCULATOR.DIVIDED;
        CaluculatorType();
        Debug.Log("ClickNumber : " + ClickNumber);
    }

    //条件分岐
    public void CaluculatorType()
    {
        switch(Calculator)
        {
            //足し算
            case CALCULATOR.PLUS:
            //中身が何もない場合は0を設定
            if(ClickNumber == "") ClickNumber = "0";
            ResultNumber += float.Parse(ClickNumber);
            break;


 
            //引き算
            case CALCULATOR.MINUS:
            if(ResultNumber > 0)
            {
                ResultNumber -= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;

            

            //掛け算
            case CALCULATOR.TIMES:
            if(ResultNumber > 0)
            {
                ResultNumber *= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;
            
            //割り算f
            case CALCULATOR.DIVIDED:
            if(ResultNumber > 0)
            {
                ResultNumber /= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;


            
        }
        Debug.Log("ResltNumber : " + ResultNumber);
        Debug.Log("ClickNumber : " + ClickNumber);
        //string表示する数
        ClickNumber = "";
    }


    //=ボタンの処理 
    public void OnClickResult()
    {
        switch(Calculator)
        {
            //足し算
            case CALCULATOR.PLUS:
            if(ClickNumber == "") ClickNumber = "0";
            ResultNumber += float.Parse(ClickNumber);
            break;
 
            //引き算
            case CALCULATOR.MINUS:
            if(ResultNumber > 0)
            {
                ResultNumber -= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;

             //掛け算
            case CALCULATOR.TIMES:
            if(ResultNumber > 0)
            {
                ResultNumber *= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;
            
            //割り算
            case CALCULATOR.DIVIDED:
            if(ResultNumber > 0)
            {
                ResultNumber /= float.Parse(ClickNumber);
            }else{
                ResultNumber = float.Parse(ClickNumber);
            }
                break;
        }
        //ResultObjectに表示する時はstringで渡す
        TextNumber.text = ResultNumber.ToString();
        Debug.Log(ResultNumber);
    }

    //クリアボタン(ACObject)
    public void OnClickAC()
    {
        //計算結果の値(float)
        ResultNumber = 0;
        //クリックした数字(string)
        ClickNumber = "";

        //enum

        Calculator = CALCULATOR.NONE;
        //計算結果の表示(text)
        TextNumber.text = "0";
        Debug.Log("ResultNumber : " + ResultNumber);
        Debug.Log("ClickNumber : " + ClickNumber);

    }
}

