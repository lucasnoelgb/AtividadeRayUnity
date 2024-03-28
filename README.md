# AtividadeRayUnity

# Como Fizemos
-Primeiramente tivemos a ideia de fazer uma cena onde o player teria que olha para o shampoo do cristiano ronaldo e o destroi-lo após isso foi feito o cenário e ativando a função "Ingnore RayCast"

# Prefabs 
-Esses foram os prefabs ultilizados para compor nosso cenários sendo um deles acoplado a câmera fazendo o que ele tenha a mesma movimentação da propria.

![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/d53a7ef6-e78b-480a-a304-f3abd081ed21)![image](https://github.com/lucasnoelgb/AtividadeRayUnity/assets/129121307/5b1b2d19-9df0-4309-be58-418c850e48b3)


## Codigo do RayCast e do Destroy

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

## Codigo para Mover o mouse
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        public class mousemove : MonoBehaviour
        {
            //enumerador com os eixos de Rotação
            public enum RotationAxes
            {
                MouseXAndY = 0,
                MouseX = 1,
                MouseY = 2
            }
            //instancia o enum
            public RotationAxes axes = RotationAxes.MouseXAndY;
            //instancia os valores de rotação
            public float sensitivityHor = 5.0f;
            public float sensitivityVert = 5.0f;
            //minimo e máximos
            public float minimumVert = -45.0f;
            public float maximumVert = 45.0f;
            //valor inicial
            private float _rotationX = 0;
            void Start()
                    {
                //verifica se o componente existe
                Rigidbody body = GetComponent<Rigidbody>();
                if (body != null)
                    body.freezeRotation = true;
            }

            // Update is called once per frame
            void Update()
            {
                if (axes == RotationAxes.MouseX)
                {
                    transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
                }
                else if (axes == RotationAxes.MouseY)
                {
                    _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                    _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
                    float rotationY = transform.localEulerAngles.y;
                    //rotação pelo angulo 
                    transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
                }
                else
                {
                    _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                    _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
                    float delta = Input.GetAxis("Mouse X") * sensitivityHor;
                    float rotationY = transform.localEulerAngles.y + delta;
                    transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
                }        
            }
        }
## Game Play
