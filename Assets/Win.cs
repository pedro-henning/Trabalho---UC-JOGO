using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winScreen.SetActive(true);
        StartCoroutine(RestartGame());
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(2); // Adiciona um atraso de 2 segundos
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
