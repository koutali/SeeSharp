namespace AsteroidCollision
{
    public class Asteroid
    {
        public static int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var asteroid in asteroids)
            {
                var asteroidToAdd = asteroid;
                while (stack.Any() && asteroidToAdd < 0 && stack.Peek() > 0)
                {
                    var difference = stack.Peek() + asteroid;
                    if (difference < 0)
                    {
                        stack.Pop();
                    }
                    else if (difference > 0)
                    {
                        asteroidToAdd = 0;
                    }
                    else
                    {
                        asteroidToAdd = 0;
                        stack.Pop();
                    }
                }

                if (asteroidToAdd != 0)
                {
                    stack.Push(asteroidToAdd);
                }
            }

            return stack.Reverse().ToArray();
        }
    }
}