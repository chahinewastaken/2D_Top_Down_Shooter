using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
    public int[] numbers = {1,2,3,4,5};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numbers);
        for(int a=0; a<numbers.Length ; a++){
            numbers[a] += a;
        }
        Debug.Log(numbers);
    }




}
