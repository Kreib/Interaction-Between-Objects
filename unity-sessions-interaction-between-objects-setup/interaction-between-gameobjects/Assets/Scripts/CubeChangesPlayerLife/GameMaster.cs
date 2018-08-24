using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {
        // Use this for initialization
        public int Life = 10;
        public GameObject Sphere;
        void Start () {

		}

		// Update is called once per frame
		void Update () {
            if (Life <= 0)
            {
                Sphere.SetActive(false);
            }
		}
         void OnMouseDown()
        {
            Life -= 1;
        }
        private void OnGUI()
        {
            if (Life >= 0)
            {
                GUILayout.Label("Player Life " + Life);
            }
            else
            {
                GUILayout.Label("YOU DIED");
            }
               
        }
    }
}
