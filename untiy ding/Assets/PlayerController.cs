using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(EnemyStats))]
public class PlayerController : MonoBehaviour {

    public Interactable focus;
    public LayerMask movementMask;

    Camera cam;
    // Use this for initialization
    void Start() {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                //Move our player to what we hit

                //Stop focusing any objects
                RemoveFocus();
            }
        } 

            if (Input.GetMouseButtonDown(1))
            {
                Ray ray2 = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit2;

                if (Physics.Raycast(ray2, out hit2, 100))
                {
                      
                    Debug.Log("Interacting with " + hit2.collider.name + " " + hit2.point);
                    
                    Interactable interactable = hit2.collider.GetComponent<Interactable>();
                    if (interactable != null)
                    {
                        
                        SetFocus(interactable);
                    }

                }

            }
        }
    
        void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
        }

    void RemoveFocus() {
        focus = null;
    }
    
}

    
