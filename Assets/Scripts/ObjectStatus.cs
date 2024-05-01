using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class ObjectStatus : MonoBehaviour
{   
    public int vidaAtual;
    float fillAmount;
   public int vidaTotal;
   public UnityEngine.UI.Image vidaObject;
   public VfxColor color;

    private void Start()
   {
    vidaAtual = vidaTotal;
    color = gameObject.GetComponent<VfxColor>();
   }
   void Update()//teste
   {
    fillAmount = (float)vidaAtual/vidaTotal;
    vidaObject.fillAmount = fillAmount;
    color.ChangeColor();
   }
   public void ReceberDano(int dano)
   {
    vidaAtual -= dano;

    //Atualiza A vida no canvas
    fillAmount = (float)vidaAtual/vidaTotal;
    vidaObject.fillAmount = fillAmount;

    //Atualiza a cor da barra de vida de acordo com a quantidade de vida
    color.ChangeColor();

     VerificarMorte();
   }
   void VerificarMorte()
   {
    if(vidaAtual <= 0)
    {
        transform.gameObject.GetComponent<Collider>().enabled = false;
        Destroy(gameObject);
    }
   }
}