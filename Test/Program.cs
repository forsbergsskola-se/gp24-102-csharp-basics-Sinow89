Console.WriteLine("Escape Characters Demo:");
        
// Newline (\n)
Console.WriteLine("\\n - Newline: This is line one.\nThis is line two.");
        
// Tab (\t)
Console.WriteLine("\\t - Tab: Column 1\tColumn 2\tColumn 3");
        
// Backslash (\\)
Console.WriteLine("\\\\ - Backslash: C:\\Program Files\\MyApp");
        
// Single Quote (\')
Console.WriteLine("\\\' - Single Quote: It\'s a wonderful day!");
        
// Double Quote (\")
Console.WriteLine("\\\" - Double Quote: She said, \"Hello, World!\"");
        
// Carriage Return (\r)
Console.WriteLine("\\r - Carriage Return: Hello, World!\rOverwritten");
        
// Bell (\a)
Console.WriteLine("\\a - Bell (alert sound): This should trigger a sound.\a");
        
// Backspace (\b)
Console.WriteLine("\\b - Backspace: Removing the last character... backsp\bce!");
        
// Vertical Tab (\v)
Console.WriteLine("\\v - Vertical Tab: Hello\vWorld!");
        
// Null Character (\0)
Console.WriteLine("\\0 - Null Character: Null character here\0end");

// Form Feed (\f)
Console.WriteLine("\\f - Form Feed: First Page\fNew Page or Section");

// Unicode character (\u)
Console.WriteLine("\\u - Unicode: Smile face \u263A, Heart \u2665");

// Hexadecimal escape (\x)
Console.WriteLine("\\x - Hexadecimal: Letter A: \x41, Heart: \x2665");

// Verbatim string literal (@)
Console.WriteLine(@"@ - Verbatim string: This keeps 
everything as typed including backslashes \ and ""quotes"".");

// Newline using Environment.NewLine
Console.WriteLine("Environment.NewLine: First line" + Environment.NewLine + "Second line");

// Wait for the user to see the results
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();