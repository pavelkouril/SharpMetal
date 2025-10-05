namespace SharpMetal.Generator.Linked
{
    public class CSharpFile
    {
        public List<CSharpNamespace> Namespaces { get; private set; }

        public string Name;

        public CSharpFile(string name)
        {
            Name = name;
            Namespaces = [];
        }
    }
}
