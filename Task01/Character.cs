using System;

namespace Task01
{
    class Character
    {
        private string _name;
        private int _horizontalPosition;
        private int _verticalPosition;
        private bool _isAlive;

        private Random random = new Random();

        public Character(string name, int horizontalPosition, int verticalPosition, bool isAlive)
        {
            _name = name;
            _horizontalPosition = horizontalPosition;
            _verticalPosition = verticalPosition;
            _isAlive = isAlive;
        }

        public int HorizontalPosition => _horizontalPosition;
        public int VerticalPosition => _verticalPosition;

        public void Kill()
        {
            _isAlive = false;
        }

        public void Move()
        {
            if (_horizontalPosition == 0 && _horizontalPosition == 0) return;

            _horizontalPosition += _horizontalPosition > 0 ? random.Next(-1, 1) : 0;
            _verticalPosition += _verticalPosition > 0 ? random.Next(-1, 1) : 0;
        }

        public void Show(int numberCharacter)
        {
            if (_isAlive == false) return;
            Console.SetCursorPosition(_horizontalPosition, _verticalPosition);
            Console.Write($"{numberCharacter}");
        }
    }
}
