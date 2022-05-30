using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// bibliotecas inseridas por mim para funcionamento do
using UnityEngine.UI;
using UnityEngine.SceneManagement; //biblioteca para gerenciamento da cena

public class SavePoints : MonoBehaviour
{
    public int totalPontos;
    public Text contador;

    public GameObject gameOver;

    //Cria um método estático para dar acesso à esta classe
    public static SavePoints acesso;
    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
    }


    public void atualizaPontosText() => contador.text = totalPontos.ToString();

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string level)
    {
        SceneManager.LoadScene(level);
    } 

    


}
