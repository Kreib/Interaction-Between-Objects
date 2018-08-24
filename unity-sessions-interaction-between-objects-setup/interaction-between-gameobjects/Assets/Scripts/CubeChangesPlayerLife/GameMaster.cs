using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {
        // Use this for initialization
        public int Life = 10;
        public Player Sphere;
        void Start () {

		}

		// Update is called once per frame
		void Update () {
            if (Sphere.Life <= 0)
            {

             
                Sphere.gameObject.SetActive(false);
            }
		}
         void OnMouseDown()
        {
            Sphere.Life--;
        }
       
    }
}
