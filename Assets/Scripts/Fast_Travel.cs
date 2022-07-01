using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fast_Travel : MonoBehaviour
{
    public Transform Teleport;
    public GameObject thePlayer;
    
    
    public void FastTravel()    
    {
        thePlayer.transform.position = Teleport.transform.position;    
    }

    public void MoonTravel()
    {
        SceneManager.LoadScene("Moon");
    }

   
    void Update()
    {
        
    }
}
