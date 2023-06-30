using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Compteur : MonoBehaviour
{
    public float score = 0f;
    public string scoreEcrit;

    public Text textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        scoreEcrit = score.ToString();
        textMeshPro.text = scoreEcrit;
    }
}
