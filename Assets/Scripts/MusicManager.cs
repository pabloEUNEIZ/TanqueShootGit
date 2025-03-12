using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource miaudio;
    //  public GestionObstaculo GO;

    // void OnEnable()
    // {
    //     if (GO != null)
    //     {
    //         GO.OnColisionDeBala.AddListener(ReproducirMusica);
    //     }
    // }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReproducirMusica()
    {
        miaudio.Play();
    }
}
