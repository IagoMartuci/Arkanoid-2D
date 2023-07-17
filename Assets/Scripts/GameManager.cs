using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Para reconher comandos de recarregamento de cena
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int quantidadeBlocos;
    // Opção de adicionar o som dos blocos no GameManager
    public AudioSource somBloco;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            ReiniciarJogo();

        if (Input.GetKeyDown(KeyCode.Escape))
            SairDoJogo();
    }

    public void AdicionarBloco()
    {
        quantidadeBlocos += 1;
    }

    public void RemoverBloco()
    {
        quantidadeBlocos -= 1;
        somBloco.Play();

        if (quantidadeBlocos == 0)
            PassarDeFase();
    }

    public void PassarDeFase()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(0);
    }

    private void ReiniciarJogo()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // OU
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void SairDoJogo()
    {
        Application.Quit();
        // Mensagem que aparece no console da Unity
        Debug.Log("Saiu do jogo!");
    }
}
