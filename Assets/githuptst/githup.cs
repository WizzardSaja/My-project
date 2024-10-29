using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class githup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        int counter = 0;

        while (counter < 25)
        {
           
            int randomNumber = Random.Range(1, 21);

            // If the number is 5, skip printing it 
            if (randomNumber == 5)
            {
                continue;
            }

            // امر الطباعة بعد كونتيو لتخطي طباعة الرقم 5 
            Debug.Log("Generated Number: " + randomNumber);

            // If the number is 15, break to exit the loop
            if (randomNumber == 15)
            {
                Debug.Log("Number 15 found! Exiting the loop.");
                break;
            }

           
            counter++;
       }

       } 
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
