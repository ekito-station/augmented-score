using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AugmentedScore
{
    public class NoteController : MonoBehaviour
    {
        [System.NonSerialized] public int soundType = 0;  // 0なら鳴らない
        public string soundPitch;
        public AudioSource audioSource;
        public ScoreManager scoreManager;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "BallHeld")
            {
                BallHeldController ballHeldController = other.gameObject.GetComponent<BallHeldController>();
                soundType = ballHeldController.ballType;
                PlayNote();
            }
        }

        public void PlayNote()
        {
            if (soundType == 1)
            {
                switch (soundPitch)
                {
                    case "G3":
                        audioSource.PlayOneShot(scoreManager.g3_1);
                        break;
                    case "F3":
                        audioSource.PlayOneShot(scoreManager.f3_1);
                        break;
                    case "E3":
                        audioSource.PlayOneShot(scoreManager.e3_1);
                        break;
                    case "D3":
                        audioSource.PlayOneShot(scoreManager.d3_1);
                        break;
                    case "C3":
                        audioSource.PlayOneShot(scoreManager.c3_1);
                        break;
                    case "B2":
                        audioSource.PlayOneShot(scoreManager.b2_1);
                        break;
                    case "A2":
                        audioSource.PlayOneShot(scoreManager.a2_1);
                        break;
                    case "G2":
                        audioSource.PlayOneShot(scoreManager.g2_1);
                        break;
                    case "F2":
                        audioSource.PlayOneShot(scoreManager.f2_1);
                        break;
                    case "E2":
                        audioSource.PlayOneShot(scoreManager.e2_1);
                        break;
                    case "D2":
                        audioSource.PlayOneShot(scoreManager.d2_1);
                        break;
                }
            }
            else if (soundType == 2)
            {
                switch (soundPitch)
                {
                    case "G3":
                        audioSource.PlayOneShot(scoreManager.g3_2);
                        break;
                    case "F3":
                        audioSource.PlayOneShot(scoreManager.f3_2);
                        break;
                    case "E3":
                        audioSource.PlayOneShot(scoreManager.e3_2);
                        break;
                    case "D3":
                        audioSource.PlayOneShot(scoreManager.d3_2);
                        break;
                    case "C3":
                        audioSource.PlayOneShot(scoreManager.c3_2);
                        break;
                    case "B2":
                        audioSource.PlayOneShot(scoreManager.b2_2);
                        break;
                    case "A2":
                        audioSource.PlayOneShot(scoreManager.a2_2);
                        break;
                    case "G2":
                        audioSource.PlayOneShot(scoreManager.g2_2);
                        break;
                    case "F2":
                        audioSource.PlayOneShot(scoreManager.f2_2);
                        break;
                    case "E2":
                        audioSource.PlayOneShot(scoreManager.e2_2);
                        break;
                    case "D2":
                        audioSource.PlayOneShot(scoreManager.d2_2);
                        break;
                }
            }
        }
    }
}