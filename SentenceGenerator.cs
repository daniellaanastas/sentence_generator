using System;

class SentenceGenerator {

     string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        Random random = new Random();
        string sentence = "";
        int wordCount = 0;

        while (wordCount < 7)
        {
            string randomWord = words[random.Next(words.Length)];
            sentence += randomWord + " ";
            wordCount++;
        }

        Console.WriteLine(sentence.Trim());
}