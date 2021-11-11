// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SongManager : MonoBehaviour
// {
// // for song position tracking, music note spawning & song managing stuff 



//     // current position of the song (in sec)
//     private float songPosition;

//     // current position of the song ( in beats)
//     private float songPosInBeats;

//     // duration of a beat 
//     private float secPerBeat;

//     // how much time ( in sec.) has passed since the song started
//     private float dsptimesong;





//     //beats per minute of a song
//     private float bpm;

//     //keep all the position-in-beats of notes in the song
//     private float[] notes;

//     //the index of the next note to be spawned
//     private int nextIndex = 0;

//     //prefab 
//     public GameObject myPrefab;



//     // Start is called before the first frame update
//     void Start()
//     {
//         //initialize 

//         //calculate how many seconds is one beat
//         //we will see the declaration of bpm later
//         secPerBeat = 60f / bpm;

//         //record the time when the song starts
//         dsptimesong = (float)AudioSettings.dspTime;

//         //start the song
//         GetComponent<AudioSource>().Play();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //calculate the position in seconds
//         songPosition = (float)(AudioSettings.dspTime - dsptimesong);

//         //calculate the position in beats
//         songPosInBeats = songPosition / secPerBeat;


//         //spwaning notes 
//         // if (nextIndex < notes.Length && notes[nextIndex] < songPosInBeats + beatsShownInAdvance)
//         // {
//         //     Instantiate(myPrefab);

//         //     //initialize the fields of the music note

//         //     nextIndex++;
//         // }
//     }
// }
