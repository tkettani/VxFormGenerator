using System;

namespace VxFormGenerator.Repository
{
    public interface IFormGeneratorComponentsRepository
    {
        public Type FormElementComponent { get; }
        public void RegisterComponent(object key, Type component);
        public void RemoveComponent(object key);
        public Type GetComponent(object key);
    }
}