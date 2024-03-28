using UnityEngine;

public class RaycastCollision : MonoBehaviour
{
    public float raycastDistance = 20f;


    void Update()
    {

        // Dispara um raio para frente a partir da posi��o do objeto
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hitInfo; // Informa��es sobre o ponto de colis�o

        // Verifica se o raio atinge algum objeto
        if (Physics.Raycast(ray, out hitInfo, raycastDistance))
        {
            Destroy(hitInfo.collider.gameObject);

            // Verifica se o objeto atingido tem uma tag espec�fica
            if (hitInfo.collider.CompareTag("Player"))
            {
                Debug.Log("Voc� Destruiu o Cr7!");
                // Adicione aqui qualquer a��o que voc� queira realizar quando houver colis�o com o jogador
            }
        }
    }
}