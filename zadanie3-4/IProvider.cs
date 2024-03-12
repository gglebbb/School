using System;

namespace Gleb
{
    public interface IProvider<T>
    {
        T GetRandomValue();
        T GetUserValue();
    }
}