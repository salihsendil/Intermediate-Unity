using System;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    int _a;
    int _counter;

    public delegate void EmptyDelegate();
    public EmptyDelegate emptyDelegateFunction;

    public delegate bool BoolDelegate(float f);
    public BoolDelegate boolDelefateFunction;

    //void döndürür
    private Action emptyAction;
    private Action<int> intAction;

    //void veya deðer döndürür
    //generic içi son yazýlan deðer döndürdüðü, sondan öncekiler parametre
    private Func<int> emptyFunc;
    private Func<float, float, bool> paramFunc;


    void Start()
    {
        emptyDelegateFunction = () =>
        {
            FirstEmptyDelegate();
            Debug.Log("Lambda Expression: " + ReturnRealWorkTime());
        };

        emptyDelegateFunction += delegate ()
        {
            SecondEmptyDelegate();
            Debug.Log("Anonymous Method!: " + ReturnRealWorkTime());
        };

        //emptyDelegateFunction = FirstEmptyDelegate;
        //emptyDelegateFunction += SecondEmptyDelegate;
        emptyDelegateFunction();

        boolDelefateFunction += TestingBooleanDelegate;
        Debug.Log(boolDelefateFunction(3.2f) + ": " + ReturnRealWorkTime());

        emptyAction = () =>
        {
            Debug.Log("Empty action worked!: " + ReturnRealWorkTime());
            _a = 5;
        };
        emptyAction();

        intAction = (int i) =>
         {
             Debug.Log("Parameter Action worked!: " + ReturnRealWorkTime());
             _a = i / 2;
         };
        intAction(16);

        emptyFunc = () => 24;
        Debug.Log("Empty Func worked! : " + emptyFunc);

        paramFunc = (float f, float t) =>
        {
            return f * t > 50;
        };
        Debug.Log("Param-Return Func worked!: " + paramFunc(6, 7));
    }


    void Update()
    {
        while (_counter < 5)
        {
            Debug.Log(_a);
            _counter++;
        }
    }

    private void FirstEmptyDelegate()
    {
        Debug.Log("My first empty delegate");
    }

    private void SecondEmptyDelegate()
    {
        Debug.Log("My second empty delegate");
    }

    private bool TestingBooleanDelegate(float fl)
    {
        return fl > 2.5f;
    }

    private float ReturnRealWorkTime()
    {
        return Time.realtimeSinceStartup;
    }

}
