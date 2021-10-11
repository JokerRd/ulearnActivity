using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestBuilder_ShouldBeOk();
        }
        
        public static void TestBuilder_ShouldBeOk()
        {
            var builder = new ScaryMazeBuilder();
            var maze = builder
                .AddRock(5, 6)
                .AddRock(5, 4)
                .AddRock(4, 5)
                .AddGhost(5, 5) 
                .AddGhost(15, 5) 
                .Build();
        }
    }

    public class Maze
    {
        
    }

    public class MazeBuilder<T> where T: MazeBuilder<T>
    {
        protected Maze maze = new Maze();
    
        public T AddRock(int x, int y)
        {
            return (T)this;
        }
        
        public Maze Build()
        {
            return maze;
        }
        
    }
    
    public class ScaryMazeBuilder : MazeBuilder<ScaryMazeBuilder>
    {
        public ScaryMazeBuilder AddGhost(int x, int y)
        {
            return this;
        }
    }
    
}