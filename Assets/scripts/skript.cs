using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skript : MonoBehaviour
{

    public float NumSum1;
    public float NumSum2;
    [HideInInspector]
    public float ResultSum;

    [Space]
    public float NumDiff1;
    public float NumDiff2;
    [HideInInspector]
    public float ResultDiff;

    [Space]
    public float NumDivi1;
    public float NumDivi2;
    [HideInInspector]
    public float ResultDivi;

    [Space]
    public float NumMult1;
    public float NumMult2;
    [HideInInspector]
    public float ResultMult;


    void Start()
    {
        sum();
        diff();
        divi();
        mult();
    }
    private void sum()
    {
        ResultSum = NumSum1 + NumSum2;
        Debag.Log(ResultSum);
    }
    private void diff()
    {
        ResultDiff = NumDiff1 - NumDiff2;
        Debag.Log(ResultDiff);
    }
    private void divi()
    {
        ResultDivi = NumDivi1 / NumDivi2;
        Debag.Log(ResultDivi);
    }
    private void mult()
    {
        ResultMult = NumMult1 * NumMult2;
        Debag.Log(ResultMult);
    }


}
