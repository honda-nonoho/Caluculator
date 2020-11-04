using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleController : MonoBehaviour
{

    //int.strin型の指定　
    public int Number = 0;
    public float Number2  =  0;
    //テキストがstringであることの指定
    public string text =  "";
    public Text TextNumber;

    //クリックした数字がstring型である指定
    private string ClickNunber = "";
    //計算で表示する数字
    private int cacheNumber = 0;


    //enumをする変数名
    private CALCULATOR Calculator;
    //enum（上で宣言したもの）
     private enum CALCULATOR{
        NONE = 0,
        PLUS = 1,
        MINUS = 2,
    }

　　//各数字のメゾット
    public void OnClickTest(int n = 0)
    {
        //ToString>n（０）に押した数字を足して表示
        ClickNunber += n.ToString(); 
        //テキストとして扱う
        TextNumber.text = ClickNunber;
        Debug.Log(ClickNunber);
    }

    //+の時の処理
    public void OnClickPlus()
    {
        //enumで宣言したもの
        Calculator = CALCULATOR.PLUS;
        //下記のメゾットを使う
        this.CalculatorType();
    }

    //計算式のメゾット→各のメゾット内へ
    private void CalculatorType(){

        //switch文
        switch(Calculator){
            case CALCULATOR.PLUS:
            //計算する数字（cacheNumber) をstringでParseで渡す
            cacheNumber += int.Parse(ClickNunber);
                break;
            //マイナスの表示
            case CALCULATOR.MINUS:
            cacheNumber -= int.Parse(ClickNunber);
                break;
        }
        ClickNunber = "";

    }
    //結果の処理
    public void OnEnter (){
        switch(Calculator){
            case CALCULATOR.PLUS:
                cacheNumber += int.Parse(ClickNunber);
                break;
            case CALCULATOR.MINUS:
             cacheNumber -= int.Parse(ClickNunber);
                break;
        }
        //テキストをStringで渡す
        TextNumber.text = cacheNumber.ToString();
    }


}