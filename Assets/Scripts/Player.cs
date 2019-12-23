using UnityEngine;

namespace KaizoTrap {

    public class Player : MonoBehaviour {
        private SpriteRenderer spriteRenderer;
        private Rigidbody2D body;
        public float speed;

        void Awake() {
            body = GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        
        void Update() {
            var x = Input.GetAxisRaw("Horizontal");
            body.velocity = new Vector2(x, 0).normalized * speed;

            if (Mathf.Abs(x) > 0.0001f)
                spriteRenderer.flipX = x > 0;
        }
    }
}