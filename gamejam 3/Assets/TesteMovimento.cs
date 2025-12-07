using UnityEngine;

public class TesteMovimento : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        // Pega o Rigidbody automaticamente
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 1. L� as teclas (A/D ou Setas Esquerda/Direita)
        float movimentoX = Input.GetAxisRaw("Horizontal");

        // 2. Move o personagem
        // Mant�m a velocidade Y original para a gravidade continuar funcionando
        rb.linearVelocity = new Vector2(movimentoX * velocidade, rb.linearVelocity.y);
    }
}