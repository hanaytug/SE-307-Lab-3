using System;

namespace SE_307_Lab_3
{
    public class Question3
    {
        
        public static void Question3_Main()
        {
            // As I wrote before c# is case-sensitive so writing main doesn't not match rule Methods, and this String args [] must be written as String[] args
            // if we were using java String args[] will work too but this is not compatible with C syntax. and method must be static
            // I'm renaming main to something else because I already have main method at Program.cs I don't want to create another project.
            int row = 1;
            while (row <= 10)
            {
                // C# is case-sensitive for his identifiers so it must be while
                int column = 1;
                if (row % 2 == 0) // if is a selection statement and if write ; at the end selection will fail we need Console.Write(" ") to our program run smoothly.
                    Console.Write("  ");
                if (column <= 20)
                {
                    // System.out.print belong to Java. We should write Console.Write();
                    Console.Write(" * ");
                    column++;
                }

                // System.out.println belong to Java. We should write Console.WriteLine();
                Console.WriteLine();
                row++; // postdecrement operator doesn't have space beetween dashes
                //While condition if row <= 10 so if the decrement row condition will never be false it's run infinitely
                // to fix this i'm incrementing it
            }
        }
    }
}