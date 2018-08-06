using System;
namespace InterfaceTester
{
    interface IParameterPanel
    {
        int ArgIndex { get; }
        Type ArgType { get; }
        object ArgValue { get; }
    }
}
