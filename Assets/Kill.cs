using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Código original 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collision)
  {
    SceneManager.LoadScene(0);
  }
}
*/











public class Kill : MonoBehaviour
{
    public GameObject deathScreen; // Tela de morte opcional
    public float restartDelay = 0.025f; // Reduzindo o tempo de atraso antes de reiniciar a cena para 0.5 segundos

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verifique se o jogador colidiu
        {
            if (deathScreen != null)
            {
                deathScreen.SetActive(true); // Ative a tela de morte se ela existir
            }
            
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector2.zero; // Pare o movimento do jogador
                playerRb.isKinematic = true; // Torne o Rigidbody cinemático para parar todas as físicas
                playerRb.simulated = false; // Desative a simulação do Rigidbody para impedir que o jogador se mova
            }

            StartCoroutine(RestartGame());
        }
    }

    private IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(restartDelay); // Adiciona um atraso antes de reiniciar a cena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Recarrega a cena atual
    }
}