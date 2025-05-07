string result = "";
        k = k % 26; // 26'dan büyükse tekrar başa döner

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)(((c - baseChar + k) % 26) + baseChar);
                result += encryptedChar;
            }
            else
            {
                result += c;
            }
        }

        return result;
