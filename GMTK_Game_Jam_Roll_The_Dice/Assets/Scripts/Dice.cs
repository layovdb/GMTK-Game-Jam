using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    int _top;
    int _bottom;
    int _left;
    int _right;
    int _front;
    int _back;
    
    void OnMouseRight()
    {
        _top = _left;
        _right = _top;
        _bottom = _right;
        _left = _bottom;
    }
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
    }

}
