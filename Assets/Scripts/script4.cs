using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class script4 : MonoBehaviour
{
    public int a = 1;

    public int b = 2;

    public int c = 3;

    public int d = 4;

    private int somma = 0;
    private int prodotto = 1;
    private int media = 0;
        // Start is called before the first frame update
    void Start()
    {
        somma = a + b + c + d;
        Debug.Log("somma è" + somma);
        prodotto= a * b * c * d;
        Debug.Log("prodotto è" + prodotto);
        media = (a + b + c + d) / 4;
        Debug.Log("la media è" + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
