using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    public float radious;

    // public LayerMask nos permite referenciar uma layer que a gente tenha criado
    public LayerMask playerLayer;

    private DialogueControl dc;
    bool onRadious;

    private void Start()
    {
        // Quando vc inicializa o jogo o FindObjectOfType vai procurar na cena algum objeto que tenho o DialogueControl anexado
        dc = FindObjectOfType<DialogueControl>();
    }

    public void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onRadious)
        {
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    // Vai ser a interação do NPC com o player
    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if(hit != null)
        {
            onRadious = true;
        }
        else
        {
            onRadious = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Vai desenhar uma esfera na janela da cena e vai passar como parametro a posição do objeto e o raio que é o mesmo da esfera de colisção dalí de cima
        Gizmos.DrawWireSphere(transform.position, radious);
    }

}
