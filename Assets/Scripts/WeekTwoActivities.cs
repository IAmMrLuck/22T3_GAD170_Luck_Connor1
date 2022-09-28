using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnorLuck
{

    public class WeekTwoActivities : MonoBehaviour
    {
        // this is my favourite game, and it will be used to 
        private string myFavouriteGame = "Hollow Knight";

        // 
        private float hoursPlayed = 100f;

        //
        private float costOfGame = 25f;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My Favourite Game Is " + (myFavouriteGame) +
               ", I have played it for " + (hoursPlayed) + " hours, "
               + "and it cost me $" + (costOfGame) + ". Therefore my value of dollars per hour is "
               + (costOfGame / hoursPlayed) + ".");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
