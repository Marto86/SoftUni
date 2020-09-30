using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.__Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
          
            var queue = new Queue<string>(songs);
            while (queue.Count != 0 )
            {

                var commands = Console.ReadLine();
                var command = "";

                if (commands.Count() > 4)
                {
                    command = commands.Substring(0, 3);
                }
                else
                {
                    command = commands;
                }

                switch (command)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        var song = commands.Substring(3).Trim();
                        AddSong(queue, song);
                        break;
                    case "Show":
                        ShowSongs(queue);
                        break;
                }

            }

            if (queue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }

        private static void ShowSongs(Queue<string> songQueue)
        {
            Console.WriteLine(string.Join(", ", songQueue));
        }

        private static void AddSong(Queue<string> songQueue, string song)
        {
            if (!songQueue.Contains(song))
            {
                songQueue.Enqueue(song);
            }
            else
            {
                Console.WriteLine($"{song} is already contained!");
            }


        }




        }
    }

