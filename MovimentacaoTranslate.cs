using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoTranslate : MonoBehaviour
{
    float velocidade;


    private void Start()
    {
        velocidade = 5f;
    }
    void Update()
    {
        float InputHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(InputHorizontal * velocidade * Time.deltaTime, 0, 0));
    }
}
