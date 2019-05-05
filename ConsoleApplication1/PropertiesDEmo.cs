using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
struct MutableStruct
{
    public int Value 
    { 
        get; 
        set; 
    }
    public void SetValue(int newValue) // set the value to Value property
    {
        Value = newValue;
    }
}

class MutableStructHolder
{
    public MutableStruct Field;
    public MutableStruct Property 
    { 
        get;
        set; 
    }
}

class TestAbstract
{    
    static void Main(string[] args)
    {
        MutableStructHolder holder = new MutableStructHolder();
        // Affects the value of holder.Field
        holder.Field.SetValue(10);
        // Retrieves holder.Property as a copy and changes the copy
        holder.Property.SetValue(100);
        Console.WriteLine(holder.Field.Value);
        Console.WriteLine(holder.Property.Value);
    }
}
}

