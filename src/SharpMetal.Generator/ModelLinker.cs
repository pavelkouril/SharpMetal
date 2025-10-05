using SharpMetal.Generator.Instances;
using SharpMetal.Generator.Linked;

namespace SharpMetal.Generator
{
    public class ModelLinker
    {
        public List<CSharpFile> Link(List<HeaderInfo> headers, List<SelectorDefinition> selectorDefinitions)
        {
            var rv = new List<CSharpFile>();

            foreach (var header in headers)
            {
                foreach (var enumInstance in header.EnumInstances)
                {

                }
                foreach (var structInstance in header.StructInstances)
                {

                }
                foreach (var classInstance in header.ClassInstances)
                {

                }
            }

            return rv;
        }
    }
}
