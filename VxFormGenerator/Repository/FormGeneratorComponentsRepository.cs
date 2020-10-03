using System;
using System.Collections.Generic;

namespace VxFormGenerator.Repository
{

    public class FormGeneratorComponentsRepository<TKey> : IFormGeneratorComponentsRepository
    {
        protected Dictionary<TKey, Type> _ComponentDict = new Dictionary<TKey, Type>();

        public Type DefaultComponent { get; protected set; }

        public FormGeneratorComponentsRepository()
        {

        }

        protected void RegisterComponent(TKey key, Type component)
        {
            _ComponentDict.Add(key, component);
        }

        protected void RemoveComponent(TKey key)
        {
            _ComponentDict.Remove(key);
        }

        protected Type GetComponent(TKey key)
        {
            var found = _ComponentDict.TryGetValue(key, out Type outVar);

            return found ? outVar : DefaultComponent;
        }

        public void Clear()
        {
            _ComponentDict.Clear();
        }

        public void RegisterComponent(object key, Type component)
        {
            RegisterComponent(key, component);
        }

        public void RemoveComponent(object key)
        {
            RemoveComponent(key);
        }

        public Type GetComponent(object key)
        {
            return GetComponent(key);
        }
    }
}
