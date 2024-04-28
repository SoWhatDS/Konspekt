using System;


namespace ICloneableTest
{
    internal sealed class Enemy : ICloneable
    {
        public object Clone()
        {
            //если монобех то через Instantiate
            //либо можно использовать MemberwiseClone() который возвращает копию объекта.
            //если объект сложный и имеет ссылки в свойсвах на интерфейс, то необходимо делать глубокое копирование DeepCopy в паттернах Prototype
            return new Enemy();
        }
    }
}
