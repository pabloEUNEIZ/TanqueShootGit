using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI marcadorUI;
    private int marcador = 0;

    void Start()
    {
        marcadorUI.text = "Marcador="+marcador;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Obstaculo").Count()==0)
        {
            marcadorUI.text = "Juego terminado";
        }
    }

    public void AumentarMarcador()
    {
        marcador++;
        Debug.Log("Marcador="+marcador);
        marcadorUI.text = "Marcador="+marcador;
    }
}
