using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int wordCount = 0;

        // While loop to build a sentence with 7 random words
        while (wordCount < 7)
        {
            // Pick a random word from the array
            string randomWord = words[UnityEngine.Random.Range(0, words.Length)];

            // Add the word to the sentence
            sentence += randomWord + " ";

            // Increment the word count
            wordCount++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
