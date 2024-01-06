using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoMoveTowards : MonoBehaviour
{
    Vector2 destino = new Vector2(5,5);
    float velocidade = 2f;
    

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position,destino,Time.deltaTime*velocidade);
     
    }
}
