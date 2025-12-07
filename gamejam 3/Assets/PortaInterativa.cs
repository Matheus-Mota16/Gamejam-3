using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaInterativa : MonoBehaviour
{
    [Header("Configurações")]
    public string nomeDaCena; // Nome da cena para onde vai
    public KeyCode teclaDeInteracao = KeyCode.E; // Tecla para entrar (Pode mudar para F, Enter, etc.)

    private bool playerEstaNaPorta = false; // "Interruptor" que sabe se o player está perto

    void Update()
    {
        // Verifica a todo momento: O player está na porta? E apertou a tecla?
        if (playerEstaNaPorta && Input.GetKeyDown(teclaDeInteracao))
        {
            SceneManager.LoadScene(nomeDaCena);
        }
    }

    // Quando o player ENTRA na área da porta
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerEstaNaPorta = true;
            Debug.Log("Pressione " + teclaDeInteracao + " para entrar!");
        }
    }

    // Quando o player SAI da área da porta
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerEstaNaPorta = false;
        }
    }
}