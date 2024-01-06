using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSimples : MonoBehaviour
{
    float dire��o = 1;
    float velocidade;
    
    void Start()
    {
        velocidade = 5f;    
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 5 )
        {
            dire��o = -1;
        }
        else if(transform.position.x < -5 )
        {
            dire��o = 1;
        }

        transform.Translate(Vector3.right * dire��o * Time.deltaTime * velocidade);
    }
}
