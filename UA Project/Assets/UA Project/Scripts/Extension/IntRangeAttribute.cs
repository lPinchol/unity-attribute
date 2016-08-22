/// Place anywhere in your unity project
/// Code => https://gist.github.com/HilariousCow/560db765cf24eb589b00
/// Autor: HilariousCow

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IntRangeAttribute : PropertyAttribute
{
    public int MinLimit, MaxLimit;

    public IntRangeAttribute(int minLimit, int maxLimit)
    {
        this.MinLimit = minLimit;
        this.MaxLimit = maxLimit;
    }
}

[System.Serializable]
public class IntRange
{
    public int RangeStart, RangeEnd;

    private int GetRandomValue()
    {
        return Random.Range(RangeStart, RangeEnd);
    }

    public static implicit operator int(IntRange d) 
    {
        return d.GetRandomValue();
    }

}