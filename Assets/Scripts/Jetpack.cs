using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    public int maxFuel = 4;
    public float thrustForce = 0.5f;
    public Rigidbody rbd;
    public Transform groundedTransform;

    [SerializeField]  private int curFuel;
  

    public void JetpackAct()
    {
        if (curFuel > 0)
        {
            curFuel -= 1;
            rbd.AddForce(rbd.transform.up * thrustForce, ForceMode.Impulse);

        }
       // else if (Physics.Raycast(groundedTransform.position, Vector3.down, 0.05f, LayerMask.GetMask("Grounded")) && curFuel < maxFuel)
       // {
       //     curFuel += 1;
       //
       // }
        else
        {
            
        }
    }

    void Start()
    {
        curFuel = maxFuel;
    
    }


    void Update() 
    { 
        if(curFuel == 0)
        {
            StartCoroutine(Recharge());
        }
    
    
    }

    IEnumerator Recharge()
    {
        yield return new WaitForSeconds(10);
        curFuel = maxFuel;
    }
   
}
