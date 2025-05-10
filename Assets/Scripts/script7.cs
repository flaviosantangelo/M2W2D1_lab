using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script7 : MonoBehaviour
{
    public int partenza;
    private int i = 0;
    void Start()
    {
        Debug.Log("il numero di partenza è" + partenza);
        Stampa2Precedenti(partenza);
    }
    public int Stampa2Precedenti(int partenza)
    {
        while (i < 2)
        {
            partenza--;
            Debug.Log(partenza);
            i++;
        }
        return partenza;
    }
}
