using System;
using System.Collections.Generic;
using System.Text;

namespace VxFormGenerator
{
    public interface IFormGeneratorOptions
    {
        public Type FormElementComponent { get; set; }
    }
}
