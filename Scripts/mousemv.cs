                using System.Collections;
                using System.Collections.Generic;
                using UnityEngine;

                public class mousemv : MonoBehaviour

                {
                    float sensi = 5.0f;
                    float mouseX = -100f;
                    float mouseY = 0f;
                
                
                    void Update()
                    {
                        mouseX += Input.GetAxis("Mouse X") * sensi;
                        mouseY -= Input.GetAxis("Mouse Y") * sensi;

                        transform.eulerAngles = new Vector3(mouseY,mouseX,0);
                    }
                }