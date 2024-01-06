using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSimples : MonoBehaviour
{
    float direção = 1;
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
            direção = -1;
        }
        else if(transform.position.x < -5 )
        {
            direção = 1;
        }

        transform.Translate(Vector3.right * direção * Time.deltaTime * velocidade);
    }
}
