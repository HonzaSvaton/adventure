﻿using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public BaseRoom CurrentRoom { get; private set; }
        public Inventory Inventory { get; } = new();
        
        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();
            var dungeon = new Dungeon();
            var inferno = new Inferno();
            var library = new Library();
            
            lobby.RegisterNeighbour(corridor);
            corridor.RegisterNeighbour(lobby);
            corridor.RegisterNeighbour(inferno);
            inferno.RegisterNeighbour(corridor);
            lobby.RegisterNeighbour(library);
            library.RegisterNeighbour(lobby);

            CurrentRoom = lobby;
        }
        public bool SwitchRoom(BaseRoom room)
        {
            if (room.Locked)
            {
                AnsiConsole.MarkupLine($"[red]This room is locked you need a Key to unlock it[/]");
                return false;
            }
            CurrentRoom = room;
            return true;
        }

        public string Intro { get; } = @"
How did you end up here? You don't really know. Maybe you fell, maybe someone pushed you.
One thing is certain, you need to [red italic]GET OUT OF HERE![/]
";
    }
}
