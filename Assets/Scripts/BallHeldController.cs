using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AugmentedScore
{
    public class BallHeldController : MonoBehaviour
    {
        public float timeLimit = 5.0f;
        public GameObject ballPlacedPrefab;
        public int ballType;

        // Start is called before the first frame update
        void Start()
        {
            // Invoke("DestroyBall", timeLimit);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag != "Ground" && other.gameObject.tag != "BallHeld")
            {
                GameObject ballPlaced = Instantiate(ballPlacedPrefab, this.transform.position, Quaternion.identity);
            }
            // CancelInvoke();
            Destroy(this.gameObject);
        }

        private void DestroyBall()
        {
            Destroy(this.gameObject);
        }
    }
}