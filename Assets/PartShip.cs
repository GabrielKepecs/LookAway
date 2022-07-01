using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartShip : MonoBehaviour
{
    public GameObject Ship;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Ship.GetComponent<FixShip>().partesEncontradas += 1;
            Destroy(gameObject);
        }

    }
}
