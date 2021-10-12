using System;

namespace Learning
{
    class L_2056_Scholarship
    {
        public void Start()
        {
            int expamenCount = int.Parse(Console.ReadLine());
            int ratingSum = 0;
            int curentRating;
            double rating;
            string answer = null;
            for (int i = 0; i < expamenCount; i++)
            {
                curentRating = int.Parse(Console.ReadLine());
                ratingSum += curentRating;
                if (curentRating == 3)
                {
                    answer = "None";
                    break;
                }
            }
            if (answer == null)
            {
                rating = (double)ratingSum / expamenCount;
                if (rating == 5) { answer = "Named"; }
                else
                    if (rating >= 4.5) { answer = "High"; }
                else { answer = "Common"; }
            }
            Console.WriteLine(answer);
        }
    }
}
