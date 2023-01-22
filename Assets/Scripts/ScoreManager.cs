using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AugmentedScore
{
    public class ScoreManager : MonoBehaviour
    {
        public GameObject playButton;
        public GameObject stopButton;
        public GameObject arCamera;
        public float front;
        public GameObject ballHeld1Prefab;
        public GameObject ballHeld2Prefab;

        public AudioClip g3_1;
        public AudioClip f3_1;
        public AudioClip e3_1;
        public AudioClip d3_1;
        public AudioClip c3_1;
        public AudioClip b2_1;
        public AudioClip a2_1;
        public AudioClip g2_1;
        public AudioClip f2_1;
        public AudioClip e2_1;
        public AudioClip d2_1;

        public AudioClip g3_2;
        public AudioClip f3_2;
        public AudioClip e3_2;
        public AudioClip d3_2;
        public AudioClip c3_2;
        public AudioClip b2_2;
        public AudioClip a2_2;
        public AudioClip g2_2;
        public AudioClip f2_2;
        public AudioClip e2_2;
        public AudioClip d2_2;

        public BeatController beat1;
        public BeatController beat2;
        public BeatController beat3;
        public BeatController beat4;
        public BeatController beat5;
        public BeatController beat6;
        public BeatController beat7;
        public BeatController beat8;
        public float waitSec;
        private WaitForSeconds wait;
        private Coroutine playBeats;

        // Start is called before the first frame update
        void Start()
        {
            wait = new WaitForSeconds(waitSec);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnClearButtonClicked()
        {
            SceneManager.LoadScene("AugmentedScore");
        }

        public void OnCreateBall1ButtonClicked()
        {
            Transform camTran = arCamera.transform;
            Vector3 curPos = camTran.position + front * camTran.forward;
            GameObject ballHeld1 = Instantiate(ballHeld1Prefab, curPos, Quaternion.identity);
            ballHeld1.transform.SetParent(camTran);  // AR Cameraの子に設定してAR Cameraに追従させる
        }

        public void OnCreateBall2ButtonClicked()
        {
            Transform camTran = arCamera.transform;
            Vector3 curPos = camTran.position + front * camTran.forward;
            GameObject ballHeld2 = Instantiate(ballHeld2Prefab, curPos, Quaternion.identity);
            ballHeld2.transform.SetParent(camTran);  // AR Cameraの子に設定してAR Cameraに追従させる
        }

        public void OnPlaceBallButtonClicked()
        {
            Debug.Log("Clicked PlaceBall Button.");
            // 落下後どこにも衝突せずに残っているボールが存在するかもなので、複数取得する
            GameObject[] ballsHeld = GameObject.FindGameObjectsWithTag("BallHeld");
            Debug.Log("Gatherd balls.");
            foreach (GameObject ballHeld in ballsHeld)
            {
                Rigidbody rb = ballHeld.GetComponent<Rigidbody>();
                Debug.Log("Got rigidbody.");
                rb.useGravity = true;
                Debug.Log("Placed ball.");
            }
        }

        public void OnPlayButtonClicked()
        {
            playBeats = StartCoroutine("PlayBeats");
            stopButton.SetActive(true);
            playButton.SetActive(false);
        }

        public void OnStopButtonClicked()
        {
            StopCoroutine(playBeats);
            playButton.SetActive(true);
            stopButton.SetActive(false);
        }

        private IEnumerator PlayBeats()
        {
            while (true)
            {
                beat1.PlayNotes();
                yield return wait;
                beat2.PlayNotes();
                yield return wait;
                beat3.PlayNotes();
                yield return wait;
                beat4.PlayNotes();
                yield return wait;
                beat5.PlayNotes();
                yield return wait;
                beat6.PlayNotes();
                yield return wait;
                beat7.PlayNotes();
                yield return wait;
                beat8.PlayNotes();
                yield return wait;
            }
        }
    }
}