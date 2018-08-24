using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeChangesSphereColor {
    public class GameMaster : MonoBehaviour {
        public Color color;
        public GameObject Sphere;

        Color GetRandomColor()
        {
            float r = Random.Range(0.0f, 1.0f);
            float g = Random.Range(0.0f, 1.0f);
            float b = Random.Range(0.0f, 1.0f);
            return new Color(r, g, b);
        }
        void ChangeColor()
        {
            Sphere.GetComponent<Renderer>().material.color = GetRandomColor();
        }
        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }

        void OnMouseDown()
        {
            ChangeColor();
        }
    }

}
