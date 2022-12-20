using System;

namespace Task01
{
    class Program
    {
        private static Character[] characters =
        {
            new Character("Character01", 10, 10, true),
            new Character("Character02", 15, 15, true),
            new Character("Character03", 25, 25, true)
        };

        private static void CheckCharactersDeath()
        {
            for (int index = 0; index < characters.Length; index++)
            {
                for (int nextIndex = index + 1; nextIndex < characters.Length; nextIndex++)
                {
                    Character СurrentСharacter = characters[index];
                    Character NextCharacter = characters[nextIndex];

                    if (СurrentСharacter.HorizontalPosition == NextCharacter.HorizontalPosition &&
                        СurrentСharacter.VerticalPosition == NextCharacter.VerticalPosition)
                    {
                        СurrentСharacter.Kill();
                        NextCharacter.Kill();
                    }
                }
            }
        }

        private static void MoveAllCharacters()
        {
            for (int index = 0; index < characters.Length; index++)
            {
                characters[index].Move();
            }
        }

        private static void ShowAllCharacters()
        {
            for (int index = 0; index < characters.Length; index++)
            {
                characters[index].Show(index);
            }
        }

        private static void Main()
        {
            while (true)
            {
                CheckCharactersDeath();
                MoveAllCharacters();
                ShowAllCharacters();
            }
        }
    }
}
