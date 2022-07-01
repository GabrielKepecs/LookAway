using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixShip : MonoBehaviour
{
    public int partesEncontradas = 0;
    public GameObject botaoLua;
    public Text Partes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        botaoLua.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Partes.text = "Achar Partes " + partesEncontradas.ToString() + " /6";

        if (partesEncontradas == 5)
        {
            Partes.text = "você achou todas as partes neste planeta, vá para a lua para achar a ultima!";
            botaoLua.SetActive(true);

        }
    }
}
