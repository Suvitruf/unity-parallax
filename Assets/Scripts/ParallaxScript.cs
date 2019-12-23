using UnityEngine;

namespace KaizoTrap {
    public class ParallaxScript : MonoBehaviour {
        private float startPos, length;
        public new GameObject camera;
        public float paralaxEffect;

        void Start() {
            startPos = transform.position.x;
            length   = GetComponent<SpriteRenderer>().bounds.size.x;
        }

        void Update() {
            float temp = camera.transform.position.x * (1 - paralaxEffect);
            float dist = camera.transform.position.x * paralaxEffect;

            transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

            if (temp > startPos + length)
                startPos += length;
            else if (temp < startPos - length)
                startPos -= length;
        }
    }
}
