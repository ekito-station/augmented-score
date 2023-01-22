using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace AugmentedScore
{
    public class BeatController : MonoBehaviour
    {
        public UnityEvent Notes = new UnityEvent();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PlayNotes()
        {
            Notes.Invoke();
        }
    }
}