﻿public abstract class Unit
{
    public string Id { get; private set; }
    public abstract string Type { get; }

    protected Unit(string Id)
    {
        this.Id = Id;
    }
}

