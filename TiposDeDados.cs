using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiposDeDados : MonoBehaviour
{

    // Tipos de dados primitivos
    int numeroInteiro = 1;
    float numeroPontoFlutuante = 1.0f;
    bool booleana = true;
    string variavelString = "nome";

    // Listas
    List<string> inventario = new List<string>()
    {
        "Item 1",
        "Item 2",
        "Item 3",
        "Item 4",
    };
    List<Vector2> posicoes = new List<Vector2>()
    {
        new Vector2(0,0),
        new Vector2(1,0),
        new Vector2(0,1),
        new Vector2(1,1),
    };
}
