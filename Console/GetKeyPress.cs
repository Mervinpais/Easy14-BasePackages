//_params = item

ConsoleKeyInfo key = Console.ReadKey(true);
if (item == "Key") return key.Key;
else if (item == "Char") return key.KeyChar;
else if (item == "Modifiers") return key.Modifiers;
else return key;