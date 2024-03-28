using UnityEngine;

public class RaycastCollision : MonoBehaviour
{
    public float raycastDistance = 20f;


    void Update()
    {

        // Dispara um raio para frente a partir da posição do objeto
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hitInfo; // Informações sobre o ponto de colisão

        // Verifica se o raio atinge algum objeto
        if (Physics.Raycast(ray, out hitInfo, raycastDistance))
        {
            Destroy(hitInfo.collider.gameObject);

            // Verifica se o objeto atingido tem uma tag específica
            if (hitInfo.collider.CompareTag("Player"))
            {
                Debug.Log("Você Destruiu o Cr7!");
                // Adicione aqui qualquer ação que você queira realizar quando houver colisão com o jogador
            }
        }
    }
}