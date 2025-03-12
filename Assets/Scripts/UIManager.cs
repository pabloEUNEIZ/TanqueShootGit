using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TMPro.TextMeshProUGUI marcadorUI;
    private int marcador = 0;

    void Start()
    {
        marcadorUI.text = "Marcador="+marcador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarMarcador()
    {
        marcador++;
        Debug.Log("Marcador="+marcador);
        marcadorUI.text = "Marcador="+marcador;
    }
}
