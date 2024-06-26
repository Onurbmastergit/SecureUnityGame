using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public int vidaTotal = 100;
    public int vidaAtual;

    public UnityEngine.UI.Image BarLifeStatus;
     public float fillAmount;

    void Start()
    {
        vidaAtual = vidaTotal;
    }
    void Update()
    {
        fillAmount = (float)vidaAtual/vidaTotal;
        BarLifeStatus.fillAmount = fillAmount;
    }
    public void ReceberDano(int valor)
    {
        vidaAtual -= valor;
        VerificarMorte();
    }
    void VerificarMorte()
    {
        if(vidaAtual == 0)
        {
            Debug.Log("Morreu");
        }
    }
}
