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

public class Kata
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
