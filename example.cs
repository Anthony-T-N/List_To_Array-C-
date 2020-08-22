using System;
using System.Collections.Generic;
// Gives access to List<T> Class & Dictionary<TKey,TValue> Class

// Following example used to take specific elements from an array and add it to a list.
public static class placeholder
{
  public static int[] Capitals(string word)
  {
    List<int> index_list = new List<int>();
    for (int i = 0; i <= word.Length - 1; i++)
    {
      if (word[i] == char.ToUpper(word[i]))
      {
        index_list.Add(i);
      }
    }
    int[] index_array = new int[index_list.Count];
    for (int i = 0; i <= index_list.Count - 1; i++)
    {
      index_array[i] = index_list[i];
    }
    return index_array;
  }
}

// ===================================================================================================================

using System;
using System.Collections.Generic;

public class ---
{
  public static int DuplicateCount(string str)
  {
    Dictionary<char, int> count_dict = new Dictionary<char, int>();
    if (str.Length <= 0)
    {
      return 0;
    }
    for (int i = 0; i <= str.Length - 1; i++)
    {
      if (count_dict.ContainsKey(Char.ToLower(str[i])))
      {
        count_dict[Char.ToLower(str[i])] += 1;
      }
      else
      {
        count_dict.Add(Char.ToLower(str[i]), 1);
      }
    }
    int total_duplicates = 0;
    foreach (KeyValuePair<char, int> kvp in count_dict)
    {
      if (kvp.Value >= 2)
      {
        total_duplicates += 1;
      }
    }
    return total_duplicates;
  }
}

// ===================================================================================================================

using System.Collections.Generic;

public class ---
{
  public static string DuplicateEncode(string word)
  {
    string str = word;
    Dictionary<char, int> count_dict = new Dictionary<char, int>(); 
    for (int i = 0; i <= str.Length - 1; i++)
    {
      if (count_dict.ContainsKey(char.ToLower(str[i])))
      {
        count_dict[char.ToLower(str[i])] += 1;
      }
      else
      {
        count_dict.Add(char.ToLower(str[i]), 1);
      }
    }
    char[] charArr = str.ToCharArray();
    for (int i = 0; i <= charArr.Length - 1; i++)
    {
      if (count_dict[char.ToLower(charArr[i])] <= 1)
      {
        System.Console.WriteLine(charArr[i]);
        charArr[i] = '(';
      }
      else
      {
        charArr[i] = ')';
      }
    }
    // Array of characters to string.
    str = new string(charArr);
    return str;
  }
}
// ===================================================================================================================
using System.Collections.Generic;

public static class ---
{
  public static string AlphabetPosition(string text)
  {
    Dictionary<char, int> count_dict = new Dictionary<char, int>()
    {
      	{'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, 
        {'f', 6}, {'g', 7}, {'h', 8}, {'i', 9}, {'j', 10}, 
        {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14}, {'o', 15}, {'p', 16}, 
        {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20}, {'u', 21}, 
        {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25}, {'z', 26}
    };
    /*
    foreach(var kvp in count_dict)
    {
      System.Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
    */
    List<string> index_list = new List<string>();
    for (int i = 0; i <= text.Length - 1; i++)
    {
      // System.Console.WriteLine(text[i]);
      if (count_dict.ContainsKey(char.ToLower(text[i])))
      {
        index_list.Add(count_dict[char.ToLower(text[i])].ToString());
      }
    }
    //Converting string list to string.
    text = string.Join(" ", index_list);
    return text;
  }
}

// ===================================================================================================================

using System.Collections.Generic;

public static class ---
{
  public static string GetOrder(string input)
  {
    Dictionary<string, int> count_dict = new Dictionary<string, int>()
    {
    	{"burger", 0}, {"fries", 0}, {"chicken", 0}, {"pizza", 0}, 
      {"sandwich", 0}, {"onionrings", 0}, {"milkshake", 0}, {"coke", 0}
    };
    Dictionary<int, string> menu_dict = new Dictionary<int, string>()
    {
    	{1, "Burger"}, {2, "Fries"}, {3, "Chicken"}, {4, "Pizza"}, 
      {5, "Sandwich"}, {6, "Onionrings"}, {7, "Milkshake"}, {8, "Coke"}
    };
    string current_string = "";
    for (int i = 0; i <= input.Length - 1; i++)
    {
      System.Console.WriteLine(input[i]);
      current_string += input[i];
      if (count_dict.ContainsKey(current_string))
      {
        System.Console.WriteLine(current_string);
        count_dict[current_string] += 1;
        current_string = "";
      }
    }
    string split_list = "";
    for (int i = 0; i <= menu_dict.Count; i++)
    {
      if (menu_dict.ContainsKey(i))
      {
        System.Console.WriteLine("MENU_DICT: " + menu_dict[i]);
        System.Console.WriteLine(count_dict[menu_dict[i].ToLower()]);
        for (int j = 1; j <= count_dict[menu_dict[i].ToLower()]; j++)
        {
          split_list += menu_dict[i] + " ";
        }
      }
      System.Console.WriteLine(split_list);
    }
  	return split_list.TrimEnd();
  }
}
