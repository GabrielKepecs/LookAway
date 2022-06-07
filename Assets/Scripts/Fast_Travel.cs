using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast_Travel : MonoBehaviour
{
    public Transform Teleport;
    public GameObject thePlayer;
    
    
    public void FastTravel()    
    {
        thePlayer.transform.position = Teleport.transform.position;    
    }

   
    void Update()
    {
        
    }
}
