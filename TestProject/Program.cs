string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

for (int i = 0; i < words.Length; i++) {
    char[] word = words[i].ToCharArray();
    Array.Reverse(word);
    words[i] = new string(word);
}

pangram = string.Join(" ", words);

Console.WriteLine(pangram);

// char[] pangramArray = pangram.ToCharArray();

// Array.Reverse(pangramArray);

// string result = new string(pangramArray);

// Console.WriteLine(result);