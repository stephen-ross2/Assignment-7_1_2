using System.Text;

namespace Assignment_7_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";

            // Call the function to merge the two strings
            string merged = MergeStrings(word1, word2);

            // Print the merged string
            Console.WriteLine(merged);
        }

        // Method to merge two strings by alternating their characters
        static string MergeStrings(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int i = 0, j = 0;

            // Loop until we reach the end of one of the strings
            while (i < word1.Length || j < word2.Length)
            {
                // Add character from word1 if available
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                    i++;
                }

                // Add character from word2 if available
                if (j < word2.Length)
                {
                    result.Append(word2[j]);
                    j++;
                }
            }

            // Return the merged string
            return result.ToString();
        }
    }
}
       
