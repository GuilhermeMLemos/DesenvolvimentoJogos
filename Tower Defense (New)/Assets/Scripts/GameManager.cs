using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI; //referencia ao objeto de UI do game over
    
    /*como GameIsOver e variavel estatica, quando ela e alterada no final do jogo,
    ela nao e alterada e sera passada como true na proxima scene, gerando um erro
    por isso e criado um metodo Start para setar essa variavel como false todo inicio de cada scene*/
    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameIsOver)  //testando se o jogo terminou
            return;
        
        if(Input.GetKeyDown("e"))  //tecla para terminar o jogo antes da hora
        {
            EndGame();
        }

        if(PlayerStats.Lives <= 0) //teste se a vida chegou a zero
        {
            EndGame();
        }
    }

    void EndGame() //finalizar jogo
    {
        GameIsOver = true;
        gameOverUI.SetActive(true); //ativando o UI do game over
    }
}
