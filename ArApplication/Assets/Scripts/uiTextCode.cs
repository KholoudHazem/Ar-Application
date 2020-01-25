using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace vuforia
{
    public class uiTextCode : MonoBehaviour
    {

        // define red tanker and the precentage text
        public GameObject RedTank;

        public Transform textPanel;
        public Transform precText;


        // a string variable to store the name of object hit by ray
        string hitObj;

        void Start()
        {

            // hide both tanker and precentage text at the beginning
            RedTank.SetActive(false);

            textPanel.gameObject.SetActive(true);
            precText.gameObject.SetActive(true);
        }
        void Update()
        {

            // detect touches on camera
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                // check if ray hit an object 
                if (Physics.Raycast(ray, out hit))
                {

                    // store the name of object hit by ray 
                    hitObj = hit.transform.name;

                    // depending on the name of object hit show/hide the red tanker and the precentage text
                    switch (hitObj)
                    {
                        case "tanker":

                            // to show red tanker
                            RedTank.SetActive(true);

                            // activate panel & text
                            textPanel.gameObject.SetActive(true);
                            precText.gameObject.SetActive(true);
                            break;
                        case "red tanker":

                            // hide red tanker
                            RedTank.SetActive(false);

                            // hide panel & text
                            textPanel.gameObject.SetActive(false);
                            precText.gameObject.SetActive(false);
                            break;
                        default:
                            break;
                    }
                }


            }
        }
    }
}