# AtividadeRayUnity
desativar o box colider de objetos que nao serão ativigidos

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

# Codigo de Mover o mouse
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

