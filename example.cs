using System;
using System.Collections.Generic;
// Gives access to List<T> Class & Dictionary<TKey,TValue> Class

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
