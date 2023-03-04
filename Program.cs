namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            string longest = LongestPalindrome("abcde");
            Console.WriteLine(longest);
            
        }

        public static string LongestPalindrome(string s) {
            //ece
            //eccccccceeee
            // qwenabbaakkoqd
            if(s.Length == 1)
            {
               return s.Substring(0,1);
            }


            int maxLength = 1;
            int length = s.Length;
            string maxLengthStr = "";

            for(int i = 0; i < length; i++)
            {
                int left = i; int right = i;
            
                // odd palindrome
                while(left >= 0 && right < length   && s[left] == s[right])
                {
                    if(right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        maxLengthStr = s.Substring(left,maxLength);
                    }
                    left--;
                    right++;
                }

                //even palindrome
                left = i; right = i+1;
                while(left >= 0 &&  right < length && s[left] == s[right])
                {
                    if(right - left + 1 > maxLength)
                    {
                        maxLength = right - left + 1;
                        maxLengthStr = s.Substring(left,maxLength);
                    }
                    left--;
                    right++;
                }


            }
            if(maxLengthStr == "") return s.Substring(0,1);
            return maxLengthStr;
        }

    }


}
