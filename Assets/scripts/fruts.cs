using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruts : MonoBehaviour
{
  
    private SpriteRenderer sprite;
    private CircleCollider2D collider;

    public GameObject coletado;
    
    public int Pontos;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CircleCollider2D>();
    }


 void OnTriggerEnter2D(Collider2D collision)
 {
     if(collision.gameObject.tag == "Player")
     {
         // Desativa collider e sprite renderer do objeto
        sprite.enabled    = false;
        collider.enabled  = false;

        coletado.SetActive(true);


        //Chama o método da classe SavePoints para armazenar os pontos acumulados
        SavePoints.acesso.totalPontos += Pontos;


        SavePoints.acesso.atualizaPontosText();


        // Destrói a fumaça
        Destroy(gameObject, 0.4f);
     }
 }
}
