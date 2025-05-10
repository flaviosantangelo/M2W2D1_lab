using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class script6 : MonoBehaviour
{
    public int partenza;
    private int i = 0;

    void Start()
    {
        Debug.Log("il numero di partenza è" + partenza);
        Stampa2Successivi(partenza);
    }

public int Stampa2Successivi(int partenza)
    {
        while (i < 2)
        {
            partenza++;
            Debug.Log(partenza);
            i++;
        }
        return partenza;
    }



}
