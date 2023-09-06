void IsPalindrome()
{
    do
    {
        string word = Console.ReadLine()!.ToLower();
        char[] arr = word.ToCharArray();
        char[] reverse = arr.Reverse().ToArray();
        string reverseJoin = string.Join("", reverse);

        if (word.Replace(" ","").Equals(reverseJoin.Replace(" ","")))
        {
            Console.WriteLine("true\n");
        }
        else
        {
            Console.WriteLine("false\n");
        }
    } while (1 > 0);
}


IsPalindrome();