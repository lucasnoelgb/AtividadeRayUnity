        using UnityEngine;

        public class RaycastCollision : MonoBehaviour
        {
            public float raycastDistance = 20f;


            void Update()
            {

                Ray ray = new Ray(transform.position, transform.forward);
                RaycastHit hitInfo; 

                if (Physics.Raycast(ray, out hitInfo, raycastDistance))
                {
                    Destroy(hitInfo.collider.gameObject);

                    if (hitInfo.collider)
                    {
                        Debug.Log("Voc� Destruiu o Cr7!");
                    }
                }
            }
        }
        