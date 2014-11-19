using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
  AllowMultiple = true)]
public class VersionAttribute : System.Attribute
{
    public string Name { get; private set; }

    public VersionAttribute(string vers)
    {
        this.Name = vers;
    }
}

