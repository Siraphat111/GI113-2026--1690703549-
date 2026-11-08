/*
* Student ID :1690703549
* Name       :Siraphat Darasa
* Section    :129B
* No.        :34
* Course     : GI113 Computer Programming (GI)
*/
using Unity.VisualScripting;
using UnityEngine;

public class Lab08 : MonoBehaviour
{
   public int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
    int sum;
    float averrage;
    int maximum;
    int minimum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ปริ้นค่าทั้งหมดใน allay loop "scores"
        //แบบ for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

        //แบบ for each loop
        foreach (int score in numbers)
        {
            Debug.Log(score);
        }

        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        averrage = (float)sum / numbers.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + averrage);

        maximum = numbers[0];
        minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);

        System.Array.Sort(numbers);
        foreach (int n in numbers)
        {
            Debug.Log("Sorted: " + n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
